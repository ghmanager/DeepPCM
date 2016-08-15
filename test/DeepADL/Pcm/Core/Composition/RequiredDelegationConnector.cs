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
using GeneratedCode.Pcm.Repository;
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

namespace GeneratedCode.Pcm.Core.Composition
{
    
    
    /// <summary>
    /// The default implementation of the RequiredDelegationConnector class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//RequiredDel" +
        "egationConnector/")]
    [DebuggerDisplayAttribute("RequiredDelegationConnector {Id}")]
    public class RequiredDelegationConnector : DelegationConnector, IRequiredDelegationConnector, IModelElement
    {
        
        /// <summary>
        /// The backing field for the InnerRequiredRole_RequiredDelegationConnector property
        /// </summary>
        private IOperationRequiredRole _innerRequiredRole_RequiredDelegationConnector;
        
        /// <summary>
        /// The backing field for the OuterRequiredRole_RequiredDelegationConnector property
        /// </summary>
        private IOperationRequiredRole _outerRequiredRole_RequiredDelegationConnector;
        
        /// <summary>
        /// The backing field for the AssemblyContext_RequiredDelegationConnector property
        /// </summary>
        private IAssemblyContext _assemblyContext_RequiredDelegationConnector;
        
        /// <summary>
        /// The innerRequiredRole_RequiredDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("innerRequiredRole_RequiredDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public virtual IOperationRequiredRole InnerRequiredRole_RequiredDelegationConnector
        {
            get
            {
                return this._innerRequiredRole_RequiredDelegationConnector;
            }
            set
            {
                if ((this._innerRequiredRole_RequiredDelegationConnector != value))
                {
                    IOperationRequiredRole old = this._innerRequiredRole_RequiredDelegationConnector;
                    this._innerRequiredRole_RequiredDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetInnerRequiredRole_RequiredDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetInnerRequiredRole_RequiredDelegationConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInnerRequiredRole_RequiredDelegationConnectorChanged(e);
                    this.OnPropertyChanged("InnerRequiredRole_RequiredDelegationConnector", e);
                }
            }
        }
        
        /// <summary>
        /// The outerRequiredRole_RequiredDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("outerRequiredRole_RequiredDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public virtual IOperationRequiredRole OuterRequiredRole_RequiredDelegationConnector
        {
            get
            {
                return this._outerRequiredRole_RequiredDelegationConnector;
            }
            set
            {
                if ((this._outerRequiredRole_RequiredDelegationConnector != value))
                {
                    IOperationRequiredRole old = this._outerRequiredRole_RequiredDelegationConnector;
                    this._outerRequiredRole_RequiredDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOuterRequiredRole_RequiredDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOuterRequiredRole_RequiredDelegationConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOuterRequiredRole_RequiredDelegationConnectorChanged(e);
                    this.OnPropertyChanged("OuterRequiredRole_RequiredDelegationConnector", e);
                }
            }
        }
        
        /// <summary>
        /// The assemblyContext_RequiredDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("assemblyContext_RequiredDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public virtual IAssemblyContext AssemblyContext_RequiredDelegationConnector
        {
            get
            {
                return this._assemblyContext_RequiredDelegationConnector;
            }
            set
            {
                if ((this._assemblyContext_RequiredDelegationConnector != value))
                {
                    IAssemblyContext old = this._assemblyContext_RequiredDelegationConnector;
                    this._assemblyContext_RequiredDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAssemblyContext_RequiredDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAssemblyContext_RequiredDelegationConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAssemblyContext_RequiredDelegationConnectorChanged(e);
                    this.OnPropertyChanged("AssemblyContext_RequiredDelegationConnector", e);
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
                return base.ReferencedElements.Concat(new RequiredDelegationConnectorReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//RequiredDel" +
                        "egationConnector/");
            }
        }
        
        /// <summary>
        /// Gets fired when the InnerRequiredRole_RequiredDelegationConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> InnerRequiredRole_RequiredDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the OuterRequiredRole_RequiredDelegationConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> OuterRequiredRole_RequiredDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the AssemblyContext_RequiredDelegationConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> AssemblyContext_RequiredDelegationConnectorChanged;
        
        /// <summary>
        /// Raises the InnerRequiredRole_RequiredDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerRequiredRole_RequiredDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.InnerRequiredRole_RequiredDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InnerRequiredRole_RequiredDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInnerRequiredRole_RequiredDelegationConnector(object sender, EventArgs eventArgs)
        {
            this.InnerRequiredRole_RequiredDelegationConnector = null;
        }
        
        /// <summary>
        /// Raises the OuterRequiredRole_RequiredDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOuterRequiredRole_RequiredDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.OuterRequiredRole_RequiredDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OuterRequiredRole_RequiredDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOuterRequiredRole_RequiredDelegationConnector(object sender, EventArgs eventArgs)
        {
            this.OuterRequiredRole_RequiredDelegationConnector = null;
        }
        
        /// <summary>
        /// Raises the AssemblyContext_RequiredDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext_RequiredDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext_RequiredDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AssemblyContext_RequiredDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAssemblyContext_RequiredDelegationConnector(object sender, EventArgs eventArgs)
        {
            this.AssemblyContext_RequiredDelegationConnector = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INNERREQUIREDROLE_REQUIREDDELEGATIONCONNECTOR"))
            {
                this.InnerRequiredRole_RequiredDelegationConnector = ((IOperationRequiredRole)(value));
                return;
            }
            if ((feature == "OUTERREQUIREDROLE_REQUIREDDELEGATIONCONNECTOR"))
            {
                this.OuterRequiredRole_RequiredDelegationConnector = ((IOperationRequiredRole)(value));
                return;
            }
            if ((feature == "ASSEMBLYCONTEXT_REQUIREDDELEGATIONCONNECTOR"))
            {
                this.AssemblyContext_RequiredDelegationConnector = ((IAssemblyContext)(value));
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
            if ((attribute == "INNERREQUIREDROLE_REQUIREDDELEGATIONCONNECTOR"))
            {
                return new InnerRequiredRole_RequiredDelegationConnectorProxy(this);
            }
            if ((attribute == "OUTERREQUIREDROLE_REQUIREDDELEGATIONCONNECTOR"))
            {
                return new OuterRequiredRole_RequiredDelegationConnectorProxy(this);
            }
            if ((attribute == "ASSEMBLYCONTEXT_REQUIREDDELEGATIONCONNECTOR"))
            {
                return new AssemblyContext_RequiredDelegationConnectorProxy(this);
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
            if ((reference == "INNERREQUIREDROLE_REQUIREDDELEGATIONCONNECTOR"))
            {
                return new InnerRequiredRole_RequiredDelegationConnectorProxy(this);
            }
            if ((reference == "OUTERREQUIREDROLE_REQUIREDDELEGATIONCONNECTOR"))
            {
                return new OuterRequiredRole_RequiredDelegationConnectorProxy(this);
            }
            if ((reference == "ASSEMBLYCONTEXT_REQUIREDDELEGATIONCONNECTOR"))
            {
                return new AssemblyContext_RequiredDelegationConnectorProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//RequiredDel" +
                    "egationConnector/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RequiredDelegationConnector class
        /// </summary>
        public class RequiredDelegationConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RequiredDelegationConnector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RequiredDelegationConnectorReferencedElementsCollection(RequiredDelegationConnector parent)
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
                    if ((this._parent.InnerRequiredRole_RequiredDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OuterRequiredRole_RequiredDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AssemblyContext_RequiredDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerRequiredRole_RequiredDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.OuterRequiredRole_RequiredDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.AssemblyContext_RequiredDelegationConnectorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerRequiredRole_RequiredDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.OuterRequiredRole_RequiredDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.AssemblyContext_RequiredDelegationConnectorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerRequiredRole_RequiredDelegationConnector == null))
                {
                    IOperationRequiredRole innerRequiredRole_RequiredDelegationConnectorCasted = item.As<IOperationRequiredRole>();
                    if ((innerRequiredRole_RequiredDelegationConnectorCasted != null))
                    {
                        this._parent.InnerRequiredRole_RequiredDelegationConnector = innerRequiredRole_RequiredDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.OuterRequiredRole_RequiredDelegationConnector == null))
                {
                    IOperationRequiredRole outerRequiredRole_RequiredDelegationConnectorCasted = item.As<IOperationRequiredRole>();
                    if ((outerRequiredRole_RequiredDelegationConnectorCasted != null))
                    {
                        this._parent.OuterRequiredRole_RequiredDelegationConnector = outerRequiredRole_RequiredDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.AssemblyContext_RequiredDelegationConnector == null))
                {
                    IAssemblyContext assemblyContext_RequiredDelegationConnectorCasted = item.As<IAssemblyContext>();
                    if ((assemblyContext_RequiredDelegationConnectorCasted != null))
                    {
                        this._parent.AssemblyContext_RequiredDelegationConnector = assemblyContext_RequiredDelegationConnectorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerRequiredRole_RequiredDelegationConnector = null;
                this._parent.OuterRequiredRole_RequiredDelegationConnector = null;
                this._parent.AssemblyContext_RequiredDelegationConnector = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerRequiredRole_RequiredDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.OuterRequiredRole_RequiredDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.AssemblyContext_RequiredDelegationConnector))
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
                if ((this._parent.InnerRequiredRole_RequiredDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.InnerRequiredRole_RequiredDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OuterRequiredRole_RequiredDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.OuterRequiredRole_RequiredDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AssemblyContext_RequiredDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.AssemblyContext_RequiredDelegationConnector;
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
                if ((this._parent.InnerRequiredRole_RequiredDelegationConnector == item))
                {
                    this._parent.InnerRequiredRole_RequiredDelegationConnector = null;
                    return true;
                }
                if ((this._parent.OuterRequiredRole_RequiredDelegationConnector == item))
                {
                    this._parent.OuterRequiredRole_RequiredDelegationConnector = null;
                    return true;
                }
                if ((this._parent.AssemblyContext_RequiredDelegationConnector == item))
                {
                    this._parent.AssemblyContext_RequiredDelegationConnector = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerRequiredRole_RequiredDelegationConnector).Concat(this._parent.OuterRequiredRole_RequiredDelegationConnector).Concat(this._parent.AssemblyContext_RequiredDelegationConnector).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the innerRequiredRole_RequiredDelegationConnector property
        /// </summary>
        private sealed class InnerRequiredRole_RequiredDelegationConnectorProxy : ModelPropertyChange<IRequiredDelegationConnector, IOperationRequiredRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InnerRequiredRole_RequiredDelegationConnectorProxy(IRequiredDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperationRequiredRole Value
            {
                get
                {
                    return this.ModelElement.InnerRequiredRole_RequiredDelegationConnector;
                }
                set
                {
                    this.ModelElement.InnerRequiredRole_RequiredDelegationConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InnerRequiredRole_RequiredDelegationConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InnerRequiredRole_RequiredDelegationConnectorChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the outerRequiredRole_RequiredDelegationConnector property
        /// </summary>
        private sealed class OuterRequiredRole_RequiredDelegationConnectorProxy : ModelPropertyChange<IRequiredDelegationConnector, IOperationRequiredRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OuterRequiredRole_RequiredDelegationConnectorProxy(IRequiredDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperationRequiredRole Value
            {
                get
                {
                    return this.ModelElement.OuterRequiredRole_RequiredDelegationConnector;
                }
                set
                {
                    this.ModelElement.OuterRequiredRole_RequiredDelegationConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OuterRequiredRole_RequiredDelegationConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OuterRequiredRole_RequiredDelegationConnectorChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the assemblyContext_RequiredDelegationConnector property
        /// </summary>
        private sealed class AssemblyContext_RequiredDelegationConnectorProxy : ModelPropertyChange<IRequiredDelegationConnector, IAssemblyContext>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AssemblyContext_RequiredDelegationConnectorProxy(IRequiredDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAssemblyContext Value
            {
                get
                {
                    return this.ModelElement.AssemblyContext_RequiredDelegationConnector;
                }
                set
                {
                    this.ModelElement.AssemblyContext_RequiredDelegationConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AssemblyContext_RequiredDelegationConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AssemblyContext_RequiredDelegationConnectorChanged -= handler;
            }
        }
    }
}

