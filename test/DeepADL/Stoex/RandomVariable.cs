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
    /// The default implementation of the RandomVariable class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0")]
    [XmlNamespacePrefixAttribute("stoex")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//RandomVariable/")]
    public class RandomVariable : ModelElement, IRandomVariable, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Specification property
        /// </summary>
        private string _specification;
        
        /// <summary>
        /// The specification property
        /// </summary>
        [XmlElementNameAttribute("specification")]
        [XmlAttributeAttribute(true)]
        public virtual string Specification
        {
            get
            {
                return this._specification;
            }
            set
            {
                if ((this._specification != value))
                {
                    string old = this._specification;
                    this._specification = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSpecificationChanged(e);
                    this.OnPropertyChanged("Specification", e);
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
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//RandomVariable/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Specification property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SpecificationChanged;
        
        /// <summary>
        /// Raises the SpecificationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSpecificationChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SpecificationChanged;
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
            if ((attribute == "SPECIFICATION"))
            {
                return this.Specification;
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
            if ((feature == "SPECIFICATION"))
            {
                this.Specification = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//RandomVariable/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the specification property
        /// </summary>
        private sealed class SpecificationProxy : ModelPropertyChange<IRandomVariable, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SpecificationProxy(IRandomVariable modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Specification;
                }
                set
                {
                    this.ModelElement.Specification = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SpecificationChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SpecificationChanged -= handler;
            }
        }
    }
}

