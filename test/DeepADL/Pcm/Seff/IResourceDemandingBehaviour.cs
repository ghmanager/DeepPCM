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
using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Seff.Seff_performance;
using GeneratedCode.Pcm.Seff.Seff_reliability;
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

namespace GeneratedCode.Pcm.Seff
{
    
    
    /// <summary>
    /// The public interface for ResourceDemandingBehaviour
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ResourceDemandingBehaviour))]
    [XmlDefaultImplementationTypeAttribute(typeof(ResourceDemandingBehaviour))]
    public interface IResourceDemandingBehaviour : IModelElement, IIdentifier
    {
        
        /// <summary>
        /// The abstractLoopAction_ResourceDemandingBehaviour property
        /// </summary>
        IAbstractLoopAction AbstractLoopAction_ResourceDemandingBehaviour
        {
            get;
            set;
        }
        
        /// <summary>
        /// The abstractBranchTransition_ResourceDemandingBehaviour property
        /// </summary>
        IAbstractBranchTransition AbstractBranchTransition_ResourceDemandingBehaviour
        {
            get;
            set;
        }
        
        /// <summary>
        /// The steps_Behaviour property
        /// </summary>
        ICollectionExpression<IAbstractAction> Steps_Behaviour
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the AbstractLoopAction_ResourceDemandingBehaviour property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AbstractLoopAction_ResourceDemandingBehaviourChanged;
        
        /// <summary>
        /// Gets fired when the AbstractBranchTransition_ResourceDemandingBehaviour property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AbstractBranchTransition_ResourceDemandingBehaviourChanged;
    }
}
