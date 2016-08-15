//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Seff;
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

namespace DeepPCM.Deeppcm.Seff.Seff_reliability
{
    
    
    /// <summary>
    /// The public interface for RecoveryAction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RecoveryAction))]
    [XmlDefaultImplementationTypeAttribute(typeof(RecoveryAction))]
    public interface IRecoveryAction : IModelElement, IAbstractInternalControlFlowAction
    {
        
        /// <summary>
        /// The primaryBehaviour__RecoveryAction property
        /// </summary>
        IRecoveryActionBehaviour PrimaryBehaviour__RecoveryAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The recoveryActionBehaviours__RecoveryAction property
        /// </summary>
        ICollectionExpression<IRecoveryActionBehaviour> RecoveryActionBehaviours__RecoveryAction
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the PrimaryBehaviour__RecoveryAction property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> PrimaryBehaviour__RecoveryActionChanged;
    }
}
