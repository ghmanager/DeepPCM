//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Identifier;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Units;
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

namespace GeneratedCode.Pcm.Resourcetype
{
    
    
    /// <summary>
    /// The default implementation of the SchedulingPolicy class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/ResourceType/5.0")]
    [XmlNamespacePrefixAttribute("resourcetype")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourcetype//SchedulingPolicy" +
        "/")]
    [DebuggerDisplayAttribute("SchedulingPolicy {Id}")]
    public class SchedulingPolicy : GeneratedCode.Pcm.Core.Entity.Entity, ISchedulingPolicy, IModelElement
    {
        
        /// <summary>
        /// The resourceRepository__SchedulingPolicy property
        /// </summary>
        [XmlElementNameAttribute("resourceRepository__SchedulingPolicy")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("schedulingPolicies__ResourceRepository")]
        public virtual IResourceRepository ResourceRepository__SchedulingPolicy
        {
            get
            {
                return ModelHelper.CastAs<IResourceRepository>(this.Parent);
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
                return base.ReferencedElements.Concat(new SchedulingPolicyReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourcetype//SchedulingPolicy" +
                        "/");
            }
        }
        
        /// <summary>
        /// Gets fired when the ResourceRepository__SchedulingPolicy property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ResourceRepository__SchedulingPolicyChanged;
        
        /// <summary>
        /// Raises the ResourceRepository__SchedulingPolicyChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceRepository__SchedulingPolicyChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ResourceRepository__SchedulingPolicyChanged;
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
            IResourceRepository oldResourceRepository__SchedulingPolicy = ModelHelper.CastAs<IResourceRepository>(oldParent);
            IResourceRepository newResourceRepository__SchedulingPolicy = ModelHelper.CastAs<IResourceRepository>(newParent);
            if ((oldResourceRepository__SchedulingPolicy != null))
            {
                oldResourceRepository__SchedulingPolicy.SchedulingPolicies__ResourceRepository.Remove(this);
            }
            if ((newResourceRepository__SchedulingPolicy != null))
            {
                newResourceRepository__SchedulingPolicy.SchedulingPolicies__ResourceRepository.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceRepository__SchedulingPolicy, newResourceRepository__SchedulingPolicy);
            this.OnResourceRepository__SchedulingPolicyChanged(e);
            this.OnPropertyChanged("ResourceRepository__SchedulingPolicy", e);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "RESOURCEREPOSITORY__SCHEDULINGPOLICY"))
            {
                this.ResourceRepository__SchedulingPolicy = ((IResourceRepository)(value));
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
            if ((attribute == "RESOURCEREPOSITORY__SCHEDULINGPOLICY"))
            {
                return new ResourceRepository__SchedulingPolicyProxy(this);
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
            if ((reference == "RESOURCEREPOSITORY__SCHEDULINGPOLICY"))
            {
                return new ResourceRepository__SchedulingPolicyProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourcetype//SchedulingPolicy" +
                    "/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SchedulingPolicy class
        /// </summary>
        public class SchedulingPolicyReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SchedulingPolicy _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SchedulingPolicyReferencedElementsCollection(SchedulingPolicy parent)
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
                    if ((this._parent.ResourceRepository__SchedulingPolicy != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceRepository__SchedulingPolicyChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceRepository__SchedulingPolicyChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ResourceRepository__SchedulingPolicy == null))
                {
                    IResourceRepository resourceRepository__SchedulingPolicyCasted = item.As<IResourceRepository>();
                    if ((resourceRepository__SchedulingPolicyCasted != null))
                    {
                        this._parent.ResourceRepository__SchedulingPolicy = resourceRepository__SchedulingPolicyCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceRepository__SchedulingPolicy = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ResourceRepository__SchedulingPolicy))
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
                if ((this._parent.ResourceRepository__SchedulingPolicy != null))
                {
                    array[arrayIndex] = this._parent.ResourceRepository__SchedulingPolicy;
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
                if ((this._parent.ResourceRepository__SchedulingPolicy == item))
                {
                    this._parent.ResourceRepository__SchedulingPolicy = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceRepository__SchedulingPolicy).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the resourceRepository__SchedulingPolicy property
        /// </summary>
        private sealed class ResourceRepository__SchedulingPolicyProxy : ModelPropertyChange<ISchedulingPolicy, IResourceRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceRepository__SchedulingPolicyProxy(ISchedulingPolicy modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceRepository Value
            {
                get
                {
                    return this.ModelElement.ResourceRepository__SchedulingPolicy;
                }
                set
                {
                    this.ModelElement.ResourceRepository__SchedulingPolicy = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceRepository__SchedulingPolicyChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceRepository__SchedulingPolicyChanged -= handler;
            }
        }
    }
}

