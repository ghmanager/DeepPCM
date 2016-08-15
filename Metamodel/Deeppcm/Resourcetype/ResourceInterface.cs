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
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Identifier;
using DeepPCM.Units;
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

namespace DeepPCM.Deeppcm.Resourcetype
{
    
    
    /// <summary>
    /// The default implementation of the ResourceInterface class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/ResourceType/5.0")]
    [XmlNamespacePrefixAttribute("resourcetype")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourcetype//ResourceInterfac" +
        "e/")]
    [DebuggerDisplayAttribute("ResourceInterface {Id}")]
    public class ResourceInterface : DeepPCM.Deeppcm.Core.Entity.Entity, IResourceInterface, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceSignatures__ResourceInterface property
        /// </summary>
        private ResourceInterfaceResourceSignatures__ResourceInterfaceCollection _resourceSignatures__ResourceInterface;
        
        public ResourceInterface()
        {
            this._resourceSignatures__ResourceInterface = new ResourceInterfaceResourceSignatures__ResourceInterfaceCollection(this);
            this._resourceSignatures__ResourceInterface.CollectionChanged += this.ResourceSignatures__ResourceInterfaceCollectionChanged;
        }
        
        /// <summary>
        /// The resourceRepository__ResourceInterface property
        /// </summary>
        [XmlElementNameAttribute("resourceRepository__ResourceInterface")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("resourceInterfaces__ResourceRepository")]
        public virtual IResourceRepository ResourceRepository__ResourceInterface
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
        /// The resourceSignatures__ResourceInterface property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceSignatures__ResourceInterface")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceInterface__ResourceSignature")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceSignature> ResourceSignatures__ResourceInterface
        {
            get
            {
                return this._resourceSignatures__ResourceInterface;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ResourceInterfaceChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceInterfaceReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourcetype//ResourceInterfac" +
                        "e/");
            }
        }
        
        /// <summary>
        /// Gets fired when the ResourceRepository__ResourceInterface property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ResourceRepository__ResourceInterfaceChanged;
        
        /// <summary>
        /// Raises the ResourceRepository__ResourceInterfaceChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceRepository__ResourceInterfaceChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ResourceRepository__ResourceInterfaceChanged;
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
            IResourceRepository oldResourceRepository__ResourceInterface = ModelHelper.CastAs<IResourceRepository>(oldParent);
            IResourceRepository newResourceRepository__ResourceInterface = ModelHelper.CastAs<IResourceRepository>(newParent);
            if ((oldResourceRepository__ResourceInterface != null))
            {
                oldResourceRepository__ResourceInterface.ResourceInterfaces__ResourceRepository.Remove(this);
            }
            if ((newResourceRepository__ResourceInterface != null))
            {
                newResourceRepository__ResourceInterface.ResourceInterfaces__ResourceRepository.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceRepository__ResourceInterface, newResourceRepository__ResourceInterface);
            this.OnResourceRepository__ResourceInterfaceChanged(e);
            this.OnPropertyChanged("ResourceRepository__ResourceInterface", e);
        }
        
        /// <summary>
        /// Forwards change notifications for the ResourceSignatures__ResourceInterface property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceSignatures__ResourceInterfaceCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceSignatures__ResourceInterface", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RESOURCESIGNATURES__RESOURCEINTERFACE"))
            {
                return this._resourceSignatures__ResourceInterface;
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
            if ((feature == "RESOURCEREPOSITORY__RESOURCEINTERFACE"))
            {
                this.ResourceRepository__ResourceInterface = ((IResourceRepository)(value));
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
            if ((attribute == "RESOURCEREPOSITORY__RESOURCEINTERFACE"))
            {
                return new ResourceRepository__ResourceInterfaceProxy(this);
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
            if ((reference == "RESOURCEREPOSITORY__RESOURCEINTERFACE"))
            {
                return new ResourceRepository__ResourceInterfaceProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourcetype//ResourceInterfac" +
                    "e/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceInterface class
        /// </summary>
        public class ResourceInterfaceChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceInterface _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceInterfaceChildrenCollection(ResourceInterface parent)
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
                    count = (count + this._parent.ResourceSignatures__ResourceInterface.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceSignatures__ResourceInterface.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceSignatures__ResourceInterface.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IResourceSignature resourceSignatures__ResourceInterfaceCasted = item.As<IResourceSignature>();
                if ((resourceSignatures__ResourceInterfaceCasted != null))
                {
                    this._parent.ResourceSignatures__ResourceInterface.Add(resourceSignatures__ResourceInterfaceCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceSignatures__ResourceInterface.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceSignatures__ResourceInterface.Contains(item))
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
                IEnumerator<IModelElement> resourceSignatures__ResourceInterfaceEnumerator = this._parent.ResourceSignatures__ResourceInterface.GetEnumerator();
                try
                {
                    for (
                    ; resourceSignatures__ResourceInterfaceEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceSignatures__ResourceInterfaceEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceSignatures__ResourceInterfaceEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IResourceSignature resourceSignatureItem = item.As<IResourceSignature>();
                if (((resourceSignatureItem != null) 
                            && this._parent.ResourceSignatures__ResourceInterface.Remove(resourceSignatureItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceSignatures__ResourceInterface).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceInterface class
        /// </summary>
        public class ResourceInterfaceReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceInterface _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceInterfaceReferencedElementsCollection(ResourceInterface parent)
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
                    if ((this._parent.ResourceRepository__ResourceInterface != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.ResourceSignatures__ResourceInterface.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceRepository__ResourceInterfaceChanged += this.PropagateValueChanges;
                this._parent.ResourceSignatures__ResourceInterface.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceRepository__ResourceInterfaceChanged -= this.PropagateValueChanges;
                this._parent.ResourceSignatures__ResourceInterface.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ResourceRepository__ResourceInterface == null))
                {
                    IResourceRepository resourceRepository__ResourceInterfaceCasted = item.As<IResourceRepository>();
                    if ((resourceRepository__ResourceInterfaceCasted != null))
                    {
                        this._parent.ResourceRepository__ResourceInterface = resourceRepository__ResourceInterfaceCasted;
                        return;
                    }
                }
                IResourceSignature resourceSignatures__ResourceInterfaceCasted = item.As<IResourceSignature>();
                if ((resourceSignatures__ResourceInterfaceCasted != null))
                {
                    this._parent.ResourceSignatures__ResourceInterface.Add(resourceSignatures__ResourceInterfaceCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceRepository__ResourceInterface = null;
                this._parent.ResourceSignatures__ResourceInterface.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ResourceRepository__ResourceInterface))
                {
                    return true;
                }
                if (this._parent.ResourceSignatures__ResourceInterface.Contains(item))
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
                if ((this._parent.ResourceRepository__ResourceInterface != null))
                {
                    array[arrayIndex] = this._parent.ResourceRepository__ResourceInterface;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> resourceSignatures__ResourceInterfaceEnumerator = this._parent.ResourceSignatures__ResourceInterface.GetEnumerator();
                try
                {
                    for (
                    ; resourceSignatures__ResourceInterfaceEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceSignatures__ResourceInterfaceEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceSignatures__ResourceInterfaceEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ResourceRepository__ResourceInterface == item))
                {
                    this._parent.ResourceRepository__ResourceInterface = null;
                    return true;
                }
                IResourceSignature resourceSignatureItem = item.As<IResourceSignature>();
                if (((resourceSignatureItem != null) 
                            && this._parent.ResourceSignatures__ResourceInterface.Remove(resourceSignatureItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceRepository__ResourceInterface).Concat(this._parent.ResourceSignatures__ResourceInterface).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the resourceRepository__ResourceInterface property
        /// </summary>
        private sealed class ResourceRepository__ResourceInterfaceProxy : ModelPropertyChange<IResourceInterface, IResourceRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceRepository__ResourceInterfaceProxy(IResourceInterface modelElement) : 
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
                    return this.ModelElement.ResourceRepository__ResourceInterface;
                }
                set
                {
                    this.ModelElement.ResourceRepository__ResourceInterface = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceRepository__ResourceInterfaceChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceRepository__ResourceInterfaceChanged -= handler;
            }
        }
    }
}
