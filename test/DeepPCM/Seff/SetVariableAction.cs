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
    /// The default implementation of the SetVariableAction class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/SEFF/1.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//seff//SetVariableAction/")]
    [DebuggerDisplayAttribute("SetVariableAction {Id}")]
    public class SetVariableAction : AbstractInternalControlFlowAction, ISetVariableAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the LocalVariableUsages_SetVariableAction property
        /// </summary>
        private SetVariableActionLocalVariableUsages_SetVariableActionCollection _localVariableUsages_SetVariableAction;
        
        private static IClass _classInstance;
        
        public SetVariableAction()
        {
            this._localVariableUsages_SetVariableAction = new SetVariableActionLocalVariableUsages_SetVariableActionCollection(this);
            this._localVariableUsages_SetVariableAction.CollectionChanging += this.LocalVariableUsages_SetVariableActionCollectionChanging;
            this._localVariableUsages_SetVariableAction.CollectionChanged += this.LocalVariableUsages_SetVariableActionCollectionChanged;
        }
        
        /// <summary>
        /// The localVariableUsages_SetVariableAction property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("localVariableUsages_SetVariableAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("setVariableAction_VariableUsage")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IVariableUsage> LocalVariableUsages_SetVariableAction
        {
            get
            {
                return this._localVariableUsages_SetVariableAction;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new SetVariableActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new SetVariableActionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//seff//SetVariableAction/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the LocalVariableUsages_SetVariableAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LocalVariableUsages_SetVariableActionCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("LocalVariableUsages_SetVariableAction", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the LocalVariableUsages_SetVariableAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void LocalVariableUsages_SetVariableActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("LocalVariableUsages_SetVariableAction", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "LOCALVARIABLEUSAGES_SETVARIABLEACTION"))
            {
                return this._localVariableUsages_SetVariableAction;
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//seff//SetVariableAction/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SetVariableAction class
        /// </summary>
        public class SetVariableActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SetVariableAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SetVariableActionChildrenCollection(SetVariableAction parent)
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
                    count = (count + this._parent.LocalVariableUsages_SetVariableAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LocalVariableUsages_SetVariableAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LocalVariableUsages_SetVariableAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage localVariableUsages_SetVariableActionCasted = item.As<IVariableUsage>();
                if ((localVariableUsages_SetVariableActionCasted != null))
                {
                    this._parent.LocalVariableUsages_SetVariableAction.Add(localVariableUsages_SetVariableActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LocalVariableUsages_SetVariableAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.LocalVariableUsages_SetVariableAction.Contains(item))
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
                IEnumerator<IModelElement> localVariableUsages_SetVariableActionEnumerator = this._parent.LocalVariableUsages_SetVariableAction.GetEnumerator();
                try
                {
                    for (
                    ; localVariableUsages_SetVariableActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = localVariableUsages_SetVariableActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    localVariableUsages_SetVariableActionEnumerator.Dispose();
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
                            && this._parent.LocalVariableUsages_SetVariableAction.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LocalVariableUsages_SetVariableAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SetVariableAction class
        /// </summary>
        public class SetVariableActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SetVariableAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SetVariableActionReferencedElementsCollection(SetVariableAction parent)
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
                    count = (count + this._parent.LocalVariableUsages_SetVariableAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LocalVariableUsages_SetVariableAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LocalVariableUsages_SetVariableAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage localVariableUsages_SetVariableActionCasted = item.As<IVariableUsage>();
                if ((localVariableUsages_SetVariableActionCasted != null))
                {
                    this._parent.LocalVariableUsages_SetVariableAction.Add(localVariableUsages_SetVariableActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.LocalVariableUsages_SetVariableAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.LocalVariableUsages_SetVariableAction.Contains(item))
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
                IEnumerator<IModelElement> localVariableUsages_SetVariableActionEnumerator = this._parent.LocalVariableUsages_SetVariableAction.GetEnumerator();
                try
                {
                    for (
                    ; localVariableUsages_SetVariableActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = localVariableUsages_SetVariableActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    localVariableUsages_SetVariableActionEnumerator.Dispose();
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
                            && this._parent.LocalVariableUsages_SetVariableAction.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.LocalVariableUsages_SetVariableAction).GetEnumerator();
            }
        }
    }
}

