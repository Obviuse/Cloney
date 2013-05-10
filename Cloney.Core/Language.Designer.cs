﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cloney.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Language {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Language() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Cloney.Core.Language", typeof(Language).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clone solution with Cloney.
        /// </summary>
        internal static string ContextMenuText {
            get {
                return ResourceManager.GetString("ContextMenuText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Enter the path to the {0} folder:  .
        /// </summary>
        internal static string EnterFolderPath {
            get {
                return ResourceManager.GetString("EnterFolderPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///usage: cloney [--clone [--source=&lt;source&gt;] [--target=&lt;target&gt;]] [--help] [--install] [--modal] [--settings] [--uninstall]
        ///
        ///The most commonly used Cloney commands are:
        ///   [n/a]      Start the GUI application
        ///   clone      Clone a solution from a source folder to a target folder
        ///   help       Display general help
        ///   install    Install Windows Explorer context menu option for .sln files
        ///   modal      Start the GUI application in modal mode
        ///   settings   Display application settings
        ///   uninstall  Uni [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GeneralHelpMessage {
            get {
                return ResourceManager.GetString("GeneralHelpMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Starting the Cloney Wizard in modal mode....
        /// </summary>
        internal static string GuiModalStartMessage {
            get {
                return ResourceManager.GetString("GuiModalStartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Starting the Cloney Wizard...
        ///
        ///Type cloney --help for more options..
        /// </summary>
        internal static string GuiStartMessage {
            get {
                return ResourceManager.GetString("GuiStartMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///The Cloney Windows Explorer context menu option installer failed with the following error message:
        ///    .
        /// </summary>
        internal static string InstallErrorMessage {
            get {
                return ResourceManager.GetString("InstallErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Installing the Cloney Windows Explorer context menu option....
        /// </summary>
        internal static string InstallMessage {
            get {
                return ResourceManager.GetString("InstallMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///The Cloney Windows Explorer context menu option was successfully installed!
        ///
        ///To clone a solution using the context menu, right-click on a Visual Studio solution file, then select &quot;Clone solution with Cloney&quot;..
        /// </summary>
        internal static string InstallSuccessMessage {
            get {
                return ResourceManager.GetString("InstallSuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Cloney did not recognize the command.
        ///
        ///Type cloney --help for more options..
        /// </summary>
        internal static string NoRoutineMatchMessage {
            get {
                return ResourceManager.GetString("NoRoutineMatchMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///1. Excluded folder patterns:
        ///   {0}
        ///
        ///2. Excluded file patterns:
        ///   {1}
        ///
        ///3. Plain copy file patterns:
        ///   {2}.
        /// </summary>
        internal static string SettingsMessage {
            get {
                return ResourceManager.GetString("SettingsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///Cloney stopped with the following error message:
        ///.
        /// </summary>
        internal static string StartErrorMessage {
            get {
                return ResourceManager.GetString("StartErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///The Cloney Windows Explorer context menu option uninstaller failed with the following error message:
        ///    .
        /// </summary>
        internal static string UninstallErrorMessage {
            get {
                return ResourceManager.GetString("UninstallErrorMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstalling context menu option for Cloney....
        /// </summary>
        internal static string UninstallMessage {
            get {
                return ResourceManager.GetString("UninstallMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///The Cloney Windows Explorer context menu option was successfully uninstalled!.
        /// </summary>
        internal static string UninstallSuccessMessage {
            get {
                return ResourceManager.GetString("UninstallSuccessMessage", resourceCulture);
            }
        }
    }
}
