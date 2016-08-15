//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core;
using Metamodel.DeepPCM.Core.Composition;
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Protocol;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Resourcetype;
using Metamodel.DeepPCM.Seff;
using Metamodel.DeepPCM.System0;
using Metamodel.Identifier;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Repository
{
    
    
    /// <summary>
    /// The public interface for PassiveResource
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(PassiveResource))]
    [XmlDefaultImplementationTypeAttribute(typeof(PassiveResource))]
    public interface IPassiveResource : IModelElement, IEntity
    {
        
        /// <summary>
        /// The capacity_PassiveResource property
        /// </summary>
        IPCMRandomVariable Capacity_PassiveResource
        {
            get;
            set;
        }
        
        /// <summary>
        /// The basicComponent_PassiveResource property
        /// </summary>
        IBasicComponent BasicComponent_PassiveResource
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceTimeoutFailureType__PassiveResource property
        /// </summary>
        IResourceTimeoutFailureType ResourceTimeoutFailureType__PassiveResource
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Capacity_PassiveResource property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Capacity_PassiveResourceChanging;
        
        /// <summary>
        /// Gets fired when the Capacity_PassiveResource property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Capacity_PassiveResourceChanged;
        
        /// <summary>
        /// Gets fired before the BasicComponent_PassiveResource property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BasicComponent_PassiveResourceChanging;
        
        /// <summary>
        /// Gets fired when the BasicComponent_PassiveResource property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BasicComponent_PassiveResourceChanged;
        
        /// <summary>
        /// Gets fired before the ResourceTimeoutFailureType__PassiveResource property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResourceTimeoutFailureType__PassiveResourceChanging;
        
        /// <summary>
        /// Gets fired when the ResourceTimeoutFailureType__PassiveResource property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResourceTimeoutFailureType__PassiveResourceChanged;
    }
}

