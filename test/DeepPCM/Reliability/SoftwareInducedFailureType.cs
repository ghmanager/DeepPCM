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
using Metamodel.DeepPCM.Qosannotations.Qos_reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
using Metamodel.DeepPCM.Seff;
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

namespace Metamodel.DeepPCM.Reliability
{
    
    
    /// <summary>
    /// The default implementation of the SoftwareInducedFailureType class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/Reliability/1.0")]
    [XmlNamespacePrefixAttribute("reliability")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//reliability//SoftwareInducedFailureType" +
        "/")]
    [DebuggerDisplayAttribute("SoftwareInducedFailureType {Id}")]
    public class SoftwareInducedFailureType : FailureType, ISoftwareInducedFailureType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType property
        /// </summary>
        private SoftwareInducedFailureTypeInternalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCollection _internalFailureOccurrenceDescriptions__SoftwareInducedFailureType;
        
        private static IClass _classInstance;
        
        public SoftwareInducedFailureType()
        {
            this._internalFailureOccurrenceDescriptions__SoftwareInducedFailureType = new SoftwareInducedFailureTypeInternalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCollection(this);
            this._internalFailureOccurrenceDescriptions__SoftwareInducedFailureType.CollectionChanging += this.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCollectionChanging;
            this._internalFailureOccurrenceDescriptions__SoftwareInducedFailureType.CollectionChanged += this.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCollectionChanged;
        }
        
        /// <summary>
        /// The internalFailureOccurrenceDescriptions__SoftwareInducedFailureType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("internalFailureOccurrenceDescriptions__SoftwareInducedFailureType")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("softwareInducedFailureType__InternalFailureOccurrenceDescription")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IInternalFailureOccurrenceDescription> InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType
        {
            get
            {
                return this._internalFailureOccurrenceDescriptions__SoftwareInducedFailureType;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SoftwareInducedFailureTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//reliability//SoftwareInducedFailureType" +
                            "/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InternalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InternalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "INTERNALFAILUREOCCURRENCEDESCRIPTIONS__SOFTWAREINDUCEDFAILURETYPE"))
            {
                return this._internalFailureOccurrenceDescriptions__SoftwareInducedFailureType;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//reliability//SoftwareInducedFailureType" +
                        "/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SoftwareInducedFailureType class
        /// </summary>
        public class SoftwareInducedFailureTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SoftwareInducedFailureType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SoftwareInducedFailureTypeReferencedElementsCollection(SoftwareInducedFailureType parent)
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
                    count = (count + this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IInternalFailureOccurrenceDescription internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCasted = item.As<IInternalFailureOccurrenceDescription>();
                if ((internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCasted != null))
                {
                    this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.Add(internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.Contains(item))
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
                IEnumerator<IModelElement> internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeEnumerator = this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.GetEnumerator();
                try
                {
                    for (
                    ; internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    internalFailureOccurrenceDescriptions__SoftwareInducedFailureTypeEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IInternalFailureOccurrenceDescription internalFailureOccurrenceDescriptionItem = item.As<IInternalFailureOccurrenceDescription>();
                if (((internalFailureOccurrenceDescriptionItem != null) 
                            && this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType.Remove(internalFailureOccurrenceDescriptionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InternalFailureOccurrenceDescriptions__SoftwareInducedFailureType).GetEnumerator();
            }
        }
    }
}

