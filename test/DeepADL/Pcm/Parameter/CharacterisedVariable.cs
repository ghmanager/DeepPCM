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
using GeneratedCode.Pcm.Core.Composition;
using GeneratedCode.Pcm.Qosannotations;
using GeneratedCode.Pcm.Seff;
using GeneratedCode.Pcm.Usagemodel;
using GeneratedCode.Stoex;
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

namespace GeneratedCode.Pcm.Parameter
{
    
    
    /// <summary>
    /// The default implementation of the CharacterisedVariable class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Parameter/5.0")]
    [XmlNamespacePrefixAttribute("parameter")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//parameter//CharacterisedVariab" +
        "le/")]
    public class CharacterisedVariable : Variable, ICharacterisedVariable, IModelElement
    {
        
        /// <summary>
        /// The backing field for the CharacterisationType property
        /// </summary>
        private VariableCharacterisationType _characterisationType;
        
        /// <summary>
        /// The characterisationType property
        /// </summary>
        [XmlElementNameAttribute("characterisationType")]
        [XmlAttributeAttribute(true)]
        public virtual VariableCharacterisationType CharacterisationType
        {
            get
            {
                return this._characterisationType;
            }
            set
            {
                if ((this._characterisationType != value))
                {
                    VariableCharacterisationType old = this._characterisationType;
                    this._characterisationType = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCharacterisationTypeChanged(e);
                    this.OnPropertyChanged("CharacterisationType", e);
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
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//parameter//CharacterisedVariab" +
                        "le/");
            }
        }
        
        /// <summary>
        /// Gets fired when the CharacterisationType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> CharacterisationTypeChanged;
        
        /// <summary>
        /// Raises the CharacterisationTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCharacterisationTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.CharacterisationTypeChanged;
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
            if ((attribute == "CHARACTERISATIONTYPE"))
            {
                return this.CharacterisationType;
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
            if ((feature == "CHARACTERISATIONTYPE"))
            {
                this.CharacterisationType = ((VariableCharacterisationType)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//parameter//CharacterisedVariab" +
                    "le/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the characterisationType property
        /// </summary>
        private sealed class CharacterisationTypeProxy : ModelPropertyChange<ICharacterisedVariable, VariableCharacterisationType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CharacterisationTypeProxy(ICharacterisedVariable modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override VariableCharacterisationType Value
            {
                get
                {
                    return this.ModelElement.CharacterisationType;
                }
                set
                {
                    this.ModelElement.CharacterisationType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CharacterisationTypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.CharacterisationTypeChanged -= handler;
            }
        }
    }
}
