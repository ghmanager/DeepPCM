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
    /// The public interface for RepositoryComponent
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RepositoryComponent))]
    [XmlDefaultImplementationTypeAttribute(typeof(RepositoryComponent))]
    public interface IRepositoryComponent : IModelElement, IInterfaceProvidingRequiringEntity
    {
        
        /// <summary>
        /// The repository__RepositoryComponent property
        /// </summary>
        IRepository Repository__RepositoryComponent
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Repository__RepositoryComponent property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Repository__RepositoryComponentChanged;
    }
}

