//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Probfunction;
using DeepPCM.Units;
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

namespace DeepPCM.Stoex
{
    
    
    /// <summary>
    /// The default implementation of the AbstractNamedReference class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0")]
    [XmlNamespacePrefixAttribute("stoex")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//AbstractNamedReference/")]
    public abstract class AbstractNamedReference : ModelElement, IAbstractNamedReference, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReferenceName property
        /// </summary>
        private string _referenceName;
        
        /// <summary>
        /// The referenceName property
        /// </summary>
        [XmlElementNameAttribute("referenceName")]
        [XmlAttributeAttribute(true)]
        public virtual string ReferenceName
        {
            get
            {
                return this._referenceName;
            }
            set
            {
                if ((this._referenceName != value))
                {
                    string old = this._referenceName;
                    this._referenceName = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReferenceNameChanged(e);
                    this.OnPropertyChanged("ReferenceName", e);
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
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//AbstractNamedReference/");
            }
        }
        
        /// <summary>
        /// Gets fired when the ReferenceName property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ReferenceNameChanged;
        
        /// <summary>
        /// Raises the ReferenceNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReferenceNameChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ReferenceNameChanged;
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
            if ((attribute == "REFERENCENAME"))
            {
                return this.ReferenceName;
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
            if ((feature == "REFERENCENAME"))
            {
                this.ReferenceName = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//AbstractNamedReference/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the referenceName property
        /// </summary>
        private sealed class ReferenceNameProxy : ModelPropertyChange<IAbstractNamedReference, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReferenceNameProxy(IAbstractNamedReference modelElement) : 
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
                    return this.ModelElement.ReferenceName;
                }
                set
                {
                    this.ModelElement.ReferenceName = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReferenceNameChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReferenceNameChanged -= handler;
            }
        }
    }
}

