﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Verdandi.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Verdandi.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Дата создания.
        /// </summary>
        public static string CREATED_DATE {
            get {
                return ResourceManager.GetString("CREATED_DATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Дата и время начала выполнения задачи.
        /// </summary>
        public static string DATE_START {
            get {
                return ResourceManager.GetString("DATE_START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Оценка временных затрат.
        /// </summary>
        public static string EXPECTED_COMPLITION_TIME {
            get {
                return ResourceManager.GetString("EXPECTED_COMPLITION_TIME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Фактические временные затраты.
        /// </summary>
        public static string FACT_COMPLETION_TIME {
            get {
                return ResourceManager.GetString("FACT_COMPLETION_TIME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Видео, приложенное к задаче.
        /// </summary>
        public static string MEDIA {
            get {
                return ResourceManager.GetString("MEDIA", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Включить видео во время старта задачи.
        /// </summary>
        public static string OPEN_VIDEO_ON_TASK_START {
            get {
                return ResourceManager.GetString("OPEN_VIDEO_ON_TASK_START", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Описание задачи.
        /// </summary>
        public static string TASK_DESCRIPTION {
            get {
                return ResourceManager.GetString("TASK_DESCRIPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Название задачи.
        /// </summary>
        public static string TASK_NAME {
            get {
                return ResourceManager.GetString("TASK_NAME", resourceCulture);
            }
        }
    }
}