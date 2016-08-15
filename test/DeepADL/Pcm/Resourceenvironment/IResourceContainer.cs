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
using GeneratedCode.Pcm.Resourcetype;
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

namespace GeneratedCode.Pcm.Resourceenvironment
{
    
    
    /// <summary>
    /// The public interface for ResourceContainer
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ResourceContainer))]
    [XmlDefaultImplementationTypeAttribute(typeof(ResourceContainer))]
    public interface IResourceContainer : IModelElement, IEntity
    {
        
        /// <summary>
        /// The activeResourceSpecifications_ResourceContainer property
        /// </summary>
        ICollectionExpression<IProcessingResourceSpecification> ActiveResourceSpecifications_ResourceContainer
        {
            get;
        }
        
        /// <summary>
        /// The resourceEnvironment_ResourceContainer property
        /// </summary>
        IResourceEnvironment ResourceEnvironment_ResourceContainer
        {
            get;
            set;
        }
        
        /// <summary>
        /// The nestedResourceContainers__ResourceContainer property
        /// </summary>
        ICollectionExpression<IResourceContainer> NestedResourceContainers__ResourceContainer
        {
            get;
        }
        
        /// <summary>
        /// The parentResourceContainer__ResourceContainer property
        /// </summary>
        IResourceContainer ParentResourceContainer__ResourceContainer
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the ResourceEnvironment_ResourceContainer property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ResourceEnvironment_ResourceContainerChanged;
        
        /// <summary>
        /// Gets fired when the ParentResourceContainer__ResourceContainer property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ParentResourceContainer__ResourceContainerChanged;
    }
}

