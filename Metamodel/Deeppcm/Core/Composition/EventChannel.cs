//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
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

namespace DeepPCM.Deeppcm.Core.Composition
{
    
    
    /// <summary>
    /// The default implementation of the EventChannel class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//EventChanne" +
        "l/")]
    [DebuggerDisplayAttribute("EventChannel {Id}")]
    public class EventChannel : DeepPCM.Deeppcm.Core.Entity.Entity, IEventChannel, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EventPublisher property
        /// </summary>
        private ObservableCompositionList<IEventPublisher> _eventPublisher;
        
        public EventChannel()
        {
            this._eventPublisher = new ObservableCompositionList<IEventPublisher>(this);
            this._eventPublisher.CollectionChanged += this.EventPublisherCollectionChanged;
        }
        
        /// <summary>
        /// The eventPublisher property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eventPublisher")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IEventPublisher> EventPublisher
        {
            get
            {
                return this._eventPublisher;
            }
        }
        
        /// <summary>
        /// The parentStructure__EventChannel property
        /// </summary>
        [XmlElementNameAttribute("parentStructure__EventChannel")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("eventChannel__ComposedStructure")]
        public virtual IComposedStructure ParentStructure__EventChannel
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
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EventChannelChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EventChannelReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//EventChanne" +
                        "l/");
            }
        }
        
        /// <summary>
        /// Gets fired when the ParentStructure__EventChannel property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ParentStructure__EventChannelChanged;
        
        /// <summary>
        /// Forwards change notifications for the EventPublisher property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventPublisherCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EventPublisher", e);
        }
        
        /// <summary>
        /// Raises the ParentStructure__EventChannelChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure__EventChannelChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ParentStructure__EventChannelChanged;
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
            IComposedStructure oldParentStructure__EventChannel = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure__EventChannel = ModelHelper.CastAs<IComposedStructure>(newParent);
            if ((oldParentStructure__EventChannel != null))
            {
                oldParentStructure__EventChannel.EventChannel__ComposedStructure.Remove(this);
            }
            if ((newParentStructure__EventChannel != null))
            {
                newParentStructure__EventChannel.EventChannel__ComposedStructure.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure__EventChannel, newParentStructure__EventChannel);
            this.OnParentStructure__EventChannelChanged(e);
            this.OnPropertyChanged("ParentStructure__EventChannel", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "EVENTPUBLISHER"))
            {
                return this._eventPublisher;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PARENTSTRUCTURE__EVENTCHANNEL"))
            {
                this.ParentStructure__EventChannel = ((IComposedStructure)(value));
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
            if ((attribute == "PARENTSTRUCTURE__EVENTCHANNEL"))
            {
                return new ParentStructure__EventChannelProxy(this);
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
            if ((reference == "PARENTSTRUCTURE__EVENTCHANNEL"))
            {
                return new ParentStructure__EventChannelProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//EventChanne" +
                    "l/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventChannel class
        /// </summary>
        public class EventChannelChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventChannel _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventChannelChildrenCollection(EventChannel parent)
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
                    count = (count + this._parent.EventPublisher.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EventPublisher.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EventPublisher.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEventPublisher eventPublisherCasted = item.As<IEventPublisher>();
                if ((eventPublisherCasted != null))
                {
                    this._parent.EventPublisher.Add(eventPublisherCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EventPublisher.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EventPublisher.Contains(item))
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
                IEnumerator<IModelElement> eventPublisherEnumerator = this._parent.EventPublisher.GetEnumerator();
                try
                {
                    for (
                    ; eventPublisherEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eventPublisherEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eventPublisherEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEventPublisher eventPublisherItem = item.As<IEventPublisher>();
                if (((eventPublisherItem != null) 
                            && this._parent.EventPublisher.Remove(eventPublisherItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EventPublisher).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventChannel class
        /// </summary>
        public class EventChannelReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventChannel _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventChannelReferencedElementsCollection(EventChannel parent)
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
                    count = (count + this._parent.EventPublisher.Count);
                    if ((this._parent.ParentStructure__EventChannel != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EventPublisher.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ParentStructure__EventChannelChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EventPublisher.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ParentStructure__EventChannelChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEventPublisher eventPublisherCasted = item.As<IEventPublisher>();
                if ((eventPublisherCasted != null))
                {
                    this._parent.EventPublisher.Add(eventPublisherCasted);
                }
                if ((this._parent.ParentStructure__EventChannel == null))
                {
                    IComposedStructure parentStructure__EventChannelCasted = item.As<IComposedStructure>();
                    if ((parentStructure__EventChannelCasted != null))
                    {
                        this._parent.ParentStructure__EventChannel = parentStructure__EventChannelCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EventPublisher.Clear();
                this._parent.ParentStructure__EventChannel = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EventPublisher.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.ParentStructure__EventChannel))
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
                IEnumerator<IModelElement> eventPublisherEnumerator = this._parent.EventPublisher.GetEnumerator();
                try
                {
                    for (
                    ; eventPublisherEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eventPublisherEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eventPublisherEnumerator.Dispose();
                }
                if ((this._parent.ParentStructure__EventChannel != null))
                {
                    array[arrayIndex] = this._parent.ParentStructure__EventChannel;
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
                IEventPublisher eventPublisherItem = item.As<IEventPublisher>();
                if (((eventPublisherItem != null) 
                            && this._parent.EventPublisher.Remove(eventPublisherItem)))
                {
                    return true;
                }
                if ((this._parent.ParentStructure__EventChannel == item))
                {
                    this._parent.ParentStructure__EventChannel = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EventPublisher).Concat(this._parent.ParentStructure__EventChannel).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parentStructure__EventChannel property
        /// </summary>
        private sealed class ParentStructure__EventChannelProxy : ModelPropertyChange<IEventChannel, IComposedStructure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentStructure__EventChannelProxy(IEventChannel modelElement) : 
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
                    return this.ModelElement.ParentStructure__EventChannel;
                }
                set
                {
                    this.ModelElement.ParentStructure__EventChannel = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure__EventChannelChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure__EventChannelChanged -= handler;
            }
        }
    }
}

