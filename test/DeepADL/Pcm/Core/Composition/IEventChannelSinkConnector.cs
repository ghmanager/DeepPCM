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

namespace GeneratedCode.Pcm.Core.Composition
{
    
    
    /// <summary>
    /// The public interface for EventChannelSinkConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EventChannelSinkConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(EventChannelSinkConnector))]
    public interface IEventChannelSinkConnector : IModelElement, IConnector
    {
        
        /// <summary>
        /// The sinkRole__EventChannelSinkConnector property
        /// </summary>
        ISinkRole SinkRole__EventChannelSinkConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The filterCondition__EventChannelSinkConnector property
        /// </summary>
        IPCMRandomVariable FilterCondition__EventChannelSinkConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The assemblyContext__EventChannelSinkConnector property
        /// </summary>
        IAssemblyContext AssemblyContext__EventChannelSinkConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eventChannel__EventChannelSinkConnector property
        /// </summary>
        IEventChannel EventChannel__EventChannelSinkConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the SinkRole__EventChannelSinkConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> SinkRole__EventChannelSinkConnectorChanged;
        
        /// <summary>
        /// Gets fired when the FilterCondition__EventChannelSinkConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> FilterCondition__EventChannelSinkConnectorChanged;
        
        /// <summary>
        /// Gets fired when the AssemblyContext__EventChannelSinkConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AssemblyContext__EventChannelSinkConnectorChanged;
        
        /// <summary>
        /// Gets fired when the EventChannel__EventChannelSinkConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> EventChannel__EventChannelSinkConnectorChanged;
    }
}

