//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Composition;
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

namespace Metamodel.DeepPCM.Core.Entity
{
    
    
    /// <summary>
    /// The public interface for InterfaceProvidingEntity
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(InterfaceProvidingEntity))]
    [XmlDefaultImplementationTypeAttribute(typeof(InterfaceProvidingEntity))]
    public interface IInterfaceProvidingEntity : IModelElement, IEntity, IClass
    {
        
        /// <summary>
        /// The ProvidedInterfaces property
        /// </summary>
        ICollectionExpression<IInterface> ProvidedInterfaces
        {
            get;
        }
    }
}

