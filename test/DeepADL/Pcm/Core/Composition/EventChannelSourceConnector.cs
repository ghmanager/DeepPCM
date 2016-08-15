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
    /// The default implementation of the EventChannelSourceConnector class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//EventChanne" +
        "lSourceConnector/")]
    [DebuggerDisplayAttribute("EventChannelSourceConnector {Id}")]
    public class EventChannelSourceConnector : Connector, IEventChannelSourceConnector, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SourceRole__EventChannelSourceRole property
        /// </summary>
        private ISourceRole _sourceRole__EventChannelSourceRole;
        
        /// <summary>
        /// The backing field for the AssemblyContext__EventChannelSourceConnector property
        /// </summary>
        private IAssemblyContext _assemblyContext__EventChannelSourceConnector;
        
        /// <summary>
        /// The backing field for the EventChannel__EventChannelSourceConnector property
        /// </summary>
        private IEventChannel _eventChannel__EventChannelSourceConnector;
        
        /// <summary>
        /// The sourceRole__EventChannelSourceRole property
        /// </summary>
        [XmlElementNameAttribute("sourceRole__EventChannelSourceRole")]
        [XmlAttributeAttribute(true)]
        public virtual ISourceRole SourceRole__EventChannelSourceRole
        {
            get
            {
                return this._sourceRole__EventChannelSourceRole;
            }
            set
            {
                if ((this._sourceRole__EventChannelSourceRole != value))
                {
                    ISourceRole old = this._sourceRole__EventChannelSourceRole;
                    this._sourceRole__EventChannelSourceRole = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSourceRole__EventChannelSourceRole;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSourceRole__EventChannelSourceRole;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSourceRole__EventChannelSourceRoleChanged(e);
                    this.OnPropertyChanged("SourceRole__EventChannelSourceRole", e);
                }
            }
        }
        
        /// <summary>
        /// The assemblyContext__EventChannelSourceConnector property
        /// </summary>
        [XmlElementNameAttribute("assemblyContext__EventChannelSourceConnector")]
        [XmlAttributeAttribute(true)]
        public virtual IAssemblyContext AssemblyContext__EventChannelSourceConnector
        {
            get
            {
                return this._assemblyContext__EventChannelSourceConnector;
            }
            set
            {
                if ((this._assemblyContext__EventChannelSourceConnector != value))
                {
                    IAssemblyContext old = this._assemblyContext__EventChannelSourceConnector;
                    this._assemblyContext__EventChannelSourceConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAssemblyContext__EventChannelSourceConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAssemblyContext__EventChannelSourceConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAssemblyContext__EventChannelSourceConnectorChanged(e);
                    this.OnPropertyChanged("AssemblyContext__EventChannelSourceConnector", e);
                }
            }
        }
        
        /// <summary>
        /// The eventChannel__EventChannelSourceConnector property
        /// </summary>
        [XmlElementNameAttribute("eventChannel__EventChannelSourceConnector")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("eventChannelSourceConnector__EventChannel")]
        public virtual IEventChannel EventChannel__EventChannelSourceConnector
        {
            get
            {
                return this._eventChannel__EventChannelSourceConnector;
            }
            set
            {
                if ((this._eventChannel__EventChannelSourceConnector != value))
                {
                    IEventChannel old = this._eventChannel__EventChannelSourceConnector;
                    this._eventChannel__EventChannelSourceConnector = value;
                    if ((old != null))
                    {
                        old.EventChannelSourceConnector__EventChannel.Remove(this);
                        old.Deleted -= this.OnResetEventChannel__EventChannelSourceConnector;
                    }
                    if ((value != null))
                    {
                        if ((value.EventChannelSourceConnector__EventChannel.Contains(this) != true))
                        {
                            value.EventChannelSourceConnector__EventChannel.Add(this);
                        }
                        value.Deleted += this.OnResetEventChannel__EventChannelSourceConnector;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEventChannel__EventChannelSourceConnectorChanged(e);
                    this.OnPropertyChanged("EventChannel__EventChannelSourceConnector", e);
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
                return base.ReferencedElements.Concat(new EventChannelSourceConnectorReferencedElementsCollection(this));
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
                        "lSourceConnector/");
            }
        }
        
        /// <summary>
        /// Gets fired when the SourceRole__EventChannelSourceRole property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SourceRole__EventChannelSourceRoleChanged;
        
        /// <summary>
        /// Gets fired when the AssemblyContext__EventChannelSourceConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> AssemblyContext__EventChannelSourceConnectorChanged;
        
        /// <summary>
        /// Gets fired when the EventChannel__EventChannelSourceConnector property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> EventChannel__EventChannelSourceConnectorChanged;
        
        /// <summary>
        /// Raises the SourceRole__EventChannelSourceRoleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSourceRole__EventChannelSourceRoleChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SourceRole__EventChannelSourceRoleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SourceRole__EventChannelSourceRole property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSourceRole__EventChannelSourceRole(object sender, EventArgs eventArgs)
        {
            this.SourceRole__EventChannelSourceRole = null;
        }
        
        /// <summary>
        /// Raises the AssemblyContext__EventChannelSourceConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext__EventChannelSourceConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext__EventChannelSourceConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AssemblyContext__EventChannelSourceConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAssemblyContext__EventChannelSourceConnector(object sender, EventArgs eventArgs)
        {
            this.AssemblyContext__EventChannelSourceConnector = null;
        }
        
        /// <summary>
        /// Raises the EventChannel__EventChannelSourceConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEventChannel__EventChannelSourceConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.EventChannel__EventChannelSourceConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EventChannel__EventChannelSourceConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEventChannel__EventChannelSourceConnector(object sender, EventArgs eventArgs)
        {
            this.EventChannel__EventChannelSourceConnector = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SOURCEROLE__EVENTCHANNELSOURCEROLE"))
            {
                this.SourceRole__EventChannelSourceRole = ((ISourceRole)(value));
                return;
            }
            if ((feature == "ASSEMBLYCONTEXT__EVENTCHANNELSOURCECONNECTOR"))
            {
                this.AssemblyContext__EventChannelSourceConnector = ((IAssemblyContext)(value));
                return;
            }
            if ((feature == "EVENTCHANNEL__EVENTCHANNELSOURCECONNECTOR"))
            {
                this.EventChannel__EventChannelSourceConnector = ((IEventChannel)(value));
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
            if ((attribute == "SOURCEROLE__EVENTCHANNELSOURCEROLE"))
            {
                return new SourceRole__EventChannelSourceRoleProxy(this);
            }
            if ((attribute == "ASSEMBLYCONTEXT__EVENTCHANNELSOURCECONNECTOR"))
            {
                return new AssemblyContext__EventChannelSourceConnectorProxy(this);
            }
            if ((attribute == "EVENTCHANNEL__EVENTCHANNELSOURCECONNECTOR"))
            {
                return new EventChannel__EventChannelSourceConnectorProxy(this);
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
            if ((reference == "SOURCEROLE__EVENTCHANNELSOURCEROLE"))
            {
                return new SourceRole__EventChannelSourceRoleProxy(this);
            }
            if ((reference == "ASSEMBLYCONTEXT__EVENTCHANNELSOURCECONNECTOR"))
            {
                return new AssemblyContext__EventChannelSourceConnectorProxy(this);
            }
            if ((reference == "EVENTCHANNEL__EVENTCHANNELSOURCECONNECTOR"))
            {
                return new EventChannel__EventChannelSourceConnectorProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//EventChanne" +
                    "lSourceConnector/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventChannelSourceConnector class
        /// </summary>
        public class EventChannelSourceConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventChannelSourceConnector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventChannelSourceConnectorReferencedElementsCollection(EventChannelSourceConnector parent)
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
                    if ((this._parent.SourceRole__EventChannelSourceRole != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AssemblyContext__EventChannelSourceConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.EventChannel__EventChannelSourceConnector != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SourceRole__EventChannelSourceRoleChanged += this.PropagateValueChanges;
                this._parent.AssemblyContext__EventChannelSourceConnectorChanged += this.PropagateValueChanges;
                this._parent.EventChannel__EventChannelSourceConnectorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SourceRole__EventChannelSourceRoleChanged -= this.PropagateValueChanges;
                this._parent.AssemblyContext__EventChannelSourceConnectorChanged -= this.PropagateValueChanges;
                this._parent.EventChannel__EventChannelSourceConnectorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.SourceRole__EventChannelSourceRole == null))
                {
                    ISourceRole sourceRole__EventChannelSourceRoleCasted = item.As<ISourceRole>();
                    if ((sourceRole__EventChannelSourceRoleCasted != null))
                    {
                        this._parent.SourceRole__EventChannelSourceRole = sourceRole__EventChannelSourceRoleCasted;
                        return;
                    }
                }
                if ((this._parent.AssemblyContext__EventChannelSourceConnector == null))
                {
                    IAssemblyContext assemblyContext__EventChannelSourceConnectorCasted = item.As<IAssemblyContext>();
                    if ((assemblyContext__EventChannelSourceConnectorCasted != null))
                    {
                        this._parent.AssemblyContext__EventChannelSourceConnector = assemblyContext__EventChannelSourceConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.EventChannel__EventChannelSourceConnector == null))
                {
                    IEventChannel eventChannel__EventChannelSourceConnectorCasted = item.As<IEventChannel>();
                    if ((eventChannel__EventChannelSourceConnectorCasted != null))
                    {
                        this._parent.EventChannel__EventChannelSourceConnector = eventChannel__EventChannelSourceConnectorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SourceRole__EventChannelSourceRole = null;
                this._parent.AssemblyContext__EventChannelSourceConnector = null;
                this._parent.EventChannel__EventChannelSourceConnector = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.SourceRole__EventChannelSourceRole))
                {
                    return true;
                }
                if ((item == this._parent.AssemblyContext__EventChannelSourceConnector))
                {
                    return true;
                }
                if ((item == this._parent.EventChannel__EventChannelSourceConnector))
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
                if ((this._parent.SourceRole__EventChannelSourceRole != null))
                {
                    array[arrayIndex] = this._parent.SourceRole__EventChannelSourceRole;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AssemblyContext__EventChannelSourceConnector != null))
                {
                    array[arrayIndex] = this._parent.AssemblyContext__EventChannelSourceConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.EventChannel__EventChannelSourceConnector != null))
                {
                    array[arrayIndex] = this._parent.EventChannel__EventChannelSourceConnector;
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
                if ((this._parent.SourceRole__EventChannelSourceRole == item))
                {
                    this._parent.SourceRole__EventChannelSourceRole = null;
                    return true;
                }
                if ((this._parent.AssemblyContext__EventChannelSourceConnector == item))
                {
                    this._parent.AssemblyContext__EventChannelSourceConnector = null;
                    return true;
                }
                if ((this._parent.EventChannel__EventChannelSourceConnector == item))
                {
                    this._parent.EventChannel__EventChannelSourceConnector = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SourceRole__EventChannelSourceRole).Concat(this._parent.AssemblyContext__EventChannelSourceConnector).Concat(this._parent.EventChannel__EventChannelSourceConnector).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the sourceRole__EventChannelSourceRole property
        /// </summary>
        private sealed class SourceRole__EventChannelSourceRoleProxy : ModelPropertyChange<IEventChannelSourceConnector, ISourceRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SourceRole__EventChannelSourceRoleProxy(IEventChannelSourceConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISourceRole Value
            {
                get
                {
                    return this.ModelElement.SourceRole__EventChannelSourceRole;
                }
                set
                {
                    this.ModelElement.SourceRole__EventChannelSourceRole = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SourceRole__EventChannelSourceRoleChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SourceRole__EventChannelSourceRoleChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the assemblyContext__EventChannelSourceConnector property
        /// </summary>
        private sealed class AssemblyContext__EventChannelSourceConnectorProxy : ModelPropertyChange<IEventChannelSourceConnector, IAssemblyContext>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AssemblyContext__EventChannelSourceConnectorProxy(IEventChannelSourceConnector modelElement) : 
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
                    return this.ModelElement.AssemblyContext__EventChannelSourceConnector;
                }
                set
                {
                    this.ModelElement.AssemblyContext__EventChannelSourceConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AssemblyContext__EventChannelSourceConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AssemblyContext__EventChannelSourceConnectorChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the eventChannel__EventChannelSourceConnector property
        /// </summary>
        private sealed class EventChannel__EventChannelSourceConnectorProxy : ModelPropertyChange<IEventChannelSourceConnector, IEventChannel>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EventChannel__EventChannelSourceConnectorProxy(IEventChannelSourceConnector modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IEventChannel Value
            {
                get
                {
                    return this.ModelElement.EventChannel__EventChannelSourceConnector;
                }
                set
                {
                    this.ModelElement.EventChannel__EventChannelSourceConnector = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EventChannel__EventChannelSourceConnectorChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EventChannel__EventChannelSourceConnectorChanged -= handler;
            }
        }
    }
}
