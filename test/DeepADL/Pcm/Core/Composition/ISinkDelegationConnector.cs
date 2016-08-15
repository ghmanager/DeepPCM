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
    /// The public interface for SinkDelegationConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SinkDelegationConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(SinkDelegationConnector))]
    public interface ISinkDelegationConnector : IModelElement, IDelegationConnector
    {
        
        /// <summary>
        /// The assemblyContext__SinkDelegationConnector property
        /// </summary>
        IAssemblyContext AssemblyContext__SinkDelegationConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The innerSinkRole__SinkRole property
        /// </summary>
        ISinkRole InnerSinkRole__SinkRole
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outerSinkRole__SinkRole property
        /// </summary>
        ISinkRole OuterSinkRole__SinkRole
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the AssemblyContext__SinkDelegationConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> AssemblyContext__SinkDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the InnerSinkRole__SinkRole property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InnerSinkRole__SinkRoleChanged;
        
        /// <summary>
        /// Gets fired when the OuterSinkRole__SinkRole property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OuterSinkRole__SinkRoleChanged;
    }
}

