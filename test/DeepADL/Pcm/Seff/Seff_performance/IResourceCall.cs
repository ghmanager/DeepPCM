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
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Resourcetype;
using GeneratedCode.Pcm.Seff;
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

namespace GeneratedCode.Pcm.Seff.Seff_performance
{
    
    
    /// <summary>
    /// The public interface for ResourceCall
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ResourceCall))]
    [XmlDefaultImplementationTypeAttribute(typeof(ResourceCall))]
    public interface IResourceCall : IModelElement, ICallAction
    {
        
        /// <summary>
        /// The action__ResourceCall property
        /// </summary>
        IAbstractInternalControlFlowAction Action__ResourceCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The resourceRequiredRole__ResourceCall property
        /// </summary>
        IResourceRequiredRole ResourceRequiredRole__ResourceCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The signature__ResourceCall property
        /// </summary>
        IResourceSignature Signature__ResourceCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The numberOfCalls__ResourceCall property
        /// </summary>
        IPCMRandomVariable NumberOfCalls__ResourceCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Action__ResourceCall property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Action__ResourceCallChanged;
        
        /// <summary>
        /// Gets fired when the ResourceRequiredRole__ResourceCall property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ResourceRequiredRole__ResourceCallChanged;
        
        /// <summary>
        /// Gets fired when the Signature__ResourceCall property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Signature__ResourceCallChanged;
        
        /// <summary>
        /// Gets fired when the NumberOfCalls__ResourceCall property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> NumberOfCalls__ResourceCallChanged;
    }
}
