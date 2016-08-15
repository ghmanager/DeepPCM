//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Composition;
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.Identifier;
using Metamodel.Units;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Resourcetype
{
    
    
    /// <summary>
    /// The default implementation of the ResourceRepository class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/ResourceType/1.0")]
    [XmlNamespacePrefixAttribute("resourcetype")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//resourcetype//ResourceRepository/")]
    public class ResourceRepository : ModelElement, IResourceRepository, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceInterfaces__ResourceRepository property
        /// </summary>
        private ResourceRepositoryResourceInterfaces__ResourceRepositoryCollection _resourceInterfaces__ResourceRepository;
        
        /// <summary>
        /// The backing field for the SchedulingPolicies__ResourceRepository property
        /// </summary>
        private ResourceRepositorySchedulingPolicies__ResourceRepositoryCollection _schedulingPolicies__ResourceRepository;
        
        /// <summary>
        /// The backing field for the AvailableResourceTypes_ResourceRepository property
        /// </summary>
        private ResourceRepositoryAvailableResourceTypes_ResourceRepositoryCollection _availableResourceTypes_ResourceRepository;
        
        /// <summary>
        /// The backing field for the ResourceDelegate__ResourceRepository property
        /// </summary>
        private ResourceRepositoryResourceDelegate__ResourceRepositoryCollection _resourceDelegate__ResourceRepository;
        
        private static IClass _classInstance;
        
        public ResourceRepository()
        {
            this._resourceInterfaces__ResourceRepository = new ResourceRepositoryResourceInterfaces__ResourceRepositoryCollection(this);
            this._resourceInterfaces__ResourceRepository.CollectionChanging += this.ResourceInterfaces__ResourceRepositoryCollectionChanging;
            this._resourceInterfaces__ResourceRepository.CollectionChanged += this.ResourceInterfaces__ResourceRepositoryCollectionChanged;
            this._schedulingPolicies__ResourceRepository = new ResourceRepositorySchedulingPolicies__ResourceRepositoryCollection(this);
            this._schedulingPolicies__ResourceRepository.CollectionChanging += this.SchedulingPolicies__ResourceRepositoryCollectionChanging;
            this._schedulingPolicies__ResourceRepository.CollectionChanged += this.SchedulingPolicies__ResourceRepositoryCollectionChanged;
            this._availableResourceTypes_ResourceRepository = new ResourceRepositoryAvailableResourceTypes_ResourceRepositoryCollection(this);
            this._availableResourceTypes_ResourceRepository.CollectionChanging += this.AvailableResourceTypes_ResourceRepositoryCollectionChanging;
            this._availableResourceTypes_ResourceRepository.CollectionChanged += this.AvailableResourceTypes_ResourceRepositoryCollectionChanged;
            this._resourceDelegate__ResourceRepository = new ResourceRepositoryResourceDelegate__ResourceRepositoryCollection(this);
            this._resourceDelegate__ResourceRepository.CollectionChanging += this.ResourceDelegate__ResourceRepositoryCollectionChanging;
            this._resourceDelegate__ResourceRepository.CollectionChanged += this.ResourceDelegate__ResourceRepositoryCollectionChanged;
        }
        
        /// <summary>
        /// The resourceInterfaces__ResourceRepository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceInterfaces__ResourceRepository")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceRepository__ResourceInterface")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceInterface> ResourceInterfaces__ResourceRepository
        {
            get
            {
                return this._resourceInterfaces__ResourceRepository;
            }
        }
        
        /// <summary>
        /// The schedulingPolicies__ResourceRepository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("schedulingPolicies__ResourceRepository")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceRepository__SchedulingPolicy")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<ISchedulingPolicy> SchedulingPolicies__ResourceRepository
        {
            get
            {
                return this._schedulingPolicies__ResourceRepository;
            }
        }
        
        /// <summary>
        /// The availableResourceTypes_ResourceRepository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("availableResourceTypes_ResourceRepository")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceRepository_ResourceType")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceType> AvailableResourceTypes_ResourceRepository
        {
            get
            {
                return this._availableResourceTypes_ResourceRepository;
            }
        }
        
        /// <summary>
        /// The resourceDelegate__ResourceRepository property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceDelegate__ResourceRepository")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceRepository__ResourceDelegate")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceDelegate> ResourceDelegate__ResourceRepository
        {
            get
            {
                return this._resourceDelegate__ResourceRepository;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ResourceRepositoryChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceRepositoryReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//resourcetype//ResourceRepository/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ResourceInterfaces__ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceInterfaces__ResourceRepositoryCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ResourceInterfaces__ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ResourceInterfaces__ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceInterfaces__ResourceRepositoryCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceInterfaces__ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the SchedulingPolicies__ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SchedulingPolicies__ResourceRepositoryCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("SchedulingPolicies__ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the SchedulingPolicies__ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SchedulingPolicies__ResourceRepositoryCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("SchedulingPolicies__ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AvailableResourceTypes_ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AvailableResourceTypes_ResourceRepositoryCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("AvailableResourceTypes_ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AvailableResourceTypes_ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AvailableResourceTypes_ResourceRepositoryCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AvailableResourceTypes_ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ResourceDelegate__ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceDelegate__ResourceRepositoryCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ResourceDelegate__ResourceRepository", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ResourceDelegate__ResourceRepository property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceDelegate__ResourceRepositoryCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceDelegate__ResourceRepository", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RESOURCEINTERFACES__RESOURCEREPOSITORY"))
            {
                return this._resourceInterfaces__ResourceRepository;
            }
            if ((feature == "SCHEDULINGPOLICIES__RESOURCEREPOSITORY"))
            {
                return this._schedulingPolicies__ResourceRepository;
            }
            if ((feature == "AVAILABLERESOURCETYPES_RESOURCEREPOSITORY"))
            {
                return this._availableResourceTypes_ResourceRepository;
            }
            if ((feature == "RESOURCEDELEGATE__RESOURCEREPOSITORY"))
            {
                return this._resourceDelegate__ResourceRepository;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//resourcetype//ResourceRepository/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceRepository class
        /// </summary>
        public class ResourceRepositoryChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceRepository _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceRepositoryChildrenCollection(ResourceRepository parent)
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
                    count = (count + this._parent.ResourceInterfaces__ResourceRepository.Count);
                    count = (count + this._parent.SchedulingPolicies__ResourceRepository.Count);
                    count = (count + this._parent.AvailableResourceTypes_ResourceRepository.Count);
                    count = (count + this._parent.ResourceDelegate__ResourceRepository.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceInterfaces__ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.SchedulingPolicies__ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.AvailableResourceTypes_ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceDelegate__ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceInterfaces__ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.SchedulingPolicies__ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.AvailableResourceTypes_ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceDelegate__ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IResourceInterface resourceInterfaces__ResourceRepositoryCasted = item.As<IResourceInterface>();
                if ((resourceInterfaces__ResourceRepositoryCasted != null))
                {
                    this._parent.ResourceInterfaces__ResourceRepository.Add(resourceInterfaces__ResourceRepositoryCasted);
                }
                ISchedulingPolicy schedulingPolicies__ResourceRepositoryCasted = item.As<ISchedulingPolicy>();
                if ((schedulingPolicies__ResourceRepositoryCasted != null))
                {
                    this._parent.SchedulingPolicies__ResourceRepository.Add(schedulingPolicies__ResourceRepositoryCasted);
                }
                IResourceType availableResourceTypes_ResourceRepositoryCasted = item.As<IResourceType>();
                if ((availableResourceTypes_ResourceRepositoryCasted != null))
                {
                    this._parent.AvailableResourceTypes_ResourceRepository.Add(availableResourceTypes_ResourceRepositoryCasted);
                }
                IResourceDelegate resourceDelegate__ResourceRepositoryCasted = item.As<IResourceDelegate>();
                if ((resourceDelegate__ResourceRepositoryCasted != null))
                {
                    this._parent.ResourceDelegate__ResourceRepository.Add(resourceDelegate__ResourceRepositoryCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceInterfaces__ResourceRepository.Clear();
                this._parent.SchedulingPolicies__ResourceRepository.Clear();
                this._parent.AvailableResourceTypes_ResourceRepository.Clear();
                this._parent.ResourceDelegate__ResourceRepository.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceInterfaces__ResourceRepository.Contains(item))
                {
                    return true;
                }
                if (this._parent.SchedulingPolicies__ResourceRepository.Contains(item))
                {
                    return true;
                }
                if (this._parent.AvailableResourceTypes_ResourceRepository.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceDelegate__ResourceRepository.Contains(item))
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
                IEnumerator<IModelElement> resourceInterfaces__ResourceRepositoryEnumerator = this._parent.ResourceInterfaces__ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; resourceInterfaces__ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceInterfaces__ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceInterfaces__ResourceRepositoryEnumerator.Dispose();
                }
                IEnumerator<IModelElement> schedulingPolicies__ResourceRepositoryEnumerator = this._parent.SchedulingPolicies__ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; schedulingPolicies__ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = schedulingPolicies__ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    schedulingPolicies__ResourceRepositoryEnumerator.Dispose();
                }
                IEnumerator<IModelElement> availableResourceTypes_ResourceRepositoryEnumerator = this._parent.AvailableResourceTypes_ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; availableResourceTypes_ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = availableResourceTypes_ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    availableResourceTypes_ResourceRepositoryEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceDelegate__ResourceRepositoryEnumerator = this._parent.ResourceDelegate__ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; resourceDelegate__ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceDelegate__ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceDelegate__ResourceRepositoryEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IResourceInterface resourceInterfaceItem = item.As<IResourceInterface>();
                if (((resourceInterfaceItem != null) 
                            && this._parent.ResourceInterfaces__ResourceRepository.Remove(resourceInterfaceItem)))
                {
                    return true;
                }
                ISchedulingPolicy schedulingPolicyItem = item.As<ISchedulingPolicy>();
                if (((schedulingPolicyItem != null) 
                            && this._parent.SchedulingPolicies__ResourceRepository.Remove(schedulingPolicyItem)))
                {
                    return true;
                }
                IResourceType resourceTypeItem = item.As<IResourceType>();
                if (((resourceTypeItem != null) 
                            && this._parent.AvailableResourceTypes_ResourceRepository.Remove(resourceTypeItem)))
                {
                    return true;
                }
                IResourceDelegate resourceDelegateItem = item.As<IResourceDelegate>();
                if (((resourceDelegateItem != null) 
                            && this._parent.ResourceDelegate__ResourceRepository.Remove(resourceDelegateItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceInterfaces__ResourceRepository).Concat(this._parent.SchedulingPolicies__ResourceRepository).Concat(this._parent.AvailableResourceTypes_ResourceRepository).Concat(this._parent.ResourceDelegate__ResourceRepository).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceRepository class
        /// </summary>
        public class ResourceRepositoryReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceRepository _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceRepositoryReferencedElementsCollection(ResourceRepository parent)
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
                    count = (count + this._parent.ResourceInterfaces__ResourceRepository.Count);
                    count = (count + this._parent.SchedulingPolicies__ResourceRepository.Count);
                    count = (count + this._parent.AvailableResourceTypes_ResourceRepository.Count);
                    count = (count + this._parent.ResourceDelegate__ResourceRepository.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceInterfaces__ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.SchedulingPolicies__ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.AvailableResourceTypes_ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceDelegate__ResourceRepository.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceInterfaces__ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.SchedulingPolicies__ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.AvailableResourceTypes_ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceDelegate__ResourceRepository.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IResourceInterface resourceInterfaces__ResourceRepositoryCasted = item.As<IResourceInterface>();
                if ((resourceInterfaces__ResourceRepositoryCasted != null))
                {
                    this._parent.ResourceInterfaces__ResourceRepository.Add(resourceInterfaces__ResourceRepositoryCasted);
                }
                ISchedulingPolicy schedulingPolicies__ResourceRepositoryCasted = item.As<ISchedulingPolicy>();
                if ((schedulingPolicies__ResourceRepositoryCasted != null))
                {
                    this._parent.SchedulingPolicies__ResourceRepository.Add(schedulingPolicies__ResourceRepositoryCasted);
                }
                IResourceType availableResourceTypes_ResourceRepositoryCasted = item.As<IResourceType>();
                if ((availableResourceTypes_ResourceRepositoryCasted != null))
                {
                    this._parent.AvailableResourceTypes_ResourceRepository.Add(availableResourceTypes_ResourceRepositoryCasted);
                }
                IResourceDelegate resourceDelegate__ResourceRepositoryCasted = item.As<IResourceDelegate>();
                if ((resourceDelegate__ResourceRepositoryCasted != null))
                {
                    this._parent.ResourceDelegate__ResourceRepository.Add(resourceDelegate__ResourceRepositoryCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceInterfaces__ResourceRepository.Clear();
                this._parent.SchedulingPolicies__ResourceRepository.Clear();
                this._parent.AvailableResourceTypes_ResourceRepository.Clear();
                this._parent.ResourceDelegate__ResourceRepository.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceInterfaces__ResourceRepository.Contains(item))
                {
                    return true;
                }
                if (this._parent.SchedulingPolicies__ResourceRepository.Contains(item))
                {
                    return true;
                }
                if (this._parent.AvailableResourceTypes_ResourceRepository.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceDelegate__ResourceRepository.Contains(item))
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
                IEnumerator<IModelElement> resourceInterfaces__ResourceRepositoryEnumerator = this._parent.ResourceInterfaces__ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; resourceInterfaces__ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceInterfaces__ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceInterfaces__ResourceRepositoryEnumerator.Dispose();
                }
                IEnumerator<IModelElement> schedulingPolicies__ResourceRepositoryEnumerator = this._parent.SchedulingPolicies__ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; schedulingPolicies__ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = schedulingPolicies__ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    schedulingPolicies__ResourceRepositoryEnumerator.Dispose();
                }
                IEnumerator<IModelElement> availableResourceTypes_ResourceRepositoryEnumerator = this._parent.AvailableResourceTypes_ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; availableResourceTypes_ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = availableResourceTypes_ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    availableResourceTypes_ResourceRepositoryEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceDelegate__ResourceRepositoryEnumerator = this._parent.ResourceDelegate__ResourceRepository.GetEnumerator();
                try
                {
                    for (
                    ; resourceDelegate__ResourceRepositoryEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceDelegate__ResourceRepositoryEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceDelegate__ResourceRepositoryEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IResourceInterface resourceInterfaceItem = item.As<IResourceInterface>();
                if (((resourceInterfaceItem != null) 
                            && this._parent.ResourceInterfaces__ResourceRepository.Remove(resourceInterfaceItem)))
                {
                    return true;
                }
                ISchedulingPolicy schedulingPolicyItem = item.As<ISchedulingPolicy>();
                if (((schedulingPolicyItem != null) 
                            && this._parent.SchedulingPolicies__ResourceRepository.Remove(schedulingPolicyItem)))
                {
                    return true;
                }
                IResourceType resourceTypeItem = item.As<IResourceType>();
                if (((resourceTypeItem != null) 
                            && this._parent.AvailableResourceTypes_ResourceRepository.Remove(resourceTypeItem)))
                {
                    return true;
                }
                IResourceDelegate resourceDelegateItem = item.As<IResourceDelegate>();
                if (((resourceDelegateItem != null) 
                            && this._parent.ResourceDelegate__ResourceRepository.Remove(resourceDelegateItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceInterfaces__ResourceRepository).Concat(this._parent.SchedulingPolicies__ResourceRepository).Concat(this._parent.AvailableResourceTypes_ResourceRepository).Concat(this._parent.ResourceDelegate__ResourceRepository).GetEnumerator();
            }
        }
    }
}

