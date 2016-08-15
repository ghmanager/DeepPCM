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
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
using Metamodel.DeepPCM.System0;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.Repo
{
    
    
    /// <summary>
    /// The default implementation of the ExampleChannel class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/EventRepo")]
    [XmlNamespacePrefixAttribute("repo")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/EventRepo#//ExampleChannel/")]
    [DebuggerDisplayAttribute("ExampleChannel {Name}")]
    public class ExampleChannel : EventChannelArchitecture, IExampleChannel, IModelElement
    {
        
        private static IClass _classInstance;
        
        /// <summary>
        /// Gets the EventChannel model for this type
        /// </summary>
        public new static IEventChannel EventChannelInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/EventRepo#//ExampleChannel/")));
                }
                return ((IEventChannel)(_classInstance));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/EventRepo#//ExampleChannel/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets the EventChannel for this model element
        /// </summary>
        public override IEventChannel GetEventChannel()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/EventRepo#//ExampleChannel/")));
            }
            return ((IEventChannel)(_classInstance));
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/EventRepo#//ExampleChannel/")));
            }
            return _classInstance;
        }
    }
}
