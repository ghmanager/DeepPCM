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
    /// The public interface for RequiredOperationInterface
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RequiredOperationInterface))]
    [XmlDefaultImplementationTypeAttribute(typeof(RequiredOperationInterface))]
    public interface IRequiredOperationInterface : IModelElement, IRequiredInterface
    {
        
        /// <summary>
        /// The OperationInterface property
        /// </summary>
        IOperationInterface OperationInterface
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the OperationInterface property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OperationInterfaceChanging;
        
        /// <summary>
        /// Gets fired when the OperationInterface property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OperationInterfaceChanged;
    }
}

