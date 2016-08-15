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
    /// The public interface for ReleaseAction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ReleaseAction))]
    [XmlDefaultImplementationTypeAttribute(typeof(ReleaseAction))]
    public interface IReleaseAction : IModelElement, IAbstractInternalControlFlowAction
    {
        
        /// <summary>
        /// The passiveResource_ReleaseAction property
        /// </summary>
        IPassiveResource PassiveResource_ReleaseAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the PassiveResource_ReleaseAction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PassiveResource_ReleaseActionChanging;
        
        /// <summary>
        /// Gets fired when the PassiveResource_ReleaseAction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PassiveResource_ReleaseActionChanged;
    }
}
