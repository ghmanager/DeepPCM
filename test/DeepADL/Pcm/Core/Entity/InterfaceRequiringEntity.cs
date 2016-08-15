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
    /// The default implementation of the InterfaceRequiringEntity class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Entity/5.0")]
    [XmlNamespacePrefixAttribute("entity")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//InterfaceRequiri" +
        "ngEntity/")]
    [DebuggerDisplayAttribute("InterfaceRequiringEntity {Id}")]
    public abstract class InterfaceRequiringEntity : ResourceInterfaceRequiringEntity, IInterfaceRequiringEntity, IModelElement
    {
        
        /// <summary>
        /// The backing field for the RequiredRoles_InterfaceRequiringEntity property
        /// </summary>
        private InterfaceRequiringEntityRequiredRoles_InterfaceRequiringEntityCollection _requiredRoles_InterfaceRequiringEntity;
        
        public InterfaceRequiringEntity()
        {
            this._requiredRoles_InterfaceRequiringEntity = new InterfaceRequiringEntityRequiredRoles_InterfaceRequiringEntityCollection(this);
            this._requiredRoles_InterfaceRequiringEntity.CollectionChanged += this.RequiredRoles_InterfaceRequiringEntityCollectionChanged;
        }
        
        /// <summary>
        /// The requiredRoles_InterfaceRequiringEntity property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("requiredRoles_InterfaceRequiringEntity")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("requiringEntity_RequiredRole")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IRequiredRole> RequiredRoles_InterfaceRequiringEntity
        {
            get
            {
                return this._requiredRoles_InterfaceRequiringEntity;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new InterfaceRequiringEntityChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new InterfaceRequiringEntityReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//InterfaceRequiri" +
                        "ngEntity/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the RequiredRoles_InterfaceRequiringEntity property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RequiredRoles_InterfaceRequiringEntityCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RequiredRoles_InterfaceRequiringEntity", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "REQUIREDROLES_INTERFACEREQUIRINGENTITY"))
            {
                return this._requiredRoles_InterfaceRequiringEntity;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//InterfaceRequiri" +
                    "ngEntity/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the InterfaceRequiringEntity class
        /// </summary>
        public class InterfaceRequiringEntityChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private InterfaceRequiringEntity _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InterfaceRequiringEntityChildrenCollection(InterfaceRequiringEntity parent)
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
                    count = (count + this._parent.RequiredRoles_InterfaceRequiringEntity.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRequiredRole requiredRoles_InterfaceRequiringEntityCasted = item.As<IRequiredRole>();
                if ((requiredRoles_InterfaceRequiringEntityCasted != null))
                {
                    this._parent.RequiredRoles_InterfaceRequiringEntity.Add(requiredRoles_InterfaceRequiringEntityCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RequiredRoles_InterfaceRequiringEntity.Contains(item))
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
                IEnumerator<IModelElement> requiredRoles_InterfaceRequiringEntityEnumerator = this._parent.RequiredRoles_InterfaceRequiringEntity.GetEnumerator();
                try
                {
                    for (
                    ; requiredRoles_InterfaceRequiringEntityEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = requiredRoles_InterfaceRequiringEntityEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    requiredRoles_InterfaceRequiringEntityEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRequiredRole requiredRoleItem = item.As<IRequiredRole>();
                if (((requiredRoleItem != null) 
                            && this._parent.RequiredRoles_InterfaceRequiringEntity.Remove(requiredRoleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RequiredRoles_InterfaceRequiringEntity).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the InterfaceRequiringEntity class
        /// </summary>
        public class InterfaceRequiringEntityReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private InterfaceRequiringEntity _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InterfaceRequiringEntityReferencedElementsCollection(InterfaceRequiringEntity parent)
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
                    count = (count + this._parent.RequiredRoles_InterfaceRequiringEntity.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRequiredRole requiredRoles_InterfaceRequiringEntityCasted = item.As<IRequiredRole>();
                if ((requiredRoles_InterfaceRequiringEntityCasted != null))
                {
                    this._parent.RequiredRoles_InterfaceRequiringEntity.Add(requiredRoles_InterfaceRequiringEntityCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RequiredRoles_InterfaceRequiringEntity.Contains(item))
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
                IEnumerator<IModelElement> requiredRoles_InterfaceRequiringEntityEnumerator = this._parent.RequiredRoles_InterfaceRequiringEntity.GetEnumerator();
                try
                {
                    for (
                    ; requiredRoles_InterfaceRequiringEntityEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = requiredRoles_InterfaceRequiringEntityEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    requiredRoles_InterfaceRequiringEntityEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRequiredRole requiredRoleItem = item.As<IRequiredRole>();
                if (((requiredRoleItem != null) 
                            && this._parent.RequiredRoles_InterfaceRequiringEntity.Remove(requiredRoleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RequiredRoles_InterfaceRequiringEntity).GetEnumerator();
            }
        }
    }
}

