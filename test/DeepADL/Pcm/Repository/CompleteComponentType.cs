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
using GeneratedCode.Pcm.Protocol;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Resourcetype;
using GeneratedCode.Pcm.Seff;
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

namespace GeneratedCode.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the CompleteComponentType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//CompleteComponentT" +
        "ype/")]
    [DebuggerDisplayAttribute("CompleteComponentType {Id}")]
    public class CompleteComponentType : RepositoryComponent, ICompleteComponentType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ParentProvidesComponentTypes property
        /// </summary>
        private ObservableAssociationList<IProvidesComponentType> _parentProvidesComponentTypes;
        
        public CompleteComponentType()
        {
            this._parentProvidesComponentTypes = new ObservableAssociationList<IProvidesComponentType>();
            this._parentProvidesComponentTypes.CollectionChanged += this.ParentProvidesComponentTypesCollectionChanged;
        }
        
        /// <summary>
        /// The parentProvidesComponentTypes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("parentProvidesComponentTypes")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IProvidesComponentType> ParentProvidesComponentTypes
        {
            get
            {
                return this._parentProvidesComponentTypes;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CompleteComponentTypeReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//CompleteComponentT" +
                        "ype/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the ParentProvidesComponentTypes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentProvidesComponentTypesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ParentProvidesComponentTypes", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "PARENTPROVIDESCOMPONENTTYPES"))
            {
                return this._parentProvidesComponentTypes;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//CompleteComponentT" +
                    "ype/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompleteComponentType class
        /// </summary>
        public class CompleteComponentTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CompleteComponentType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompleteComponentTypeReferencedElementsCollection(CompleteComponentType parent)
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
                    count = (count + this._parent.ParentProvidesComponentTypes.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParentProvidesComponentTypes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParentProvidesComponentTypes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IProvidesComponentType parentProvidesComponentTypesCasted = item.As<IProvidesComponentType>();
                if ((parentProvidesComponentTypesCasted != null))
                {
                    this._parent.ParentProvidesComponentTypes.Add(parentProvidesComponentTypesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ParentProvidesComponentTypes.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ParentProvidesComponentTypes.Contains(item))
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
                IEnumerator<IModelElement> parentProvidesComponentTypesEnumerator = this._parent.ParentProvidesComponentTypes.GetEnumerator();
                try
                {
                    for (
                    ; parentProvidesComponentTypesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parentProvidesComponentTypesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parentProvidesComponentTypesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IProvidesComponentType providesComponentTypeItem = item.As<IProvidesComponentType>();
                if (((providesComponentTypeItem != null) 
                            && this._parent.ParentProvidesComponentTypes.Remove(providesComponentTypeItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ParentProvidesComponentTypes).GetEnumerator();
            }
        }
    }
}
