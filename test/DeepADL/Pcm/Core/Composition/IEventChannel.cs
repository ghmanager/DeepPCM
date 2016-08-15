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
    /// The public interface for EventChannel
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EventChannel))]
    [XmlDefaultImplementationTypeAttribute(typeof(EventChannel))]
    public interface IEventChannel : IModelElement, IEntity
    {
        
        /// <summary>
        /// The eventGroup__EventChannel property
        /// </summary>
        IEventGroup EventGroup__EventChannel
        {
            get;
            set;
        }
        
        /// <summary>
        /// The eventChannelSourceConnector__EventChannel property
        /// </summary>
        ICollectionExpression<IEventChannelSourceConnector> EventChannelSourceConnector__EventChannel
        {
            get;
        }
        
        /// <summary>
        /// The eventChannelSinkConnector__EventChannel property
        /// </summary>
        ICollectionExpression<IEventChannelSinkConnector> EventChannelSinkConnector__EventChannel
        {
            get;
        }
        
        /// <summary>
        /// The parentStructure__EventChannel property
        /// </summary>
        IComposedStructure ParentStructure__EventChannel
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the EventGroup__EventChannel property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> EventGroup__EventChannelChanged;
        
        /// <summary>
        /// Gets fired when the ParentStructure__EventChannel property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ParentStructure__EventChannelChanged;
    }
}
