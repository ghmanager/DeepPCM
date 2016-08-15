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
using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Seff.Seff_performance;
using GeneratedCode.Pcm.Seff.Seff_reliability;
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

namespace GeneratedCode.Pcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the CallReturnAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//CallReturnAction/")]
    public class CallReturnAction : CallAction, ICallReturnAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ReturnVariableUsage__CallReturnAction property
        /// </summary>
        private CallReturnActionReturnVariableUsage__CallReturnActionCollection _returnVariableUsage__CallReturnAction;
        
        public CallReturnAction()
        {
            this._returnVariableUsage__CallReturnAction = new CallReturnActionReturnVariableUsage__CallReturnActionCollection(this);
            this._returnVariableUsage__CallReturnAction.CollectionChanged += this.ReturnVariableUsage__CallReturnActionCollectionChanged;
        }
        
        /// <summary>
        /// The returnVariableUsage__CallReturnAction property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("returnVariableUsage__CallReturnAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("callReturnAction__VariableUsage")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IVariableUsage> ReturnVariableUsage__CallReturnAction
        {
            get
            {
                return this._returnVariableUsage__CallReturnAction;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CallReturnActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CallReturnActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//CallReturnAction/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the ReturnVariableUsage__CallReturnAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ReturnVariableUsage__CallReturnActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ReturnVariableUsage__CallReturnAction", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RETURNVARIABLEUSAGE__CALLRETURNACTION"))
            {
                return this._returnVariableUsage__CallReturnAction;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//CallReturnAction/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CallReturnAction class
        /// </summary>
        public class CallReturnActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CallReturnAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CallReturnActionChildrenCollection(CallReturnAction parent)
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
                    count = (count + this._parent.ReturnVariableUsage__CallReturnAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage returnVariableUsage__CallReturnActionCasted = item.As<IVariableUsage>();
                if ((returnVariableUsage__CallReturnActionCasted != null))
                {
                    this._parent.ReturnVariableUsage__CallReturnAction.Add(returnVariableUsage__CallReturnActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ReturnVariableUsage__CallReturnAction.Contains(item))
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
                IEnumerator<IModelElement> returnVariableUsage__CallReturnActionEnumerator = this._parent.ReturnVariableUsage__CallReturnAction.GetEnumerator();
                try
                {
                    for (
                    ; returnVariableUsage__CallReturnActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = returnVariableUsage__CallReturnActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    returnVariableUsage__CallReturnActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ReturnVariableUsage__CallReturnAction.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReturnVariableUsage__CallReturnAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CallReturnAction class
        /// </summary>
        public class CallReturnActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CallReturnAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CallReturnActionReferencedElementsCollection(CallReturnAction parent)
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
                    count = (count + this._parent.ReturnVariableUsage__CallReturnAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage returnVariableUsage__CallReturnActionCasted = item.As<IVariableUsage>();
                if ((returnVariableUsage__CallReturnActionCasted != null))
                {
                    this._parent.ReturnVariableUsage__CallReturnAction.Add(returnVariableUsage__CallReturnActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ReturnVariableUsage__CallReturnAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ReturnVariableUsage__CallReturnAction.Contains(item))
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
                IEnumerator<IModelElement> returnVariableUsage__CallReturnActionEnumerator = this._parent.ReturnVariableUsage__CallReturnAction.GetEnumerator();
                try
                {
                    for (
                    ; returnVariableUsage__CallReturnActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = returnVariableUsage__CallReturnActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    returnVariableUsage__CallReturnActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ReturnVariableUsage__CallReturnAction.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ReturnVariableUsage__CallReturnAction).GetEnumerator();
            }
        }
    }
}

