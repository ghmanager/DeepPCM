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
    /// The public interface for EventType
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EventType))]
    [XmlDefaultImplementationTypeAttribute(typeof(EventType))]
    public interface IEventType : IModelElement, ISignature
    {
        
        /// <summary>
        /// The parameter__EventType property
        /// </summary>
        IParameter Parameter__EventType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eventGroup__EventType property
        /// </summary>
        IEventGroup EventGroup__EventType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Parameter__EventType property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Parameter__EventTypeChanged;
        
        /// <summary>
        /// Gets fired when the EventGroup__EventType property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> EventGroup__EventTypeChanged;
    }
}
