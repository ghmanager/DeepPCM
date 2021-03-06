//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core;
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Seff.Seff_performance;
using Metamodel.DeepPCM.Seff.Seff_reliability;
using Metamodel.Identifier;
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

namespace Metamodel.DeepPCM.Seff
{
    
    
    /// <summary>
    /// The default implementation of the CallAction class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/SEFF/1.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//seff//CallAction/")]
    public abstract class CallAction : ModelElement, ICallAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the InputVariableUsages__CallAction property
        /// </summary>
        private CallActionInputVariableUsages__CallActionCollection _inputVariableUsages__CallAction;
        
        private static IClass _classInstance;
        
        public CallAction()
        {
            this._inputVariableUsages__CallAction = new CallActionInputVariableUsages__CallActionCollection(this);
            this._inputVariableUsages__CallAction.CollectionChanging += this.InputVariableUsages__CallActionCollectionChanging;
            this._inputVariableUsages__CallAction.CollectionChanged += this.InputVariableUsages__CallActionCollectionChanged;
        }
        
        /// <summary>
        /// The inputVariableUsages__CallAction property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("inputVariableUsages__CallAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("callAction__VariableUsage")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IVariableUsage> InputVariableUsages__CallAction
        {
            get
            {
                return this._inputVariableUsages__CallAction;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CallActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CallActionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//seff//CallAction/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the InputVariableUsages__CallAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InputVariableUsages__CallActionCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("InputVariableUsages__CallAction", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the InputVariableUsages__CallAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InputVariableUsages__CallActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InputVariableUsages__CallAction", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "INPUTVARIABLEUSAGES__CALLACTION"))
            {
                return this._inputVariableUsages__CallAction;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//seff//CallAction/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CallAction class
        /// </summary>
        public class CallActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CallAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CallActionChildrenCollection(CallAction parent)
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
                    count = (count + this._parent.InputVariableUsages__CallAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage inputVariableUsages__CallActionCasted = item.As<IVariableUsage>();
                if ((inputVariableUsages__CallActionCasted != null))
                {
                    this._parent.InputVariableUsages__CallAction.Add(inputVariableUsages__CallActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InputVariableUsages__CallAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InputVariableUsages__CallAction.Contains(item))
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
                IEnumerator<IModelElement> inputVariableUsages__CallActionEnumerator = this._parent.InputVariableUsages__CallAction.GetEnumerator();
                try
                {
                    for (
                    ; inputVariableUsages__CallActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = inputVariableUsages__CallActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    inputVariableUsages__CallActionEnumerator.Dispose();
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
                            && this._parent.InputVariableUsages__CallAction.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InputVariableUsages__CallAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CallAction class
        /// </summary>
        public class CallActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CallAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CallActionReferencedElementsCollection(CallAction parent)
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
                    count = (count + this._parent.InputVariableUsages__CallAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InputVariableUsages__CallAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage inputVariableUsages__CallActionCasted = item.As<IVariableUsage>();
                if ((inputVariableUsages__CallActionCasted != null))
                {
                    this._parent.InputVariableUsages__CallAction.Add(inputVariableUsages__CallActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InputVariableUsages__CallAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InputVariableUsages__CallAction.Contains(item))
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
                IEnumerator<IModelElement> inputVariableUsages__CallActionEnumerator = this._parent.InputVariableUsages__CallAction.GetEnumerator();
                try
                {
                    for (
                    ; inputVariableUsages__CallActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = inputVariableUsages__CallActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    inputVariableUsages__CallActionEnumerator.Dispose();
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
                            && this._parent.InputVariableUsages__CallAction.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InputVariableUsages__CallAction).GetEnumerator();
            }
        }
    }
}

