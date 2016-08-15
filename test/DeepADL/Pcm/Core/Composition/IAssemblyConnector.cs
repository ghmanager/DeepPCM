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
    /// The public interface for AssemblyConnector
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(AssemblyConnector))]
    [XmlDefaultImplementationTypeAttribute(typeof(AssemblyConnector))]
    public interface IAssemblyConnector : IModelElement, IConnector
    {
        
        /// <summary>
        /// The requiringAssemblyContext_AssemblyConnector property
        /// </summary>
        IAssemblyContext RequiringAssemblyContext_AssemblyConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The providingAssemblyContext_AssemblyConnector property
        /// </summary>
        IAssemblyContext ProvidingAssemblyContext_AssemblyConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The providedRole_AssemblyConnector property
        /// </summary>
        IOperationProvidedRole ProvidedRole_AssemblyConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// The requiredRole_AssemblyConnector property
        /// </summary>
        IOperationRequiredRole RequiredRole_AssemblyConnector
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the RequiringAssemblyContext_AssemblyConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> RequiringAssemblyContext_AssemblyConnectorChanged;
        
        /// <summary>
        /// Gets fired when the ProvidingAssemblyContext_AssemblyConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ProvidingAssemblyContext_AssemblyConnectorChanged;
        
        /// <summary>
        /// Gets fired when the ProvidedRole_AssemblyConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ProvidedRole_AssemblyConnectorChanged;
        
        /// <summary>
        /// Gets fired when the RequiredRole_AssemblyConnector property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> RequiredRole_AssemblyConnectorChanged;
    }
}
