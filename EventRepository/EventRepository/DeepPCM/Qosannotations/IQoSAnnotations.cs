//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.System0;
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

namespace Metamodel.DeepPCM.Qosannotations
{
    
    
    /// <summary>
    /// The public interface for QoSAnnotations
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(QoSAnnotations))]
    [XmlDefaultImplementationTypeAttribute(typeof(QoSAnnotations))]
    public interface IQoSAnnotations : IModelElement, IEntity
    {
        
        /// <summary>
        /// The specifiedOutputParameterAbstractions_QoSAnnotations property
        /// </summary>
        ICollectionExpression<ISpecifiedOutputParameterAbstraction> SpecifiedOutputParameterAbstractions_QoSAnnotations
        {
            get;
        }
        
        /// <summary>
        /// The system_QoSAnnotations property
        /// </summary>
        ISystemSpecification System_QoSAnnotations
        {
            get;
            set;
        }
        
        /// <summary>
        /// The specifiedQoSAnnotations_QoSAnnotations property
        /// </summary>
        ICollectionExpression<ISpecifiedQoSAnnotation> SpecifiedQoSAnnotations_QoSAnnotations
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the System_QoSAnnotations property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> System_QoSAnnotationsChanging;
        
        /// <summary>
        /// Gets fired when the System_QoSAnnotations property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> System_QoSAnnotationsChanged;
    }
}

