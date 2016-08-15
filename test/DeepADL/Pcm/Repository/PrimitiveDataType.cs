//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Protocol;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Resourcetype;
using GeneratedCode.Pcm.Seff;
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

namespace GeneratedCode.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the PrimitiveDataType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//PrimitiveDataType/" +
        "")]
    public class PrimitiveDataType : DataType, IPrimitiveDataType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private PrimitiveTypeEnum _type;
        
        /// <summary>
        /// The type property
        /// </summary>
        [XmlElementNameAttribute("type")]
        [XmlAttributeAttribute(true)]
        public virtual PrimitiveTypeEnum Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    PrimitiveTypeEnum old = this._type;
                    this._type = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e);
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
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//PrimitiveDataType/" +
                        "");
            }
        }
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
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
            if ((attribute == "TYPE"))
            {
                return this.Type;
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
            if ((feature == "TYPE"))
            {
                this.Type = ((PrimitiveTypeEnum)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//PrimitiveDataType/" +
                    "")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IPrimitiveDataType, PrimitiveTypeEnum>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IPrimitiveDataType modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override PrimitiveTypeEnum Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged -= handler;
            }
        }
    }
}

