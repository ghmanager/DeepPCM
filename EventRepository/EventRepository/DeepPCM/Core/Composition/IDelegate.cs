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
    /// The public interface for Delegate
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Delegate))]
    [XmlDefaultImplementationTypeAttribute(typeof(Delegate))]
    public interface IDelegate : IModelElement, IClass
    {
        
        /// <summary>
        /// The repository__Delegate property
        /// </summary>
        IRepository Repository__Delegate
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Type property
        /// </summary>
        IInterface Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Repository__Delegate property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Repository__DelegateChanging;
        
        /// <summary>
        /// Gets fired when the Repository__Delegate property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Repository__DelegateChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TypeChanged;
    }
}

