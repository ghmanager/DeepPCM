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
    /// The default implementation of the EventChannelArchitecture class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/Core/Composition/1.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//core//composition//EventChannelArchitec" +
        "ture/")]
    [DebuggerDisplayAttribute("EventChannelArchitecture {Name}")]
    public abstract class EventChannelArchitecture : Class, IEventChannelArchitecture, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EventSubscriber property
        /// </summary>
        private ObservableAssociationList<IAssemblyContext> _eventSubscriber;
        
        /// <summary>
        /// The backing field for the EventPublisher property
        /// </summary>
        private ObservableAssociationList<IEventPublisher> _eventPublisher;
        
        /// <summary>
        /// The backing field for the Id property
        /// </summary>
        private string _id;
        
        /// <summary>
        /// The backing field for the EntityName property
        /// </summary>
        private string _entityName = "aName";
        
        private static IClass _classInstance;
        
        public EventChannelArchitecture()
        {
            this._eventSubscriber = new ObservableAssociationList<IAssemblyContext>();
            this._eventSubscriber.CollectionChanging += this.EventSubscriberCollectionChanging;
            this._eventSubscriber.CollectionChanged += this.EventSubscriberCollectionChanged;
            this._eventPublisher = new ObservableAssociationList<IEventPublisher>();
            this._eventPublisher.CollectionChanging += this.EventPublisherCollectionChanging;
            this._eventPublisher.CollectionChanged += this.EventPublisherCollectionChanged;
        }
        
        /// <summary>
        /// The parentStructure__eventChannelArchitecture property
        /// </summary>
        [XmlElementNameAttribute("parentStructure__eventChannelArchitecture")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("eventChannelArchitecture__ComposedStructure")]
        public virtual IComposedStructure ParentStructure__eventChannelArchitecture
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
        /// The EventSubscriber property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IAssemblyContext> EventSubscriber
        {
            get
            {
                return this._eventSubscriber;
            }
        }
        
        /// <summary>
        /// The EventPublisher property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IEventPublisher> EventPublisher
        {
            get
            {
                return this._eventPublisher;
            }
        }
        
        /// <summary>
        /// The id property
        /// </summary>
        [XmlElementNameAttribute("id")]
        [IdAttribute()]
        [XmlAttributeAttribute(true)]
        public virtual string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if ((this._id != value))
                {
                    string old = this._id;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIdChanging(e);
                    this.OnPropertyChanging("Id", e);
                    this._id = value;
                    this.OnIdChanged(e);
                    this.OnPropertyChanged("Id", e);
                }
            }
        }
        
        /// <summary>
        /// The entityName property
        /// </summary>
        [DefaultValueAttribute("aName")]
        [XmlElementNameAttribute("entityName")]
        [XmlAttributeAttribute(true)]
        public virtual string EntityName
        {
            get
            {
                return this._entityName;
            }
            set
            {
                if ((this._entityName != value))
                {
                    string old = this._entityName;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEntityNameChanging(e);
                    this.OnPropertyChanging("EntityName", e);
                    this._entityName = value;
                    this.OnEntityNameChanged(e);
                    this.OnPropertyChanged("EntityName", e);
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
                return base.ReferencedElements.Concat(new EventChannelArchitectureReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//core//composition//EventChannelArchitec" +
                            "ture/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ParentStructure__eventChannelArchitecture property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ParentStructure__eventChannelArchitectureChanging;
        
        /// <summary>
        /// Gets fired when the ParentStructure__eventChannelArchitecture property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ParentStructure__eventChannelArchitectureChanged;
        
        /// <summary>
        /// Gets fired before the Id property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdChanging;
        
        /// <summary>
        /// Gets fired when the Id property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> IdChanged;
        
        /// <summary>
        /// Gets fired before the EntityName property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EntityNameChanging;
        
        /// <summary>
        /// Gets fired when the EntityName property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> EntityNameChanged;
        
        /// <summary>
        /// Gets the EventChannel for this model element
        /// </summary>
        public abstract IEventChannel GetEventChannel();
        
        /// <summary>
        /// Raises the ParentStructure__eventChannelArchitectureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure__eventChannelArchitectureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ParentStructure__eventChannelArchitectureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IComposedStructure oldParentStructure__eventChannelArchitecture = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure__eventChannelArchitecture = ModelHelper.CastAs<IComposedStructure>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure__eventChannelArchitecture, newParentStructure__eventChannelArchitecture);
            this.OnParentStructure__eventChannelArchitectureChanging(e);
            this.OnPropertyChanging("ParentStructure__eventChannelArchitecture");
        }
        
        /// <summary>
        /// Raises the ParentStructure__eventChannelArchitectureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure__eventChannelArchitectureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ParentStructure__eventChannelArchitectureChanged;
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
            IComposedStructure oldParentStructure__eventChannelArchitecture = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure__eventChannelArchitecture = ModelHelper.CastAs<IComposedStructure>(newParent);
            if ((oldParentStructure__eventChannelArchitecture != null))
            {
                oldParentStructure__eventChannelArchitecture.EventChannelArchitecture__ComposedStructure.Remove(this);
            }
            if ((newParentStructure__eventChannelArchitecture != null))
            {
                newParentStructure__eventChannelArchitecture.EventChannelArchitecture__ComposedStructure.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure__eventChannelArchitecture, newParentStructure__eventChannelArchitecture);
            this.OnParentStructure__eventChannelArchitectureChanged(e);
            this.OnPropertyChanged("ParentStructure__eventChannelArchitecture", e);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EventSubscriber property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventSubscriberCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("EventSubscriber", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EventSubscriber property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventSubscriberCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EventSubscriber", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EventPublisher property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventPublisherCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("EventPublisher", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EventPublisher property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventPublisherCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EventPublisher", e);
        }
        
        /// <summary>
        /// Raises the IdChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IdChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIdChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.IdChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EntityNameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEntityNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EntityNameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the EntityNameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEntityNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.EntityNameChanged;
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
            if ((attribute == "ID"))
            {
                return this.Id;
            }
            if ((attribute == "ENTITYNAME"))
            {
                return this.EntityName;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "EVENTSUBSCRIBER"))
            {
                return this._eventSubscriber;
            }
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
            if ((feature == "PARENTSTRUCTURE__EVENTCHANNELARCHITECTURE"))
            {
                this.ParentStructure__eventChannelArchitecture = ((IComposedStructure)(value));
                return;
            }
            if ((feature == "ID"))
            {
                this.Id = ((string)(value));
                return;
            }
            if ((feature == "ENTITYNAME"))
            {
                this.EntityName = ((string)(value));
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
            if ((attribute == "PARENTSTRUCTURE__EVENTCHANNELARCHITECTURE"))
            {
                return new ParentStructure__eventChannelArchitectureProxy(this);
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
            if ((reference == "PARENTSTRUCTURE__EVENTCHANNELARCHITECTURE"))
            {
                return new ParentStructure__eventChannelArchitectureProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public virtual IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//core//composition//EventChannelArchitec" +
                        "ture/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventChannelArchitecture class
        /// </summary>
        public class EventChannelArchitectureReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventChannelArchitecture _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventChannelArchitectureReferencedElementsCollection(EventChannelArchitecture parent)
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
                    if ((this._parent.ParentStructure__eventChannelArchitecture != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.EventSubscriber.Count);
                    count = (count + this._parent.EventPublisher.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParentStructure__eventChannelArchitectureChanged += this.PropagateValueChanges;
                this._parent.EventSubscriber.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.EventPublisher.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParentStructure__eventChannelArchitectureChanged -= this.PropagateValueChanges;
                this._parent.EventSubscriber.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.EventPublisher.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ParentStructure__eventChannelArchitecture == null))
                {
                    IComposedStructure parentStructure__eventChannelArchitectureCasted = item.As<IComposedStructure>();
                    if ((parentStructure__eventChannelArchitectureCasted != null))
                    {
                        this._parent.ParentStructure__eventChannelArchitecture = parentStructure__eventChannelArchitectureCasted;
                        return;
                    }
                }
                IAssemblyContext eventSubscriberCasted = item.As<IAssemblyContext>();
                if ((eventSubscriberCasted != null))
                {
                    this._parent.EventSubscriber.Add(eventSubscriberCasted);
                }
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
                this._parent.ParentStructure__eventChannelArchitecture = null;
                this._parent.EventSubscriber.Clear();
                this._parent.EventPublisher.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ParentStructure__eventChannelArchitecture))
                {
                    return true;
                }
                if (this._parent.EventSubscriber.Contains(item))
                {
                    return true;
                }
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
                if ((this._parent.ParentStructure__eventChannelArchitecture != null))
                {
                    array[arrayIndex] = this._parent.ParentStructure__eventChannelArchitecture;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> eventSubscriberEnumerator = this._parent.EventSubscriber.GetEnumerator();
                try
                {
                    for (
                    ; eventSubscriberEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eventSubscriberEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eventSubscriberEnumerator.Dispose();
                }
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
                if ((this._parent.ParentStructure__eventChannelArchitecture == item))
                {
                    this._parent.ParentStructure__eventChannelArchitecture = null;
                    return true;
                }
                IAssemblyContext assemblyContextItem = item.As<IAssemblyContext>();
                if (((assemblyContextItem != null) 
                            && this._parent.EventSubscriber.Remove(assemblyContextItem)))
                {
                    return true;
                }
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ParentStructure__eventChannelArchitecture).Concat(this._parent.EventSubscriber).Concat(this._parent.EventPublisher).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parentStructure__eventChannelArchitecture property
        /// </summary>
        private sealed class ParentStructure__eventChannelArchitectureProxy : ModelPropertyChange<IEventChannelArchitecture, IComposedStructure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentStructure__eventChannelArchitectureProxy(IEventChannelArchitecture modelElement) : 
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
                    return this.ModelElement.ParentStructure__eventChannelArchitecture;
                }
                set
                {
                    this.ModelElement.ParentStructure__eventChannelArchitecture = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure__eventChannelArchitectureChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure__eventChannelArchitectureChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the id property
        /// </summary>
        private sealed class IdProxy : ModelPropertyChange<IIdentifier, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IdProxy(IIdentifier modelElement) : 
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
                    return this.ModelElement.Id;
                }
                set
                {
                    this.ModelElement.Id = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IdChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IdChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the entityName property
        /// </summary>
        private sealed class EntityNameProxy : ModelPropertyChange<INamedElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EntityNameProxy(INamedElement modelElement) : 
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
                    return this.ModelElement.EntityName;
                }
                set
                {
                    this.ModelElement.EntityName = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EntityNameChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EntityNameChanged -= handler;
            }
        }
    }
}
