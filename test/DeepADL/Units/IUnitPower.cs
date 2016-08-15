//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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

namespace GeneratedCode.Units
{
    
    
    /// <summary>
    /// The public interface for UnitPower
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(UnitPower))]
    [XmlDefaultImplementationTypeAttribute(typeof(UnitPower))]
    public interface IUnitPower : IModelElement, IUnit
    {
        
        /// <summary>
        /// The exponent property
        /// </summary>
        int Exponent
        {
            get;
            set;
        }
        
        /// <summary>
        /// The unit property
        /// </summary>
        IUnit Unit
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Exponent property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ExponentChanged;
        
        /// <summary>
        /// Gets fired when the Unit property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> UnitChanged;
    }
}
