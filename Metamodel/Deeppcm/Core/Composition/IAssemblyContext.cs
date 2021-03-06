//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
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

namespace DeepPCM.Deeppcm.Core.Composition
{
    
    
    /// <summary>
    /// The public interface for AssemblyContext
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AssemblyContext))]
    [XmlDefaultImplementationTypeAttribute(typeof(AssemblyContext))]
    public interface IAssemblyContext : IModelElement, IEntity, IReference
    {
        
        /// <summary>
        /// The composedStructure__AssemblyContext property
        /// </summary>
        IComposedStructure ComposedStructure__AssemblyContext
        {
            get;
            set;
        }
        
        /// <summary>
        /// The configParameterUsages__AssemblyContext property
        /// </summary>
        ICollectionExpression<IVariableUsage> ConfigParameterUsages__AssemblyContext
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the ComposedStructure__AssemblyContext property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ComposedStructure__AssemblyContextChanged;
        
        /// <summary>
        /// Gets the RepositoryComponent for this model element
        /// </summary>
        IRepositoryComponent GetRepositoryComponent();
    }
}

