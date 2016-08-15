//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Identifier;
using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Seff.Seff_performance;
using GeneratedCode.Pcm.Seff.Seff_reliability;
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

namespace GeneratedCode.Pcm.Seff
{
    
    
    /// <summary>
    /// The public interface for ServiceEffectSpecification
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ServiceEffectSpecification))]
    [XmlDefaultImplementationTypeAttribute(typeof(ServiceEffectSpecification))]
    public interface IServiceEffectSpecification : IModelElement
    {
        
        /// <summary>
        /// The seffTypeID property
        /// </summary>
        string SeffTypeID
        {
            get;
            set;
        }
        
        /// <summary>
        /// The describedService__SEFF property
        /// </summary>
        ISignature DescribedService__SEFF
        {
            get;
            set;
        }
        
        /// <summary>
        /// The basicComponent_ServiceEffectSpecification property
        /// </summary>
        IBasicComponent BasicComponent_ServiceEffectSpecification
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the SeffTypeID property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> SeffTypeIDChanged;
        
        /// <summary>
        /// Gets fired when the DescribedService__SEFF property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> DescribedService__SEFFChanged;
        
        /// <summary>
        /// Gets fired when the BasicComponent_ServiceEffectSpecification property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> BasicComponent_ServiceEffectSpecificationChanged;
    }
}

