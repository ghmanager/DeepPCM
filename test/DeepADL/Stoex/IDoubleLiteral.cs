//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Probfunction;
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

namespace GeneratedCode.Stoex
{
    
    
    /// <summary>
    /// The public interface for DoubleLiteral
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DoubleLiteral))]
    [XmlDefaultImplementationTypeAttribute(typeof(DoubleLiteral))]
    public interface IDoubleLiteral : IModelElement, INumericLiteral
    {
        
        /// <summary>
        /// The value property
        /// </summary>
        double Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ValueChanged;
    }
}

