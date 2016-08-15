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
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Identifier;
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

namespace DeepPCM.Deeppcm.Core.Composition
{
    
    
    /// <summary>
    /// The public interface for OperationDelegationConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OperationDelegationConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(OperationDelegationConnector))]
    public interface IOperationDelegationConnector : IModelElement, IDelegationConnector
    {
        
        /// <summary>
        /// The OperationPort property
        /// </summary>
        IRequiredOperationInterface OperationPort
        {
            get;
            set;
        }
        
        /// <summary>
        /// The OperationType property
        /// </summary>
        IOperationInterface OperationType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the OperationPort property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OperationPortChanged;
        
        /// <summary>
        /// Gets fired when the OperationType property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OperationTypeChanged;
    }
}
