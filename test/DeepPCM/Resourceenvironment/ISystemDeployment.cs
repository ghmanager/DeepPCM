//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core;
using Metamodel.DeepPCM.Core.Entity;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Resourceenvironment
{
    
    
    /// <summary>
    /// The public interface for SystemDeployment
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SystemDeployment))]
    [XmlDefaultImplementationTypeAttribute(typeof(SystemDeployment))]
    public interface ISystemDeployment : IModelElement, IClass
    {
        
        /// <summary>
        /// The Environment property
        /// </summary>
        IResourceEnvironment Environment
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Environment property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnvironmentChanging;
        
        /// <summary>
        /// Gets fired when the Environment property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> EnvironmentChanged;
    }
}
