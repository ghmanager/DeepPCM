//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Composition;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Repository;
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

namespace GeneratedCode.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The public interface for BranchTransition
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BranchTransition))]
    [XmlDefaultImplementationTypeAttribute(typeof(BranchTransition))]
    public interface IBranchTransition : IModelElement
    {
        
        /// <summary>
        /// The branchProbability property
        /// </summary>
        double BranchProbability
        {
            get;
            set;
        }
        
        /// <summary>
        /// The branch_BranchTransition property
        /// </summary>
        IBranch Branch_BranchTransition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The branchedBehaviour_BranchTransition property
        /// </summary>
        IScenarioBehaviour BranchedBehaviour_BranchTransition
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the BranchProbability property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> BranchProbabilityChanged;
        
        /// <summary>
        /// Gets fired when the Branch_BranchTransition property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Branch_BranchTransitionChanged;
        
        /// <summary>
        /// Gets fired when the BranchedBehaviour_BranchTransition property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> BranchedBehaviour_BranchTransitionChanged;
    }
}

