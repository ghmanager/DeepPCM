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
    /// The default implementation of the ProbabilityDensityFunction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0")]
    [XmlNamespacePrefixAttribute("probfunction")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0#//ProbabilityDensityFunction/")]
    public abstract class ProbabilityDensityFunction : ProbabilityFunction, IProbabilityDensityFunction, IModelElement
    {
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/ProbFunction/1.0#//ProbabilityDensityFunction/");
            }
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//ProbabilityDensityFunction/")));
        }
    }
}

