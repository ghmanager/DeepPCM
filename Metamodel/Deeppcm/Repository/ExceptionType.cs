//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core;
using DeepPCM.Deeppcm.Core.Composition;
using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Protocol;
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Resourcetype;
using DeepPCM.Deeppcm.Seff;
using DeepPCM.Identifier;
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

namespace DeepPCM.Deeppcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the ExceptionType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//ExceptionType/")]
    public class ExceptionType : ModelElement, IExceptionType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ExceptionName property
        /// </summary>
        private string _exceptionName;
        
        /// <summary>
        /// The backing field for the ExceptionMessage property
        /// </summary>
        private string _exceptionMessage;
        
        /// <summary>
        /// The exceptionName property
        /// </summary>
        [XmlElementNameAttribute("exceptionName")]
        [XmlAttributeAttribute(true)]
        public virtual string ExceptionName
        {
            get
            {
                return this._exceptionName;
            }
            set
            {
                if ((this._exceptionName != value))
                {
                    string old = this._exceptionName;
                    this._exceptionName = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnExceptionNameChanged(e);
                    this.OnPropertyChanged("ExceptionName", e);
                }
            }
        }
        
        /// <summary>
        /// The exceptionMessage property
        /// </summary>
        [XmlElementNameAttribute("exceptionMessage")]
        [XmlAttributeAttribute(true)]
        public virtual string ExceptionMessage
        {
            get
            {
                return this._exceptionMessage;
            }
            set
            {
                if ((this._exceptionMessage != value))
                {
                    string old = this._exceptionMessage;
                    this._exceptionMessage = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnExceptionMessageChanged(e);
                    this.OnPropertyChanged("ExceptionMessage", e);
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
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//ExceptionType/");
            }
        }
        
        /// <summary>
        /// Gets fired when the ExceptionName property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ExceptionNameChanged;
        
        /// <summary>
        /// Gets fired when the ExceptionMessage property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ExceptionMessageChanged;
        
        /// <summary>
        /// Raises the ExceptionNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnExceptionNameChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ExceptionNameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ExceptionMessageChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnExceptionMessageChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ExceptionMessageChanged;
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
            if ((attribute == "EXCEPTIONNAME"))
            {
                return this.ExceptionName;
            }
            if ((attribute == "EXCEPTIONMESSAGE"))
            {
                return this.ExceptionMessage;
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
            if ((feature == "EXCEPTIONNAME"))
            {
                this.ExceptionName = ((string)(value));
                return;
            }
            if ((feature == "EXCEPTIONMESSAGE"))
            {
                this.ExceptionMessage = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//ExceptionType/")));
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the exceptionName property
        /// </summary>
        private sealed class ExceptionNameProxy : ModelPropertyChange<IExceptionType, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ExceptionNameProxy(IExceptionType modelElement) : 
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
                    return this.ModelElement.ExceptionName;
                }
                set
                {
                    this.ModelElement.ExceptionName = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ExceptionNameChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ExceptionNameChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the exceptionMessage property
        /// </summary>
        private sealed class ExceptionMessageProxy : ModelPropertyChange<IExceptionType, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ExceptionMessageProxy(IExceptionType modelElement) : 
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
                    return this.ModelElement.ExceptionMessage;
                }
                set
                {
                    this.ModelElement.ExceptionMessage = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ExceptionMessageChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ExceptionMessageChanged -= handler;
            }
        }
    }
}

