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
    /// The public interface for InternalFailureOccurrenceDescription
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(InternalFailureOccurrenceDescription))]
    [XmlDefaultImplementationTypeAttribute(typeof(InternalFailureOccurrenceDescription))]
    public interface IInternalFailureOccurrenceDescription : IModelElement, IFailureOccurrenceDescription
    {
        
        /// <summary>
        /// The internalAction__InternalFailureOccurrenceDescription property
        /// </summary>
        IInternalAction InternalAction__InternalFailureOccurrenceDescription
        {
            get;
            set;
        }
        
        /// <summary>
        /// The softwareInducedFailureType__InternalFailureOccurrenceDescription property
        /// </summary>
        ISoftwareInducedFailureType SoftwareInducedFailureType__InternalFailureOccurrenceDescription
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the InternalAction__InternalFailureOccurrenceDescription property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InternalAction__InternalFailureOccurrenceDescriptionChanged;
        
        /// <summary>
        /// Gets fired when the SoftwareInducedFailureType__InternalFailureOccurrenceDescription property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> SoftwareInducedFailureType__InternalFailureOccurrenceDescriptionChanged;
    }
}

