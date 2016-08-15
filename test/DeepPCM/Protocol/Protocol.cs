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

namespace Metamodel.DeepPCM.Protocol
{
    
    
    /// <summary>
    /// The default implementation of the Protocol class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/Protocol/1.0")]
    [XmlNamespacePrefixAttribute("protocol")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//protocol//Protocol/")]
    public abstract class Protocol : ModelElement, IProtocol, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ProtocolTypeID property
        /// </summary>
        private string _protocolTypeID;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The protocolTypeID property
        /// </summary>
        [XmlElementNameAttribute("protocolTypeID")]
        [XmlAttributeAttribute(true)]
        public virtual string ProtocolTypeID
        {
            get
            {
                return this._protocolTypeID;
            }
            set
            {
                if ((this._protocolTypeID != value))
                {
                    string old = this._protocolTypeID;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnProtocolTypeIDChanging(e);
                    this.OnPropertyChanging("ProtocolTypeID", e);
                    this._protocolTypeID = value;
                    this.OnProtocolTypeIDChanged(e);
                    this.OnPropertyChanged("ProtocolTypeID", e);
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//protocol//Protocol/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ProtocolTypeID property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ProtocolTypeIDChanging;
        
        /// <summary>
        /// Gets fired when the ProtocolTypeID property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ProtocolTypeIDChanged;
        
        /// <summary>
        /// Raises the ProtocolTypeIDChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProtocolTypeIDChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ProtocolTypeIDChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ProtocolTypeIDChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProtocolTypeIDChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ProtocolTypeIDChanged;
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
            if ((attribute == "PROTOCOLTYPEID"))
            {
                return this.ProtocolTypeID;
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
            if ((feature == "PROTOCOLTYPEID"))
            {
                this.ProtocolTypeID = ((string)(value));
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//protocol//Protocol/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the protocolTypeID property
        /// </summary>
        private sealed class ProtocolTypeIDProxy : ModelPropertyChange<IProtocol, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ProtocolTypeIDProxy(IProtocol modelElement) : 
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
                    return this.ModelElement.ProtocolTypeID;
                }
                set
                {
                    this.ModelElement.ProtocolTypeID = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ProtocolTypeIDChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ProtocolTypeIDChanged -= handler;
            }
        }
    }
}

