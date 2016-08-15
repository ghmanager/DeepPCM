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
using GeneratedCode.Pcm.Core.Composition;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Resourcetype;
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

namespace GeneratedCode.Pcm.Core.Entity
{
    
    
    /// <summary>
    /// The default implementation of the ResourceInterfaceRequiringEntity class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Entity/5.0")]
    [XmlNamespacePrefixAttribute("entity")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceInterfac" +
        "eRequiringEntity/")]
    [DebuggerDisplayAttribute("ResourceInterfaceRequiringEntity {Id}")]
    public class ResourceInterfaceRequiringEntity : GeneratedCode.Pcm.Core.Entity.Entity, IResourceInterfaceRequiringEntity, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceRequiredRoles__ResourceInterfaceRequiringEntity property
        /// </summary>
        private ResourceInterfaceRequiringEntityResourceRequiredRoles__ResourceInterfaceRequiringEntityCollection _resourceRequiredRoles__ResourceInterfaceRequiringEntity;
        
        public ResourceInterfaceRequiringEntity()
        {
            this._resourceRequiredRoles__ResourceInterfaceRequiringEntity = new ResourceInterfaceRequiringEntityResourceRequiredRoles__ResourceInterfaceRequiringEntityCollection(this);
            this._resourceRequiredRoles__ResourceInterfaceRequiringEntity.CollectionChanged += this.ResourceRequiredRoles__ResourceInterfaceRequiringEntityCollectionChanged;
        }
        
        /// <summary>
        /// The resourceRequiredRoles__ResourceInterfaceRequiringEntity property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceRequiredRoles__ResourceInterfaceRequiringEntity")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceInterfaceRequiringEntity__ResourceRequiredRole")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceRequiredRole> ResourceRequiredRoles__ResourceInterfaceRequiringEntity
        {
            get
            {
                return this._resourceRequiredRoles__ResourceInterfaceRequiringEntity;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ResourceInterfaceRequiringEntityChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceInterfaceRequiringEntityReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceInterfac" +
                        "eRequiringEntity/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the ResourceRequiredRoles__ResourceInterfaceRequiringEntity property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceRequiredRoles__ResourceInterfaceRequiringEntityCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceRequiredRoles__ResourceInterfaceRequiringEntity", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RESOURCEREQUIREDROLES__RESOURCEINTERFACEREQUIRINGENTITY"))
            {
                return this._resourceRequiredRoles__ResourceInterfaceRequiringEntity;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceInterfac" +
                    "eRequiringEntity/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceInterfaceRequiringEntity class
        /// </summary>
        public class ResourceInterfaceRequiringEntityChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceInterfaceRequiringEntity _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceInterfaceRequiringEntityChildrenCollection(ResourceInterfaceRequiringEntity parent)
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
                    count = (count + this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IResourceRequiredRole resourceRequiredRoles__ResourceInterfaceRequiringEntityCasted = item.As<IResourceRequiredRole>();
                if ((resourceRequiredRoles__ResourceInterfaceRequiringEntityCasted != null))
                {
                    this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Add(resourceRequiredRoles__ResourceInterfaceRequiringEntityCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Contains(item))
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
                IEnumerator<IModelElement> resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator = this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.GetEnumerator();
                try
                {
                    for (
                    ; resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IResourceRequiredRole resourceRequiredRoleItem = item.As<IResourceRequiredRole>();
                if (((resourceRequiredRoleItem != null) 
                            && this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Remove(resourceRequiredRoleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceInterfaceRequiringEntity class
        /// </summary>
        public class ResourceInterfaceRequiringEntityReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceInterfaceRequiringEntity _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceInterfaceRequiringEntityReferencedElementsCollection(ResourceInterfaceRequiringEntity parent)
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
                    count = (count + this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IResourceRequiredRole resourceRequiredRoles__ResourceInterfaceRequiringEntityCasted = item.As<IResourceRequiredRole>();
                if ((resourceRequiredRoles__ResourceInterfaceRequiringEntityCasted != null))
                {
                    this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Add(resourceRequiredRoles__ResourceInterfaceRequiringEntityCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Contains(item))
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
                IEnumerator<IModelElement> resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator = this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.GetEnumerator();
                try
                {
                    for (
                    ; resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceRequiredRoles__ResourceInterfaceRequiringEntityEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IResourceRequiredRole resourceRequiredRoleItem = item.As<IResourceRequiredRole>();
                if (((resourceRequiredRoleItem != null) 
                            && this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Remove(resourceRequiredRoleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceRequiredRoles__ResourceInterfaceRequiringEntity).GetEnumerator();
            }
        }
    }
}

