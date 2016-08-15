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
    /// The default implementation of the Complex class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0")]
    [XmlNamespacePrefixAttribute("probfunction")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0#//Complex/")]
    public class Complex : ModelElement, IComplex, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Real property
        /// </summary>
        private double _real;
        
        /// <summary>
        /// The backing field for the Imaginary property
        /// </summary>
        private double _imaginary;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The real property
        /// </summary>
        [XmlElementNameAttribute("real")]
        [XmlAttributeAttribute(true)]
        public virtual double Real
        {
            get
            {
                return this._real;
            }
            set
            {
                if ((this._real != value))
                {
                    double old = this._real;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRealChanging(e);
                    this.OnPropertyChanging("Real", e);
                    this._real = value;
                    this.OnRealChanged(e);
                    this.OnPropertyChanged("Real", e);
                }
            }
        }
        
        /// <summary>
        /// The imaginary property
        /// </summary>
        [XmlElementNameAttribute("imaginary")]
        [XmlAttributeAttribute(true)]
        public virtual double Imaginary
        {
            get
            {
                return this._imaginary;
            }
            set
            {
                if ((this._imaginary != value))
                {
                    double old = this._imaginary;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnImaginaryChanging(e);
                    this.OnPropertyChanging("Imaginary", e);
                    this._imaginary = value;
                    this.OnImaginaryChanged(e);
                    this.OnPropertyChanged("Imaginary", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//Complex/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Real property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RealChanging;
        
        /// <summary>
        /// Gets fired when the Real property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> RealChanged;
        
        /// <summary>
        /// Gets fired before the Imaginary property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ImaginaryChanging;
        
        /// <summary>
        /// Gets fired when the Imaginary property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ImaginaryChanged;
        
        /// <summary>
        /// Raises the RealChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRealChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RealChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the RealChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRealChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.RealChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ImaginaryChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnImaginaryChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ImaginaryChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ImaginaryChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnImaginaryChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ImaginaryChanged;
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
            if ((attribute == "REAL"))
            {
                return this.Real;
            }
            if ((attribute == "IMAGINARY"))
            {
                return this.Imaginary;
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
            if ((feature == "REAL"))
            {
                this.Real = ((double)(value));
                return;
            }
            if ((feature == "IMAGINARY"))
            {
                this.Imaginary = ((double)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//Complex/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the real property
        /// </summary>
        private sealed class RealProxy : ModelPropertyChange<IComplex, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RealProxy(IComplex modelElement) : 
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
                    return this.ModelElement.Real;
                }
                set
                {
                    this.ModelElement.Real = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RealChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RealChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the imaginary property
        /// </summary>
        private sealed class ImaginaryProxy : ModelPropertyChange<IComplex, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ImaginaryProxy(IComplex modelElement) : 
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
                    return this.ModelElement.Imaginary;
                }
                set
                {
                    this.ModelElement.Imaginary = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ImaginaryChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ImaginaryChanged -= handler;
            }
        }
    }
}

