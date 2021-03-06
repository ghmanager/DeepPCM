//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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

namespace Metamodel.Probfunction
{
    
    
    /// <summary>
    /// The default implementation of the ExponentialDistribution class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0")]
    [XmlNamespacePrefixAttribute("probfunction")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0#//ExponentialDistribution/")]
    public class ExponentialDistribution : ContinuousPDF, IExponentialDistribution, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Rate property
        /// </summary>
        private double _rate;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The rate property
        /// </summary>
        [XmlElementNameAttribute("rate")]
        [XmlAttributeAttribute(true)]
        public virtual double Rate
        {
            get
            {
                return this._rate;
            }
            set
            {
                if ((this._rate != value))
                {
                    double old = this._rate;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRateChanging(e);
                    this.OnPropertyChanging("Rate", e);
                    this._rate = value;
                    this.OnRateChanged(e);
                    this.OnPropertyChanged("Rate", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//ExponentialDistribution/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Rate property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RateChanging;
        
        /// <summary>
        /// Gets fired when the Rate property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RateChanged;
        
        /// <summary>
        /// Raises the RateChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRateChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RateChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RateChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRateChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RateChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "RATE"))
            {
                return this.Rate;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "RATE"))
            {
                this.Rate = ((double)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//ExponentialDistribution/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the rate property
        /// </summary>
        private sealed class RateProxy : ModelPropertyChange<IExponentialDistribution, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RateProxy(IExponentialDistribution modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override double Value
            {
                get
                {
                    return this.ModelElement.Rate;
                }
                set
                {
                    this.ModelElement.Rate = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RateChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RateChanged -= handler;
            }
        }
    }
}

