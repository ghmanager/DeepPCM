//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Identifier;
using GeneratedCode.Pcm.Core.Composition;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Resourcetype;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace GeneratedCode.Pcm.Core.Entity
{
    
    
    /// <summary>
    /// The public interface for ResourceRequiredRole
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ResourceRequiredRole))]
    [XmlDefaultImplementationTypeAttribute(typeof(ResourceRequiredRole))]
    public interface IResourceRequiredRole : IModelElement, IRole
    {
        
        /// <summary>
        /// The requiredResourceInterface__ResourceRequiredRole property
        /// </summary>
        IResourceInterface RequiredResourceInterface__ResourceRequiredRole
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceInterfaceRequiringEntity__ResourceRequiredRole property
        /// </summary>
        IResourceInterfaceRequiringEntity ResourceInterfaceRequiringEntity__ResourceRequiredRole
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the RequiredResourceInterface__ResourceRequiredRole property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> RequiredResourceInterface__ResourceRequiredRoleChanged;
        
        /// <summary>
        /// Gets fired when the ResourceInterfaceRequiringEntity__ResourceRequiredRole property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged;
    }
}

