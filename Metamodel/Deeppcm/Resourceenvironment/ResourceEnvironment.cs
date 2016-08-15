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
using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Resourcetype;
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

namespace DeepPCM.Deeppcm.Resourceenvironment
{
    
    
    /// <summary>
    /// The default implementation of the ResourceEnvironment class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/ResourceEnvironment/5.0")]
    [XmlNamespacePrefixAttribute("resourceenvironment")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourceenvironment//ResourceE" +
        "nvironment/")]
    public class ResourceEnvironment : NamedElement, IResourceEnvironment, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LinkingResources__ResourceEnvironment property
        /// </summary>
        private ResourceEnvironmentLinkingResources__ResourceEnvironmentCollection _linkingResources__ResourceEnvironment;
        
        /// <summary>
        /// The backing field for the ResourceContainer_ResourceEnvironment property
        /// </summary>
        private ResourceEnvironmentResourceContainer_ResourceEnvironmentCollection _resourceContainer_ResourceEnvironment;
        
        public ResourceEnvironment()
        {
            this._linkingResources__ResourceEnvironment = new ResourceEnvironmentLinkingResources__ResourceEnvironmentCollection(this);
            this._linkingResources__ResourceEnvironment.CollectionChanged += this.LinkingResources__ResourceEnvironmentCollectionChanged;
            this._resourceContainer_ResourceEnvironment = new ResourceEnvironmentResourceContainer_ResourceEnvironmentCollection(this);
            this._resourceContainer_ResourceEnvironment.CollectionChanged += this.ResourceContainer_ResourceEnvironmentCollectionChanged;
        }
        
        /// <summary>
        /// The linkingResources__ResourceEnvironment property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("linkingResources__ResourceEnvironment")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceEnvironment_LinkingResource")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<ILinkingResource> LinkingResources__ResourceEnvironment
        {
            get
            {
                return this._linkingResources__ResourceEnvironment;
            }
        }
        
        /// <summary>
        /// The resourceContainer_ResourceEnvironment property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceContainer_ResourceEnvironment")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceEnvironment_ResourceContainer")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceContainer> ResourceContainer_ResourceEnvironment
        {
            get
            {
                return this._resourceContainer_ResourceEnvironment;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ResourceEnvironmentChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceEnvironmentReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourceenvironment//ResourceE" +
                        "nvironment/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the LinkingResources__ResourceEnvironment property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LinkingResources__ResourceEnvironmentCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LinkingResources__ResourceEnvironment", e);
        }
        
        /// <summary>
        /// Forwards change notifications for the ResourceContainer_ResourceEnvironment property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceContainer_ResourceEnvironmentCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceContainer_ResourceEnvironment", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LINKINGRESOURCES__RESOURCEENVIRONMENT"))
            {
                return this._linkingResources__ResourceEnvironment;
            }
            if ((feature == "RESOURCECONTAINER_RESOURCEENVIRONMENT"))
            {
                return this._resourceContainer_ResourceEnvironment;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//resourceenvironment//ResourceE" +
                    "nvironment/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceEnvironment class
        /// </summary>
        public class ResourceEnvironmentChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceEnvironment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceEnvironmentChildrenCollection(ResourceEnvironment parent)
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
                    count = (count + this._parent.LinkingResources__ResourceEnvironment.Count);
                    count = (count + this._parent.ResourceContainer_ResourceEnvironment.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LinkingResources__ResourceEnvironment.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceContainer_ResourceEnvironment.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LinkingResources__ResourceEnvironment.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceContainer_ResourceEnvironment.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ILinkingResource linkingResources__ResourceEnvironmentCasted = item.As<ILinkingResource>();
                if ((linkingResources__ResourceEnvironmentCasted != null))
                {
                    this._parent.LinkingResources__ResourceEnvironment.Add(linkingResources__ResourceEnvironmentCasted);
                }
                IResourceContainer resourceContainer_ResourceEnvironmentCasted = item.As<IResourceContainer>();
                if ((resourceContainer_ResourceEnvironmentCasted != null))
                {
                    this._parent.ResourceContainer_ResourceEnvironment.Add(resourceContainer_ResourceEnvironmentCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LinkingResources__ResourceEnvironment.Clear();
                this._parent.ResourceContainer_ResourceEnvironment.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.LinkingResources__ResourceEnvironment.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceContainer_ResourceEnvironment.Contains(item))
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
                IEnumerator<IModelElement> linkingResources__ResourceEnvironmentEnumerator = this._parent.LinkingResources__ResourceEnvironment.GetEnumerator();
                try
                {
                    for (
                    ; linkingResources__ResourceEnvironmentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = linkingResources__ResourceEnvironmentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    linkingResources__ResourceEnvironmentEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceContainer_ResourceEnvironmentEnumerator = this._parent.ResourceContainer_ResourceEnvironment.GetEnumerator();
                try
                {
                    for (
                    ; resourceContainer_ResourceEnvironmentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceContainer_ResourceEnvironmentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceContainer_ResourceEnvironmentEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ILinkingResource linkingResourceItem = item.As<ILinkingResource>();
                if (((linkingResourceItem != null) 
                            && this._parent.LinkingResources__ResourceEnvironment.Remove(linkingResourceItem)))
                {
                    return true;
                }
                IResourceContainer resourceContainerItem = item.As<IResourceContainer>();
                if (((resourceContainerItem != null) 
                            && this._parent.ResourceContainer_ResourceEnvironment.Remove(resourceContainerItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LinkingResources__ResourceEnvironment).Concat(this._parent.ResourceContainer_ResourceEnvironment).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceEnvironment class
        /// </summary>
        public class ResourceEnvironmentReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceEnvironment _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceEnvironmentReferencedElementsCollection(ResourceEnvironment parent)
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
                    count = (count + this._parent.LinkingResources__ResourceEnvironment.Count);
                    count = (count + this._parent.ResourceContainer_ResourceEnvironment.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LinkingResources__ResourceEnvironment.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceContainer_ResourceEnvironment.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LinkingResources__ResourceEnvironment.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceContainer_ResourceEnvironment.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ILinkingResource linkingResources__ResourceEnvironmentCasted = item.As<ILinkingResource>();
                if ((linkingResources__ResourceEnvironmentCasted != null))
                {
                    this._parent.LinkingResources__ResourceEnvironment.Add(linkingResources__ResourceEnvironmentCasted);
                }
                IResourceContainer resourceContainer_ResourceEnvironmentCasted = item.As<IResourceContainer>();
                if ((resourceContainer_ResourceEnvironmentCasted != null))
                {
                    this._parent.ResourceContainer_ResourceEnvironment.Add(resourceContainer_ResourceEnvironmentCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LinkingResources__ResourceEnvironment.Clear();
                this._parent.ResourceContainer_ResourceEnvironment.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.LinkingResources__ResourceEnvironment.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceContainer_ResourceEnvironment.Contains(item))
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
                IEnumerator<IModelElement> linkingResources__ResourceEnvironmentEnumerator = this._parent.LinkingResources__ResourceEnvironment.GetEnumerator();
                try
                {
                    for (
                    ; linkingResources__ResourceEnvironmentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = linkingResources__ResourceEnvironmentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    linkingResources__ResourceEnvironmentEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceContainer_ResourceEnvironmentEnumerator = this._parent.ResourceContainer_ResourceEnvironment.GetEnumerator();
                try
                {
                    for (
                    ; resourceContainer_ResourceEnvironmentEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceContainer_ResourceEnvironmentEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceContainer_ResourceEnvironmentEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ILinkingResource linkingResourceItem = item.As<ILinkingResource>();
                if (((linkingResourceItem != null) 
                            && this._parent.LinkingResources__ResourceEnvironment.Remove(linkingResourceItem)))
                {
                    return true;
                }
                IResourceContainer resourceContainerItem = item.As<IResourceContainer>();
                if (((resourceContainerItem != null) 
                            && this._parent.ResourceContainer_ResourceEnvironment.Remove(resourceContainerItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LinkingResources__ResourceEnvironment).Concat(this._parent.ResourceContainer_ResourceEnvironment).GetEnumerator();
            }
        }
    }
}

