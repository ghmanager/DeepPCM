//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Identifier;
using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Seff.Seff_performance;
using GeneratedCode.Pcm.Seff.Seff_reliability;
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

namespace GeneratedCode.Pcm.Seff
{
    
    
    /// <summary>
    /// The public interface for AbstractAction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AbstractAction))]
    [XmlDefaultImplementationTypeAttribute(typeof(AbstractAction))]
    public interface IAbstractAction : IModelElement, IEntity
    {
        
        /// <summary>
        /// The predecessor_AbstractAction property
        /// </summary>
        IAbstractAction Predecessor_AbstractAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The successor_AbstractAction property
        /// </summary>
        IAbstractAction Successor_AbstractAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceDemandingBehaviour_AbstractAction property
        /// </summary>
        IResourceDemandingBehaviour ResourceDemandingBehaviour_AbstractAction
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Predecessor_AbstractAction property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Predecessor_AbstractActionChanged;
        
        /// <summary>
        /// Gets fired when the Successor_AbstractAction property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Successor_AbstractActionChanged;
        
        /// <summary>
        /// Gets fired when the ResourceDemandingBehaviour_AbstractAction property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ResourceDemandingBehaviour_AbstractActionChanged;
    }
}

