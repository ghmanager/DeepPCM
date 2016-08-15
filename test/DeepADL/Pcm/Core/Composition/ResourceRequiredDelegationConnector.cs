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
    /// The default implementation of the ResourceRequiredDelegationConnector class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//ResourceReq" +
        "uiredDelegationConnector/")]
    public class ResourceRequiredDelegationConnector : ModelElement, IResourceRequiredDelegationConnector, IModelElement
    {
        
        /// <summary>
        /// The backing field for the InnerResourceRequiredRole_ResourceRequiredDelegationConnector property
        /// </summary>
        private IResourceRequiredRole _innerResourceRequiredRole_ResourceRequiredDelegationConnector;
        
        /// <summary>
        /// The backing field for the OuterResourceRequiredRole_ResourceRequiredDelegationConnector property
        /// </summary>
        private IResourceRequiredRole _outerResourceRequiredRole_ResourceRequiredDelegationConnector;
        
        /// <summary>
        /// The innerResourceRequiredRole_ResourceRequiredDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("innerResourceRequiredRole_ResourceRequiredDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public virtual IResourceRequiredRole InnerResourceRequiredRole_ResourceRequiredDelegationConnector
        {
            get
            {
                return this._innerResourceRequiredRole_ResourceRequiredDelegationConnector;
            }
            set
            {
                if ((this._innerResourceRequiredRole_ResourceRequiredDelegationConnector != value))
                {
                    IResourceRequiredRole old = this._innerResourceRequiredRole_ResourceRequiredDelegationConnector;
                    this._innerResourceRequiredRole_ResourceRequiredDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetInnerResourceRequiredRole_ResourceRequiredDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetInnerResourceRequiredRole_ResourceRequiredDelegationConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged(e);
                    this.OnPropertyChanged("InnerResourceRequiredRole_ResourceRequiredDelegationConnector", e);
                }
            }
        }
        
        /// <summary>
        /// The outerResourceRequiredRole_ResourceRequiredDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("outerResourceRequiredRole_ResourceRequiredDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public virtual IResourceRequiredRole OuterResourceRequiredRole_ResourceRequiredDelegationConnector
        {
            get
            {
                return this._outerResourceRequiredRole_ResourceRequiredDelegationConnector;
            }
            set
            {
                if ((this._outerResourceRequiredRole_ResourceRequiredDelegationConnector != value))
                {
                    IResourceRequiredRole old = this._outerResourceRequiredRole_ResourceRequiredDelegationConnector;
                    this._outerResourceRequiredRole_ResourceRequiredDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOuterResourceRequiredRole_ResourceRequiredDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOuterResourceRequiredRole_ResourceRequiredDelegationConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged(e);
                    this.OnPropertyChanged("OuterResourceRequiredRole_ResourceRequiredDelegationConnector", e);
                }
            }
        }
        
        /// <summary>
        /// The parentStructure_ResourceRequiredDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("parentStructure_ResourceRequiredDelegationConnector")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("resourceRequiredDelegationConnectors_ComposedStructure")]
        public virtual IComposedStructure ParentStructure_ResourceRequiredDelegationConnector
        {
            get
            {
                return ModelHelper.CastAs<IComposedStructure>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceRequiredDelegationConnectorReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//ResourceReq" +
                        "uiredDelegationConnector/");
            }
        }
        
        /// <summary>
        /// Gets fired when the InnerResourceRequiredRole_ResourceRequiredDelegationConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the OuterResourceRequiredRole_ResourceRequiredDelegationConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired when the ParentStructure_ResourceRequiredDelegationConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ParentStructure_ResourceRequiredDelegationConnectorChanged;
        
        /// <summary>
        /// Raises the InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InnerResourceRequiredRole_ResourceRequiredDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInnerResourceRequiredRole_ResourceRequiredDelegationConnector(object sender, EventArgs eventArgs)
        {
            this.InnerResourceRequiredRole_ResourceRequiredDelegationConnector = null;
        }
        
        /// <summary>
        /// Raises the OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OuterResourceRequiredRole_ResourceRequiredDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOuterResourceRequiredRole_ResourceRequiredDelegationConnector(object sender, EventArgs eventArgs)
        {
            this.OuterResourceRequiredRole_ResourceRequiredDelegationConnector = null;
        }
        
        /// <summary>
        /// Raises the ParentStructure_ResourceRequiredDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure_ResourceRequiredDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ParentStructure_ResourceRequiredDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IComposedStructure oldParentStructure_ResourceRequiredDelegationConnector = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure_ResourceRequiredDelegationConnector = ModelHelper.CastAs<IComposedStructure>(newParent);
            if ((oldParentStructure_ResourceRequiredDelegationConnector != null))
            {
                oldParentStructure_ResourceRequiredDelegationConnector.ResourceRequiredDelegationConnectors_ComposedStructure.Remove(this);
            }
            if ((newParentStructure_ResourceRequiredDelegationConnector != null))
            {
                newParentStructure_ResourceRequiredDelegationConnector.ResourceRequiredDelegationConnectors_ComposedStructure.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure_ResourceRequiredDelegationConnector, newParentStructure_ResourceRequiredDelegationConnector);
            this.OnParentStructure_ResourceRequiredDelegationConnectorChanged(e);
            this.OnPropertyChanged("ParentStructure_ResourceRequiredDelegationConnector", e);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INNERRESOURCEREQUIREDROLE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                this.InnerResourceRequiredRole_ResourceRequiredDelegationConnector = ((IResourceRequiredRole)(value));
                return;
            }
            if ((feature == "OUTERRESOURCEREQUIREDROLE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                this.OuterResourceRequiredRole_ResourceRequiredDelegationConnector = ((IResourceRequiredRole)(value));
                return;
            }
            if ((feature == "PARENTSTRUCTURE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                this.ParentStructure_ResourceRequiredDelegationConnector = ((IComposedStructure)(value));
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
            if ((attribute == "INNERRESOURCEREQUIREDROLE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                return new InnerResourceRequiredRole_ResourceRequiredDelegationConnectorProxy(this);
            }
            if ((attribute == "OUTERRESOURCEREQUIREDROLE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                return new OuterResourceRequiredRole_ResourceRequiredDelegationConnectorProxy(this);
            }
            if ((attribute == "PARENTSTRUCTURE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                return new ParentStructure_ResourceRequiredDelegationConnectorProxy(this);
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
            if ((reference == "INNERRESOURCEREQUIREDROLE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                return new InnerResourceRequiredRole_ResourceRequiredDelegationConnectorProxy(this);
            }
            if ((reference == "OUTERRESOURCEREQUIREDROLE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                return new OuterResourceRequiredRole_ResourceRequiredDelegationConnectorProxy(this);
            }
            if ((reference == "PARENTSTRUCTURE_RESOURCEREQUIREDDELEGATIONCONNECTOR"))
            {
                return new ParentStructure_ResourceRequiredDelegationConnectorProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//ResourceReq" +
                    "uiredDelegationConnector/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceRequiredDelegationConnector class
        /// </summary>
        public class ResourceRequiredDelegationConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceRequiredDelegationConnector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceRequiredDelegationConnectorReferencedElementsCollection(ResourceRequiredDelegationConnector parent)
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
                    if ((this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ParentStructure_ResourceRequiredDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.ParentStructure_ResourceRequiredDelegationConnectorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.ParentStructure_ResourceRequiredDelegationConnectorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector == null))
                {
                    IResourceRequiredRole innerResourceRequiredRole_ResourceRequiredDelegationConnectorCasted = item.As<IResourceRequiredRole>();
                    if ((innerResourceRequiredRole_ResourceRequiredDelegationConnectorCasted != null))
                    {
                        this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector = innerResourceRequiredRole_ResourceRequiredDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector == null))
                {
                    IResourceRequiredRole outerResourceRequiredRole_ResourceRequiredDelegationConnectorCasted = item.As<IResourceRequiredRole>();
                    if ((outerResourceRequiredRole_ResourceRequiredDelegationConnectorCasted != null))
                    {
                        this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector = outerResourceRequiredRole_ResourceRequiredDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.ParentStructure_ResourceRequiredDelegationConnector == null))
                {
                    IComposedStructure parentStructure_ResourceRequiredDelegationConnectorCasted = item.As<IComposedStructure>();
                    if ((parentStructure_ResourceRequiredDelegationConnectorCasted != null))
                    {
                        this._parent.ParentStructure_ResourceRequiredDelegationConnector = parentStructure_ResourceRequiredDelegationConnectorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector = null;
                this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector = null;
                this._parent.ParentStructure_ResourceRequiredDelegationConnector = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.ParentStructure_ResourceRequiredDelegationConnector))
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
                if ((this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ParentStructure_ResourceRequiredDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.ParentStructure_ResourceRequiredDelegationConnector;
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
                if ((this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector == item))
                {
                    this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector = null;
                    return true;
                }
                if ((this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector == item))
                {
                    this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector = null;
                    return true;
                }
                if ((this._parent.ParentStructure_ResourceRequiredDelegationConnector == item))
                {
                    this._parent.ParentStructure_ResourceRequiredDelegationConnector = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerResourceRequiredRole_ResourceRequiredDelegationConnector).Concat(this._parent.OuterResourceRequiredRole_ResourceRequiredDelegationConnector).Concat(this._parent.ParentStructure_ResourceRequiredDelegationConnector).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the innerResourceRequiredRole_ResourceRequiredDelegationConnector property
        /// </summary>
        private sealed class InnerResourceRequiredRole_ResourceRequiredDelegationConnectorProxy : ModelPropertyChange<IResourceRequiredDelegationConnector, IResourceRequiredRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InnerResourceRequiredRole_ResourceRequiredDelegationConnectorProxy(IResourceRequiredDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceRequiredRole Value
            {
                get
                {
                    return this.ModelElement.InnerResourceRequiredRole_ResourceRequiredDelegationConnector;
                }
                set
                {
                    this.ModelElement.InnerResourceRequiredRole_ResourceRequiredDelegationConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InnerResourceRequiredRole_ResourceRequiredDelegationConnectorChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the outerResourceRequiredRole_ResourceRequiredDelegationConnector property
        /// </summary>
        private sealed class OuterResourceRequiredRole_ResourceRequiredDelegationConnectorProxy : ModelPropertyChange<IResourceRequiredDelegationConnector, IResourceRequiredRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OuterResourceRequiredRole_ResourceRequiredDelegationConnectorProxy(IResourceRequiredDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceRequiredRole Value
            {
                get
                {
                    return this.ModelElement.OuterResourceRequiredRole_ResourceRequiredDelegationConnector;
                }
                set
                {
                    this.ModelElement.OuterResourceRequiredRole_ResourceRequiredDelegationConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OuterResourceRequiredRole_ResourceRequiredDelegationConnectorChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parentStructure_ResourceRequiredDelegationConnector property
        /// </summary>
        private sealed class ParentStructure_ResourceRequiredDelegationConnectorProxy : ModelPropertyChange<IResourceRequiredDelegationConnector, IComposedStructure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentStructure_ResourceRequiredDelegationConnectorProxy(IResourceRequiredDelegationConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IComposedStructure Value
            {
                get
                {
                    return this.ModelElement.ParentStructure_ResourceRequiredDelegationConnector;
                }
                set
                {
                    this.ModelElement.ParentStructure_ResourceRequiredDelegationConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure_ResourceRequiredDelegationConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure_ResourceRequiredDelegationConnectorChanged -= handler;
            }
        }
    }
}

