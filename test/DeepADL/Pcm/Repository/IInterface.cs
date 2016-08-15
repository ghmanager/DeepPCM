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
using GeneratedCode.Pcm.Protocol;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Resourcetype;
using GeneratedCode.Pcm.Seff;
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

namespace GeneratedCode.Pcm.Repository
{
    
    
    /// <summary>
    /// The public interface for Interface
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Interface))]
    [XmlDefaultImplementationTypeAttribute(typeof(Interface))]
    public interface IInterface : IModelElement, IEntity
    {
        
        /// <summary>
        /// The parentInterfaces__Interface property
        /// </summary>
        ICollectionExpression<IInterface> ParentInterfaces__Interface
        {
            get;
        }
        
        /// <summary>
        /// The protocols__Interface property
        /// </summary>
        ICollectionExpression<IProtocol> Protocols__Interface
        {
            get;
        }
        
        /// <summary>
        /// The requiredCharacterisations property
        /// </summary>
        ICollectionExpression<IRequiredCharacterisation> RequiredCharacterisations
        {
            get;
        }
        
        /// <summary>
        /// The repository__Interface property
        /// </summary>
        IRepository Repository__Interface
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Repository__Interface property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Repository__InterfaceChanged;
    }
}
