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
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
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

namespace DeepPCM.Deeppcm.Core.Composition
{
    
    
    /// <summary>
    /// The collection class to implement the refined BaseTypes reference for the Delegate class
    /// </summary>
    public class DelegateBaseTypesCollection : ICollectionExpression<IClass>, ICollection<IClass>, INotifyCollection<IClass>
    {
        
        private IDelegate _parent;
        
        private static IClass[] _standardValues = new IClass[] {
                ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//DelegationC" +
                        "onnector/")))};
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public DelegateBaseTypesCollection(IDelegate parent)
        {
            this._parent = parent;
            parent.TypeChanged += this.HandleValueChange;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 1;
                if ((this._parent.Type != null))
                {
                    count = (count + 1);
                }
                return count;
            }
        }
        
        /// <summary>
        /// Gets a value indicating that the collection is not read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        
        /// <summary>
        /// Returns that this composed collection is always attached.
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired when the contents of this collection changes
        /// </summary>
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
        
        /// <summary>
        /// Fires the CollectionChanged event
        /// </summary>
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private void HandleValueChange(object sender, NMF.Expressions.ValueChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventArgs collectionEvent;
            if ((eventArgs.NewValue != null))
            {
                if ((eventArgs.OldValue != null))
                {
                    collectionEvent = new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Replace, eventArgs.NewValue, eventArgs.OldValue);
                }
                else
                {
                    collectionEvent = new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Add, eventArgs.NewValue);
                }
            }
            else
            {
                collectionEvent = new System.Collections.Specialized.NotifyCollectionChangedEventArgs(System.Collections.Specialized.NotifyCollectionChangedAction.Remove, eventArgs.OldValue);
            }
            this.OnCollectionChanged(collectionEvent);
        }
        
        /// <summary>
        /// Adds the given element to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public virtual void Add(IClass item)
        {
            if ((this._parent.Type == null))
            {
                IInterface typeCasted = item.As<IInterface>();
                if ((typeCasted != null))
                {
                    this._parent.Type = typeCasted;
                    return;
                }
            }
        }
        
        /// <summary>
        /// Clears the collection and resets all references that implement it.
        /// </summary>
        public virtual void Clear()
        {
            this._parent.Type = null;
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(IClass item)
        {
            if (DelegateBaseTypesCollection._standardValues.Contains(item))
            {
                return true;
            }
            if ((item == this._parent.Type))
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
        public virtual void CopyTo(IClass[] array, int arrayIndex)
        {
            DelegateBaseTypesCollection._standardValues.CopyTo(array, arrayIndex);
            arrayIndex = (arrayIndex + 1);
            if ((this._parent.Type != null))
            {
                array[arrayIndex] = this._parent.Type;
                arrayIndex = (arrayIndex + 1);
            }
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(IClass item)
        {
            if ((this._parent.Type == item))
            {
                this._parent.Type = null;
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<IClass> GetEnumerator()
        {
            return DelegateBaseTypesCollection._standardValues.Cast<IClass>().Concat(this._parent.Type).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyCollection<IClass> ICollectionExpression<IClass>.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<IClass> IEnumerableExpression<IClass>.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable NMF.Expressions.IEnumerableExpression.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Attaches this collection class
        /// </summary>
        public void Attach()
        {
        }
        
        /// <summary>
        /// Detaches this collection class
        /// </summary>
        public void Detach()
        {
        }
    }
}

