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
    /// The default implementation of the EventType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//EventType/")]
    [DebuggerDisplayAttribute("EventType {Id}")]
    public class EventType : DeepPCM.Deeppcm.Repository.Signature, IEventType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Parameter__EventType property
        /// </summary>
        private IParameter _parameter__EventType;
        
        /// <summary>
        /// The parameter__EventType property
        /// </summary>
        [XmlElementNameAttribute("parameter__EventType")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("eventType__Parameter")]
        public virtual IParameter Parameter__EventType
        {
            get
            {
                return this._parameter__EventType;
            }
            set
            {
                if ((this._parameter__EventType != value))
                {
                    IParameter old = this._parameter__EventType;
                    this._parameter__EventType = value;
                    if ((old != null))
                    {
                        old.EventType__Parameter = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetParameter__EventType;
                    }
                    if ((value != null))
                    {
                        value.EventType__Parameter = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetParameter__EventType;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnParameter__EventTypeChanged(e);
                    this.OnPropertyChanged("Parameter__EventType", e);
                }
            }
        }
        
        /// <summary>
        /// The eventGroup__EventType property
        /// </summary>
        [XmlElementNameAttribute("eventGroup__EventType")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("eventTypes__EventGroup")]
        public virtual IEventGroup EventGroup__EventType
        {
            get
            {
                return ModelHelper.CastAs<IEventGroup>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EventTypeChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EventTypeReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//EventType/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Parameter__EventType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Parameter__EventTypeChanged;
        
        /// <summary>
        /// Gets fired when the EventGroup__EventType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> EventGroup__EventTypeChanged;
        
        /// <summary>
        /// Raises the Parameter__EventTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParameter__EventTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Parameter__EventTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Parameter__EventType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetParameter__EventType(object sender, EventArgs eventArgs)
        {
            this.Parameter__EventType = null;
        }
        
        /// <summary>
        /// Raises the EventGroup__EventTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEventGroup__EventTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.EventGroup__EventTypeChanged;
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
            IEventGroup oldEventGroup__EventType = ModelHelper.CastAs<IEventGroup>(oldParent);
            IEventGroup newEventGroup__EventType = ModelHelper.CastAs<IEventGroup>(newParent);
            if ((oldEventGroup__EventType != null))
            {
                oldEventGroup__EventType.EventTypes__EventGroup.Remove(this);
            }
            if ((newEventGroup__EventType != null))
            {
                newEventGroup__EventType.EventTypes__EventGroup.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldEventGroup__EventType, newEventGroup__EventType);
            this.OnEventGroup__EventTypeChanged(e);
            this.OnPropertyChanged("EventGroup__EventType", e);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Parameter__EventType))
            {
                return ModelHelper.CreatePath("Parameter__EventType");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "PARAMETER__EVENTTYPE"))
            {
                return this.Parameter__EventType;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PARAMETER__EVENTTYPE"))
            {
                this.Parameter__EventType = ((IParameter)(value));
                return;
            }
            if ((feature == "EVENTGROUP__EVENTTYPE"))
            {
                this.EventGroup__EventType = ((IEventGroup)(value));
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
            if ((attribute == "PARAMETER__EVENTTYPE"))
            {
                return new Parameter__EventTypeProxy(this);
            }
            if ((attribute == "EVENTGROUP__EVENTTYPE"))
            {
                return new EventGroup__EventTypeProxy(this);
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
            if ((reference == "PARAMETER__EVENTTYPE"))
            {
                return new Parameter__EventTypeProxy(this);
            }
            if ((reference == "EVENTGROUP__EVENTTYPE"))
            {
                return new EventGroup__EventTypeProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//EventType/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventType class
        /// </summary>
        public class EventTypeChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventTypeChildrenCollection(EventType parent)
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
                    if ((this._parent.Parameter__EventType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter__EventTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter__EventTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Parameter__EventType == null))
                {
                    IParameter parameter__EventTypeCasted = item.As<IParameter>();
                    if ((parameter__EventTypeCasted != null))
                    {
                        this._parent.Parameter__EventType = parameter__EventTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter__EventType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Parameter__EventType))
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
                if ((this._parent.Parameter__EventType != null))
                {
                    array[arrayIndex] = this._parent.Parameter__EventType;
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
                if ((this._parent.Parameter__EventType == item))
                {
                    this._parent.Parameter__EventType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter__EventType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventType class
        /// </summary>
        public class EventTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventTypeReferencedElementsCollection(EventType parent)
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
                    if ((this._parent.Parameter__EventType != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.EventGroup__EventType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter__EventTypeChanged += this.PropagateValueChanges;
                this._parent.EventGroup__EventTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter__EventTypeChanged -= this.PropagateValueChanges;
                this._parent.EventGroup__EventTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Parameter__EventType == null))
                {
                    IParameter parameter__EventTypeCasted = item.As<IParameter>();
                    if ((parameter__EventTypeCasted != null))
                    {
                        this._parent.Parameter__EventType = parameter__EventTypeCasted;
                        return;
                    }
                }
                if ((this._parent.EventGroup__EventType == null))
                {
                    IEventGroup eventGroup__EventTypeCasted = item.As<IEventGroup>();
                    if ((eventGroup__EventTypeCasted != null))
                    {
                        this._parent.EventGroup__EventType = eventGroup__EventTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter__EventType = null;
                this._parent.EventGroup__EventType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Parameter__EventType))
                {
                    return true;
                }
                if ((item == this._parent.EventGroup__EventType))
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
                if ((this._parent.Parameter__EventType != null))
                {
                    array[arrayIndex] = this._parent.Parameter__EventType;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.EventGroup__EventType != null))
                {
                    array[arrayIndex] = this._parent.EventGroup__EventType;
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
                if ((this._parent.Parameter__EventType == item))
                {
                    this._parent.Parameter__EventType = null;
                    return true;
                }
                if ((this._parent.EventGroup__EventType == item))
                {
                    this._parent.EventGroup__EventType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter__EventType).Concat(this._parent.EventGroup__EventType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parameter__EventType property
        /// </summary>
        private sealed class Parameter__EventTypeProxy : ModelPropertyChange<IEventType, IParameter>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Parameter__EventTypeProxy(IEventType modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IParameter Value
            {
                get
                {
                    return this.ModelElement.Parameter__EventType;
                }
                set
                {
                    this.ModelElement.Parameter__EventType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Parameter__EventTypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Parameter__EventTypeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the eventGroup__EventType property
        /// </summary>
        private sealed class EventGroup__EventTypeProxy : ModelPropertyChange<IEventType, IEventGroup>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EventGroup__EventTypeProxy(IEventType modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEventGroup Value
            {
                get
                {
                    return this.ModelElement.EventGroup__EventType;
                }
                set
                {
                    this.ModelElement.EventGroup__EventType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EventGroup__EventTypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EventGroup__EventTypeChanged -= handler;
            }
        }
    }
}

