//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core;
using DeepPCM.Deeppcm.Core.Composition;
using DeepPCM.Deeppcm.Qosannotations;
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

namespace DeepPCM.Deeppcm.Qosannotations.Qos_performance
{
    
    
    /// <summary>
    /// The public interface for SpecifiedExecutionTime
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SpecifiedExecutionTime))]
    [XmlDefaultImplementationTypeAttribute(typeof(SpecifiedExecutionTime))]
    public interface ISpecifiedExecutionTime : IModelElement, ISpecifiedQoSAnnotation
    {
        
        /// <summary>
        /// The specification_SpecifiedExecutionTime property
        /// </summary>
        IPCMRandomVariable Specification_SpecifiedExecutionTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Specification_SpecifiedExecutionTime property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Specification_SpecifiedExecutionTimeChanged;
    }
}

