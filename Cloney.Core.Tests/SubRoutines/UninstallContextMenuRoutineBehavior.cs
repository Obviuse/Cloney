﻿using System.Collections.Generic;
using System.IO;
using Cloney.Core.Console;
using Cloney.Core.ContextMenu;
using Cloney.Core.Localization;
using Cloney.Core.SubRoutines;
using NSubstitute;
using NUnit.Framework;

namespace Cloney.Core.Tests.SubRoutines
{
    [TestFixture]
    public class UninstallContextMenuRoutineBehavior
    {
        private ISubRoutine routine;

        private IEnumerable<string> args;
        private IConsole console;
        private ITranslator translator;
        private IContextMenuInstaller uninstaller;
        private ICommandLineArgumentParser commandLineArgumentParser;



        [SetUp]
        public void SetUp()
        {
            args = new[] { "foo" };
            console = Substitute.For<IConsole>();
            translator = Substitute.For<ITranslator>();
            uninstaller = Substitute.For<IContextMenuInstaller>();
            translator.Translate(Arg.Any<string>()).Returns(x => x[0]);
            commandLineArgumentParser = Substitute.For<ICommandLineArgumentParser>();
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string> { { "uninstall", "true" } });

            routine = new UninstallContextMenuRoutine(console, translator, uninstaller, commandLineArgumentParser);
        }


        [Test]
        public void Run_ShouldParseIEnumerableToDictionary()
        {
            routine.Run(args);

            commandLineArgumentParser.Received().ParseCommandLineArguments(args);
        }

        [Test]
        public void Run_ShouldAbortForNoArguments()
        {
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string>());
            var result = routine.Run(args);

            Assert.That(result, Is.False);
            console.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void Run_ShouldAbortForMoreThanOneArgument()
        {
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string> { { "uninstall", "true" }, { "foo", "bar" } });
            var result = routine.Run(args);

            Assert.That(result, Is.False);
            console.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void Run_ShouldAbortForIrrelevantArgument()
        {
            commandLineArgumentParser.ParseCommandLineArguments(args).Returns(new Dictionary<string, string> { { "foo", "bar" } });
            var result = routine.Run(args);

            Assert.That(result, Is.False);
            console.DidNotReceive().WriteLine(Arg.Any<string>());
        }

        [Test]
        public void Run_ShouldProceedForRelevantArgument()
        {
            var result = routine.Run(args);

            Assert.That(result, Is.True);
        }

        [Test]
        public void Run_ShouldDisplayUninstallMessageForRelevantArgument()
        {
            routine.Run(args);

            translator.Received().Translate("UninstallSuccessMessage");
            console.Received().WriteLine("UninstallSuccessMessage");
        }

        [Test]
        public void Run_ShouldRunUninstallerForRelevantArgument()
        {
            routine.Run(args);

            uninstaller.Received().UnregisterContextMenu();
        }

        [Test]
        public void Run_ShouldPrintFriendlyFailMessageWhenUninstallationFails()
        {
            const string exceptionMessage = "Something exceptional occurred";
            uninstaller.When(x => x.UnregisterContextMenu())
                .Do(x => { throw new FileNotFoundException(exceptionMessage); });

            routine.Run(args);

            translator.Received().Translate("UninstallErrorMessage");
            console.Received().WriteLine("UninstallErrorMessage");
            console.Received().WriteLine(Arg.Is<string>(x => x.Contains(exceptionMessage)));
        }
    }
}