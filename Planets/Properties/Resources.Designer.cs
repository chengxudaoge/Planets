﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Planets.Properties {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Planets.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;!--The planets--&gt;
        ///&lt;info&gt;
        ///	&lt;scale&gt;146e7&lt;/scale&gt;
        ///	&lt;interval&gt;86400&lt;/interval&gt;
        ///	&lt;planets&gt;
        ///		&lt;planet name=&quot;Sun&quot;&gt;
        ///			&lt;mass&gt;1.989e30&lt;/mass&gt;
        ///			&lt;xlocation&gt;0&lt;/xlocation&gt;
        ///			&lt;ylocation&gt;0&lt;/ylocation&gt;
        ///			&lt;xvelocity&gt;0&lt;/xvelocity&gt;
        ///			&lt;yvelocity&gt;0&lt;/yvelocity&gt;
        ///		&lt;/planet&gt;
        ///		&lt;planet name=&quot;Earth&quot;&gt;
        ///			&lt;mass&gt;5.9724e24&lt;/mass&gt;
        ///			&lt;xlocation&gt;147.09e9&lt;/xlocation&gt;
        ///			&lt;ylocation&gt;0&lt;/ylocation&gt;
        ///			&lt;xvelocity&gt;0&lt;/xvelocity&gt;
        ///			&lt;yvelocity&gt;30290&lt;/yvelocity&gt;
        ///		&lt;/planet&gt;
        ///		&lt;planet [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string info {
            get {
                return ResourceManager.GetString("info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap planet {
            get {
                object obj = ResourceManager.GetObject("planet", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
