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
    /// The public interface for AbstractBranchTransition
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AbstractBranchTransition))]
    [XmlDefaultImplementationTypeAttribute(typeof(AbstractBranchTransition))]
    public interface IAbstractBranchTransition : IModelElement, IEntity
    {
        
        /// <summary>
        /// The branchAction_AbstractBranchTransition property
        /// </summary>
        IBranchAction BranchAction_AbstractBranchTransition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The branchBehaviour_BranchTransition property
        /// </summary>
        IResourceDemandingBehaviour BranchBehaviour_BranchTransition
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the BranchAction_AbstractBranchTransition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BranchAction_AbstractBranchTransitionChanging;
        
        /// <summary>
        /// Gets fired when the BranchAction_AbstractBranchTransition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BranchAction_AbstractBranchTransitionChanged;
        
        /// <summary>
        /// Gets fired before the BranchBehaviour_BranchTransition property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BranchBehaviour_BranchTransitionChanging;
        
        /// <summary>
        /// Gets fired when the BranchBehaviour_BranchTransition property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> BranchBehaviour_BranchTransitionChanged;
    }
}

