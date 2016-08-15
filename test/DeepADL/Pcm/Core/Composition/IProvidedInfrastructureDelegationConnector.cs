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
    /// The public interface for ProvidedInfrastructureDelegationConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ProvidedInfrastructureDelegationConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(ProvidedInfrastructureDelegationConnector))]
    public interface IProvidedInfrastructureDelegationConnector : IModelElement, IDelegationConnector
    {
        
        /// <summary>
        /// The innerProvidedRole__ProvidedInfrastructureDelegationConnector property
        /// </summary>
        IInfrastructureProvidedRole InnerProvidedRole__ProvidedInfrastructureDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outerProvidedRole__ProvidedInfrastructureDelegationConnector property
        /// </summary>
        IInfrastructureProvidedRole OuterProvidedRole__ProvidedInfrastructureDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The assemblyContext__ProvidedInfrastructureDelegationConnector property
        /// </summary>
        IAssemblyContext AssemblyContext__ProvidedInfrastructureDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the InnerProvidedRole__ProvidedInfrastructureDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InnerProvidedRole__ProvidedInfrastructureDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the OuterProvidedRole__ProvidedInfrastructureDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OuterProvidedRole__ProvidedInfrastructureDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the AssemblyContext__ProvidedInfrastructureDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AssemblyContext__ProvidedInfrastructureDelegationConnectorChanged;
    }
}

