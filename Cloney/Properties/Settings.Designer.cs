﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cloney.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>*.suo</string>\r\n  <string>*.user</string>\r\n  <string>*.vssscc</string>\r\n</" +
            "ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ExcludeFilePatterns
        {
            get
            {
                return ((global::System.Collections.Specialized.StringCollection)(this["ExcludeFilePatterns"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>bin</string>
  <string>obj</string>
  <string>.git</string>
  <string>.svn</string>
  <string>_Resharper*</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection ExcludeFolderPatterns {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["ExcludeFolderPatterns"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>*.dll</string>
  <string>*.exe</string>
  <string>*.gif</string>
  <string>*.jpg</string>
  <string>*.png</string>
  <string>*.zip</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection PlainCopyFilePatterns {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["PlainCopyFilePatterns"]));
            }
        }
    }
}