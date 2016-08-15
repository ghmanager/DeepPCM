//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
using Metamodel.Identifier;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Core.Composition
{
    
    
    /// <summary>
    /// The default implementation of the DelegationConnector class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/Core/Composition/1.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//core//composition//DelegationConnector/" +
        "")]
    [DebuggerDisplayAttribute("DelegationConnector {Id}")]
    public abstract class DelegationConnector : Connector, IDelegationConnector, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Port property
        /// </summary>
        private IRequiredInterface _port;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The Port property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IRequiredInterface Port
        {
            get
            {
                return this._port;
            }
            set
            {
                if ((this._port != value))
                {
                    IRequiredInterface old = this._port;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPortChanging(e);
                    this.OnPropertyChanging("Port", e);
                    this._port = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetPort;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetPort;
                    }
                    this.OnPortChanged(e);
                    this.OnPropertyChanged("Port", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DelegationConnectorReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//core//composition//DelegationConnector/" +
                            "")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Port property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PortChanging;
        
        /// <summary>
        /// Gets fired when the Port property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> PortChanged;
        
        /// <summary>
        /// Raises the PortChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPortChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PortChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the PortChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPortChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.PortChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Port property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPort(object sender, System.EventArgs eventArgs)
        {
            this.Port = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PORT"))
            {
                this.Port = ((IRequiredInterface)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "PORT"))
            {
                return new PortProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "PORT"))
            {
                return new PortProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//core//composition//DelegationConnector/" +
                        "")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DelegationConnector class
        /// </summary>
        public class DelegationConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DelegationConnector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DelegationConnectorReferencedElementsCollection(DelegationConnector parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.Port != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PortChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PortChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Port == null))
                {
                    IRequiredInterface portCasted = item.As<IRequiredInterface>();
                    if ((portCasted != null))
                    {
                        this._parent.Port = portCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Port = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Port))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Port != null))
                {
                    array[arrayIndex] = this._parent.Port;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Port == item))
                {
                    this._parent.Port = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Port).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Port property
        /// </summary>
        private sealed class PortProxy : ModelPropertyChange<IDelegationConnector, IRequiredInterface>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PortProxy(IDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRequiredInterface Value
            {
                get
                {
                    return this.ModelElement.Port;
                }
                set
                {
                    this.ModelElement.Port = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PortChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PortChanged -= handler;
            }
        }
    }
}

