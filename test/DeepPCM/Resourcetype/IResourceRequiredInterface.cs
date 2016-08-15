//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Composition;
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.Identifier;
using Metamodel.Units;
using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Resourcetype
{
    
    
    /// <summary>
    /// The public interface for ResourceRequiredInterface
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ResourceRequiredInterface))]
    [XmlDefaultImplementationTypeAttribute(typeof(ResourceRequiredInterface))]
    public interface IResourceRequiredInterface : IModelElement, IReference, IRole
    {
        
        /// <summary>
        /// The resourceInterfaceRequiringEntity property
        /// </summary>
        IResourceInterfaceRequiringEntity ResourceInterfaceRequiringEntity
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the ResourceInterfaceRequiringEntity property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResourceInterfaceRequiringEntityChanging;
        
        /// <summary>
        /// Gets fired when the ResourceInterfaceRequiringEntity property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResourceInterfaceRequiringEntityChanged;
    }
}
