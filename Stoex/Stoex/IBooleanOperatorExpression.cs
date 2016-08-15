//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.Probfunction;
using Metamodel.Units;
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

namespace Metamodel.Stoex
{
    
    
    /// <summary>
    /// The public interface for BooleanOperatorExpression
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BooleanOperatorExpression))]
    [XmlDefaultImplementationTypeAttribute(typeof(BooleanOperatorExpression))]
    public interface IBooleanOperatorExpression : IModelElement, IBooleanExpression
    {
        
        /// <summary>
        /// The operation property
        /// </summary>
        BooleanOperations Operation
        {
            get;
            set;
        }
        
        /// <summary>
        /// The left property
        /// </summary>
        IBooleanExpression Left
        {
            get;
            set;
        }
        
        /// <summary>
        /// The right property
        /// </summary>
        IBooleanExpression Right
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Operation property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OperationChanging;
        
        /// <summary>
        /// Gets fired when the Operation property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OperationChanged;
        
        /// <summary>
        /// Gets fired before the Left property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeftChanging;
        
        /// <summary>
        /// Gets fired when the Left property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> LeftChanged;
        
        /// <summary>
        /// Gets fired before the Right property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RightChanging;
        
        /// <summary>
        /// Gets fired when the Right property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> RightChanged;
    }
}
