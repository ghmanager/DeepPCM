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
using DeepPCM.Deeppcm.Protocol;
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Resourcetype;
using DeepPCM.Deeppcm.Seff;
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

namespace DeepPCM.Deeppcm.Repository
{
    
    
    /// <summary>
    /// The public interface for Parameter
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Parameter))]
    [XmlDefaultImplementationTypeAttribute(typeof(Parameter))]
    public interface IParameter : IModelElement
    {
        
        /// <summary>
        /// The parameterName property
        /// </summary>
        string ParameterName
        {
            get;
            set;
        }
        
        /// <summary>
        /// The modifier__Parameter property
        /// </summary>
        ParameterModifier Modifier__Parameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The dataType__Parameter property
        /// </summary>
        IDataType DataType__Parameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The infrastructureSignature__Parameter property
        /// </summary>
        IInfrastructureSignature InfrastructureSignature__Parameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The operationSignature__Parameter property
        /// </summary>
        IOperationSignature OperationSignature__Parameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eventType__Parameter property
        /// </summary>
        IEventType EventType__Parameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceSignature__Parameter property
        /// </summary>
        IResourceSignature ResourceSignature__Parameter
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the ParameterName property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ParameterNameChanged;
        
        /// <summary>
        /// Gets fired when the Modifier__Parameter property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Modifier__ParameterChanged;
        
        /// <summary>
        /// Gets fired when the DataType__Parameter property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> DataType__ParameterChanged;
        
        /// <summary>
        /// Gets fired when the InfrastructureSignature__Parameter property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InfrastructureSignature__ParameterChanged;
        
        /// <summary>
        /// Gets fired when the OperationSignature__Parameter property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OperationSignature__ParameterChanged;
        
        /// <summary>
        /// Gets fired when the EventType__Parameter property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> EventType__ParameterChanged;
        
        /// <summary>
        /// Gets fired when the ResourceSignature__Parameter property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ResourceSignature__ParameterChanged;
    }
}

