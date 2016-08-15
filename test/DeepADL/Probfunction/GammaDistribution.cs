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
    /// The default implementation of the GammaDistribution class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0")]
    [XmlNamespacePrefixAttribute("probfunction")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0#//GammaDistribution/")]
    public class GammaDistribution : ContinuousPDF, IGammaDistribution, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Alpha property
        /// </summary>
        private double _alpha;
        
        /// <summary>
        /// The backing field for the Theta property
        /// </summary>
        private double _theta;
        
        /// <summary>
        /// The alpha property
        /// </summary>
        [XmlElementNameAttribute("alpha")]
        [XmlAttributeAttribute(true)]
        public virtual double Alpha
        {
            get
            {
                return this._alpha;
            }
            set
            {
                if ((this._alpha != value))
                {
                    double old = this._alpha;
                    this._alpha = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAlphaChanged(e);
                    this.OnPropertyChanged("Alpha", e);
                }
            }
        }
        
        /// <summary>
        /// The theta property
        /// </summary>
        [XmlElementNameAttribute("theta")]
        [XmlAttributeAttribute(true)]
        public virtual double Theta
        {
            get
            {
                return this._theta;
            }
            set
            {
                if ((this._theta != value))
                {
                    double old = this._theta;
                    this._theta = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnThetaChanged(e);
                    this.OnPropertyChanged("Theta", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/ProbFunction/1.0#//GammaDistribution/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Alpha property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> AlphaChanged;
        
        /// <summary>
        /// Gets fired when the Theta property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ThetaChanged;
        
        /// <summary>
        /// Raises the AlphaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAlphaChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.AlphaChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ThetaChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnThetaChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ThetaChanged;
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
            if ((attribute == "ALPHA"))
            {
                return this.Alpha;
            }
            if ((attribute == "THETA"))
            {
                return this.Theta;
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
            if ((feature == "ALPHA"))
            {
                this.Alpha = ((double)(value));
                return;
            }
            if ((feature == "THETA"))
            {
                this.Theta = ((double)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//GammaDistribution/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the alpha property
        /// </summary>
        private sealed class AlphaProxy : ModelPropertyChange<IGammaDistribution, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AlphaProxy(IGammaDistribution modelElement) : 
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
                    return this.ModelElement.Alpha;
                }
                set
                {
                    this.ModelElement.Alpha = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AlphaChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AlphaChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the theta property
        /// </summary>
        private sealed class ThetaProxy : ModelPropertyChange<IGammaDistribution, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ThetaProxy(IGammaDistribution modelElement) : 
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
                    return this.ModelElement.Theta;
                }
                set
                {
                    this.ModelElement.Theta = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ThetaChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ThetaChanged -= handler;
            }
        }
    }
}

