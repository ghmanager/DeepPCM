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
    /// The public interface for RequiredInfrastructureDelegationConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(RequiredInfrastructureDelegationConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(RequiredInfrastructureDelegationConnector))]
    public interface IRequiredInfrastructureDelegationConnector : IModelElement, IDelegationConnector
    {
        
        /// <summary>
        /// The innerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        IInfrastructureRequiredRole InnerRequiredRole__RequiredInfrastructureDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outerRequiredRole__RequiredInfrastructureDelegationConnector property
        /// </summary>
        IInfrastructureRequiredRole OuterRequiredRole__RequiredInfrastructureDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The assemblyContext__RequiredInfrastructureDelegationConnector property
        /// </summary>
        IAssemblyContext AssemblyContext__RequiredInfrastructureDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the InnerRequiredRole__RequiredInfrastructureDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InnerRequiredRole__RequiredInfrastructureDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the OuterRequiredRole__RequiredInfrastructureDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OuterRequiredRole__RequiredInfrastructureDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the AssemblyContext__RequiredInfrastructureDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AssemblyContext__RequiredInfrastructureDelegationConnectorChanged;
    }
}
