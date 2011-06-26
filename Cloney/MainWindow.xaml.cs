﻿using System;
using System.Windows;
using System.Windows.Threading;
using Cloney.Domain.Cloning;
using Cloney.Domain.Cloning.Abstractions;
using Cloney.Domain.Extensions;

namespace Cloney
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly ICanCloneSolution solutionCloner;
        private readonly DispatcherTimer refreshTimer;


        public MainWindow()
        {
            InitializeComponent();

            var settings = Properties.Settings.Default;

            solutionCloner = new ThreadedSolutionCloner(new SolutionCloner(settings.ExcludeFolderPatterns.AsEnumerable(), settings.ExcludeFilePatterns.AsEnumerable(), settings.PlainCopyFilePatterns.AsEnumerable()));
            solutionCloner.CloningEnded += solutionCloner_CloningEnded;

            refreshTimer = new DispatcherTimer { Interval = new TimeSpan(0, 0, 0, 0, 10) };
            refreshTimer.Tick += refreshTimer_Tick;
            refreshTimer.IsEnabled = true;
            refreshTimer.Start();

            sourceFolderSelector.Initialize(new FolderNamespaceExtractor(), LastSourcePath);
            targetFolderSelector.Initialize(new FolderNamespaceExtractor(), LastTargetPath);
        }


        public bool CanInstall
        {
            get
            {
                return sourceFolderSelector.IsValid && targetFolderSelector.IsValid && solutionCloner.CurrentPath.IsNullOrEmpty();
            }
        }

        public string LastSourcePath
        {
            get { return Properties.Settings.Default.LastSourcePath; }
            set
            {
                Properties.Settings.Default.LastSourcePath = value;
                Properties.Settings.Default.Save();
            }
        }

        public string LastTargetPath
        {
            get { return Properties.Settings.Default.LastTargetPath; }
            set
            {
                Properties.Settings.Default.LastTargetPath = value;
                Properties.Settings.Default.Save();
            }
        }


        private void btnClone_Click(object sender, RoutedEventArgs e)
        {
            solutionCloner.CloneSolution(sourceFolderSelector.Path, sourceFolderSelector.Namespace, targetFolderSelector.Path, targetFolderSelector.Namespace);
        }

        private void folderSelector_OnChanged(object sender, EventArgs e)
        {
            if (!sourceFolderSelector.Path.IsNullOrEmpty())
                LastSourcePath = sourceFolderSelector.Path;
            if (!targetFolderSelector.Path.IsNullOrEmpty()) 
                LastTargetPath = targetFolderSelector.Path;

            btnClone.IsEnabled = CanInstall;
        }

        void refreshTimer_Tick(object sender, EventArgs e)
        {
            btnClone.IsEnabled = CanInstall;
            lblCurrentPath.Content = solutionCloner.CurrentPath;
        }

        static void solutionCloner_CloningEnded(object sender, EventArgs e)
        {
            MessageBox.Show(Cloney.Resources.Language.CloningEndedMessage, Cloney.Resources.Language.CloningEndedTitle, MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}