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
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
using Metamodel.DeepPCM.Seff;
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

namespace Metamodel.DeepPCM.Seff.Seff_performance
{
    
    
    /// <summary>
    /// The public interface for ParametricResourceDemand
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ParametricResourceDemand))]
    [XmlDefaultImplementationTypeAttribute(typeof(ParametricResourceDemand))]
    public interface IParametricResourceDemand : IModelElement
    {
        
        /// <summary>
        /// The specification_ParametericResourceDemand property
        /// </summary>
        IPCMRandomVariable Specification_ParametericResourceDemand
        {
            get;
            set;
        }
        
        /// <summary>
        /// The requiredResource_ParametricResourceDemand property
        /// </summary>
        IProcessingResourceType RequiredResource_ParametricResourceDemand
        {
            get;
            set;
        }
        
        /// <summary>
        /// The action_ParametricResourceDemand property
        /// </summary>
        IAbstractInternalControlFlowAction Action_ParametricResourceDemand
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Specification_ParametericResourceDemand property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Specification_ParametericResourceDemandChanging;
        
        /// <summary>
        /// Gets fired when the Specification_ParametericResourceDemand property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Specification_ParametericResourceDemandChanged;
        
        /// <summary>
        /// Gets fired before the RequiredResource_ParametricResourceDemand property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequiredResource_ParametricResourceDemandChanging;
        
        /// <summary>
        /// Gets fired when the RequiredResource_ParametricResourceDemand property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RequiredResource_ParametricResourceDemandChanged;
        
        /// <summary>
        /// Gets fired before the Action_ParametricResourceDemand property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Action_ParametricResourceDemandChanging;
        
        /// <summary>
        /// Gets fired when the Action_ParametricResourceDemand property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Action_ParametricResourceDemandChanged;
    }
}

