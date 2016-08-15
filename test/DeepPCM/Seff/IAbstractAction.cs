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
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Seff.Seff_performance;
using Metamodel.DeepPCM.Seff.Seff_reliability;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Seff
{
    
    
    /// <summary>
    /// The public interface for AbstractAction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AbstractAction))]
    [XmlDefaultImplementationTypeAttribute(typeof(AbstractAction))]
    public interface IAbstractAction : IModelElement, IEntity
    {
        
        /// <summary>
        /// The predecessor_AbstractAction property
        /// </summary>
        IAbstractAction Predecessor_AbstractAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The successor_AbstractAction property
        /// </summary>
        IAbstractAction Successor_AbstractAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceDemandingBehaviour_AbstractAction property
        /// </summary>
        IResourceDemandingBehaviour ResourceDemandingBehaviour_AbstractAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Predecessor_AbstractAction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Predecessor_AbstractActionChanging;
        
        /// <summary>
        /// Gets fired when the Predecessor_AbstractAction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Predecessor_AbstractActionChanged;
        
        /// <summary>
        /// Gets fired before the Successor_AbstractAction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Successor_AbstractActionChanging;
        
        /// <summary>
        /// Gets fired when the Successor_AbstractAction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Successor_AbstractActionChanged;
        
        /// <summary>
        /// Gets fired before the ResourceDemandingBehaviour_AbstractAction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResourceDemandingBehaviour_AbstractActionChanging;
        
        /// <summary>
        /// Gets fired when the ResourceDemandingBehaviour_AbstractAction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ResourceDemandingBehaviour_AbstractActionChanged;
    }
}

