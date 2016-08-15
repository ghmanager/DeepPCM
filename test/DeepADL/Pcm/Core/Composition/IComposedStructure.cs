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
    /// The public interface for ComposedStructure
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ComposedStructure))]
    [XmlDefaultImplementationTypeAttribute(typeof(ComposedStructure))]
    public interface IComposedStructure : IModelElement, IEntity
    {
        
        /// <summary>
        /// The assemblyContexts__ComposedStructure property
        /// </summary>
        ICollectionExpression<IAssemblyContext> AssemblyContexts__ComposedStructure
        {
            get;
        }
        
        /// <summary>
        /// The resourceRequiredDelegationConnectors_ComposedStructure property
        /// </summary>
        ICollectionExpression<IResourceRequiredDelegationConnector> ResourceRequiredDelegationConnectors_ComposedStructure
        {
            get;
        }
        
        /// <summary>
        /// The eventChannel__ComposedStructure property
        /// </summary>
        ICollectionExpression<IEventChannel> EventChannel__ComposedStructure
        {
            get;
        }
        
        /// <summary>
        /// The connectors__ComposedStructure property
        /// </summary>
        ICollectionExpression<IConnector> Connectors__ComposedStructure
        {
            get;
        }
    }
}
