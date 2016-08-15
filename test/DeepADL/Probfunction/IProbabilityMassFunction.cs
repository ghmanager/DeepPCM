//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Units;
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

namespace GeneratedCode.Probfunction
{
    
    
    /// <summary>
    /// The public interface for ProbabilityMassFunction
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ProbabilityMassFunction))]
    [XmlDefaultImplementationTypeAttribute(typeof(ProbabilityMassFunction))]
    public interface IProbabilityMassFunction : IModelElement, IProbabilityFunction
    {
        
        /// <summary>
        /// The orderedDomain property
        /// </summary>
        bool OrderedDomain
        {
            get;
            set;
        }
        
        /// <summary>
        /// The samples property
        /// </summary>
        IListExpression<ISample> Samples
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the OrderedDomain property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> OrderedDomainChanged;
    }
}

