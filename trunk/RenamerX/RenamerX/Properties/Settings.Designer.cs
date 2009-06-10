﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RenamerX.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ShowName {
            get {
                return ((string)(this["ShowName"]));
            }
            set {
                this["ShowName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("$N - S$S2E$E2 - $T")]
        public string NameFormat {
            get {
                return ((string)(this["NameFormat"]));
            }
            set {
                this["NameFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+.avi|+.mkv|+.srt|+.sub")]
        public string RenameFileFilter {
            get {
                return ((string)(this["RenameFileFilter"]));
            }
            set {
                this["RenameFileFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowErrors {
            get {
                return ((bool)(this["ShowErrors"]));
            }
            set {
                this["ShowErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("s(?<Season>\\d+)e(?<Episode>\\d+)|(?<Season>\\d+)x(?<Episode>\\d+)|(?<Season>(?<!2)[0" +
            "1]?\\d)(?<Episode>\\d{2}(?!\\d))")]
        public string RegexpPattern {
            get {
                return ((string)(this["RegexpPattern"]));
            }
            set {
                this["RegexpPattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowActionMessages {
            get {
                return ((bool)(this["ShowActionMessages"]));
            }
            set {
                this["ShowActionMessages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("+.rar|+.r00")]
        public string ExtractFileFilter {
            get {
                return ((string)(this["ExtractFileFilter"]));
            }
            set {
                this["ExtractFileFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ExtractPath {
            get {
                return ((string)(this["ExtractPath"]));
            }
            set {
                this["ExtractPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string UnRARPath {
            get {
                return ((string)(this["UnRARPath"]));
            }
            set {
                this["UnRARPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SearchSubFolders {
            get {
                return ((bool)(this["SearchSubFolders"]));
            }
            set {
                this["SearchSubFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastRenameFolder {
            get {
                return ((string)(this["LastRenameFolder"]));
            }
            set {
                this["LastRenameFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LastExtractFolder {
            get {
                return ((string)(this["LastExtractFolder"]));
            }
            set {
                this["LastExtractFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(">10 MiB")]
        public string ExtractFileSizeFilter {
            get {
                return ((string)(this["ExtractFileSizeFilter"]));
            }
            set {
                this["ExtractFileSizeFilter"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool GuessShowName {
            get {
                return ((bool)(this["GuessShowName"]));
            }
            set {
                this["GuessShowName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ExtractOverwrite {
            get {
                return ((bool)(this["ExtractOverwrite"]));
            }
            set {
                this["ExtractOverwrite"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ExtractPassword {
            get {
                return ((string)(this["ExtractPassword"]));
            }
            set {
                this["ExtractPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ReplaceIllegalChars {
            get {
                return ((bool)(this["ReplaceIllegalChars"]));
            }
            set {
                this["ReplaceIllegalChars"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ReplaceIllegalCharsWith {
            get {
                return ((string)(this["ReplaceIllegalCharsWith"]));
            }
            set {
                this["ReplaceIllegalCharsWith"] = value;
            }
        }
    }
}
