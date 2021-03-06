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
    /// The public interface for SpecifiedOutputParameterAbstraction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SpecifiedOutputParameterAbstraction))]
    [XmlDefaultImplementationTypeAttribute(typeof(SpecifiedOutputParameterAbstraction))]
    public interface ISpecifiedOutputParameterAbstraction : IModelElement
    {
        
        /// <summary>
        /// The signature_SpecifiedOutputParameterAbstraction property
        /// </summary>
        ISignature Signature_SpecifiedOutputParameterAbstraction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The role_SpecifiedOutputParameterAbstraction property
        /// </summary>
        IRole Role_SpecifiedOutputParameterAbstraction
        {
            get;
            set;
        }
        
        /// <summary>
        /// The expectedExternalOutputs_SpecifiedOutputParameterAbstraction property
        /// </summary>
        ICollectionExpression<IVariableUsage> ExpectedExternalOutputs_SpecifiedOutputParameterAbstraction
        {
            get;
        }
        
        /// <summary>
        /// The qosAnnotations_SpecifiedOutputParameterAbstraction property
        /// </summary>
        IQoSAnnotations QosAnnotations_SpecifiedOutputParameterAbstraction
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Signature_SpecifiedOutputParameterAbstraction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Signature_SpecifiedOutputParameterAbstractionChanging;
        
        /// <summary>
        /// Gets fired when the Signature_SpecifiedOutputParameterAbstraction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Signature_SpecifiedOutputParameterAbstractionChanged;
        
        /// <summary>
        /// Gets fired before the Role_SpecifiedOutputParameterAbstraction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Role_SpecifiedOutputParameterAbstractionChanging;
        
        /// <summary>
        /// Gets fired when the Role_SpecifiedOutputParameterAbstraction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> Role_SpecifiedOutputParameterAbstractionChanged;
        
        /// <summary>
        /// Gets fired before the QosAnnotations_SpecifiedOutputParameterAbstraction property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QosAnnotations_SpecifiedOutputParameterAbstractionChanging;
        
        /// <summary>
        /// Gets fired when the QosAnnotations_SpecifiedOutputParameterAbstraction property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> QosAnnotations_SpecifiedOutputParameterAbstractionChanged;
    }
}

