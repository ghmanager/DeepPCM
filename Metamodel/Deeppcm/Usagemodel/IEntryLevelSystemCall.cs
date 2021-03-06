//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core;
using DeepPCM.Deeppcm.Core.Composition;
using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
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

namespace DeepPCM.Deeppcm.Usagemodel
{
    
    
    /// <summary>
    /// The public interface for EntryLevelSystemCall
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EntryLevelSystemCall))]
    [XmlDefaultImplementationTypeAttribute(typeof(EntryLevelSystemCall))]
    public interface IEntryLevelSystemCall : IModelElement, IAbstractUserAction
    {
        
        /// <summary>
        /// The priority property
        /// </summary>
        Nullable<int> Priority
        {
            get;
            set;
        }
        
        /// <summary>
        /// The providedInterface_EntryLevelSystemCall property
        /// </summary>
        IOperationInterface ProvidedInterface_EntryLevelSystemCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The operationSignature__EntryLevelSystemCall property
        /// </summary>
        IOperationSignature OperationSignature__EntryLevelSystemCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outputParameterUsages_EntryLevelSystemCall property
        /// </summary>
        ICollectionExpression<IVariableUsage> OutputParameterUsages_EntryLevelSystemCall
        {
            get;
        }
        
        /// <summary>
        /// The inputParameterUsages_EntryLevelSystemCall property
        /// </summary>
        ICollectionExpression<IVariableUsage> InputParameterUsages_EntryLevelSystemCall
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the Priority property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> PriorityChanged;
        
        /// <summary>
        /// Gets fired when the ProvidedInterface_EntryLevelSystemCall property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ProvidedInterface_EntryLevelSystemCallChanged;
        
        /// <summary>
        /// Gets fired when the OperationSignature__EntryLevelSystemCall property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OperationSignature__EntryLevelSystemCallChanged;
    }
}

