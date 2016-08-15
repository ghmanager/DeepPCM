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
using DeepPCM.Deeppcm.Qosannotations.Qos_reliability;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.Resourcetype;
using DeepPCM.Deeppcm.Seff;
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

namespace DeepPCM.Deeppcm.Reliability
{
    
    
    /// <summary>
    /// The public interface for ExternalFailureOccurrenceDescription
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ExternalFailureOccurrenceDescription))]
    [XmlDefaultImplementationTypeAttribute(typeof(ExternalFailureOccurrenceDescription))]
    public interface IExternalFailureOccurrenceDescription : IModelElement, IFailureOccurrenceDescription
    {
        
        /// <summary>
        /// The specifiedReliabilityAnnotation__ExternalFailureOccurrenceDescription property
        /// </summary>
        ISpecifiedReliabilityAnnotation SpecifiedReliabilityAnnotation__ExternalFailureOccurrenceDescription
        {
            get;
            set;
        }
        
        /// <summary>
        /// The failureType__ExternalFailureOccurrenceDescription property
        /// </summary>
        IFailureType FailureType__ExternalFailureOccurrenceDescription
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the SpecifiedReliabilityAnnotation__ExternalFailureOccurrenceDescription property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> SpecifiedReliabilityAnnotation__ExternalFailureOccurrenceDescriptionChanged;
        
        /// <summary>
        /// Gets fired when the FailureType__ExternalFailureOccurrenceDescription property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> FailureType__ExternalFailureOccurrenceDescriptionChanged;
    }
}
