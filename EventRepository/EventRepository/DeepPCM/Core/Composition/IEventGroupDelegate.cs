//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
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

namespace Metamodel.DeepPCM.Core.Composition
{
    
    
    /// <summary>
    /// The public interface for EventGroupDelegate
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EventGroupDelegate))]
    [XmlDefaultImplementationTypeAttribute(typeof(EventGroupDelegate))]
    public interface IEventGroupDelegate : IModelElement, IDelegate
    {
        
        /// <summary>
        /// The EventGroupType property
        /// </summary>
        Metamodel.DeepPCM.Repository.IEventGroup EventGroupType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the EventGroupType property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EventGroupTypeChanging;
        
        /// <summary>
        /// Gets fired when the EventGroupType property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EventGroupTypeChanged;
    }
}

