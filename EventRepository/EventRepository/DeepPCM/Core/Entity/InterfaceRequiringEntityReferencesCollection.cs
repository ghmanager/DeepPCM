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
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Core.Entity
{
    
    
    /// <summary>
    /// The collection class to implement the refined References reference for the InterfaceRequiringEntity class
    /// </summary>
    public class InterfaceRequiringEntityReferencesCollection : ICollectionExpression<IReference>, ICollection<IReference>, INotifyCollection<IReference>
    {
        
        private IInterfaceRequiringEntity _parent;
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public InterfaceRequiringEntityReferencesCollection(IInterfaceRequiringEntity parent)
        {
            this._parent = parent;
            parent.ResourceRequiredInterfacesChanged += this.HandleValueChange;
            parent.RequiredInterfaces.AsNotifiable().CollectionChanged += this.HandleCollectionChange;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 0;
                if ((this._parent.ResourceRequiredInterfaces != null))
                {
                    count = (count + 1);
                }
                count = (count + this._parent.RequiredInterfaces.Count);
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
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        
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
            System.Collections.Specialized.NotifyCollectionChangedEventArgs collectionEvent = null;
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
        
        private void HandleCollectionChange(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            this.OnCollectionChanged(eventArgs);
        }
        
        /// <summary>
        /// Adds the given element to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public virtual void Add(IReference item)
        {
            if ((this._parent.ResourceRequiredInterfaces == null))
            {
                IResourceRequiredInterface resourceRequiredInterfacesCasted = item.As<IResourceRequiredInterface>();
                if ((resourceRequiredInterfacesCasted != null))
                {
                    this._parent.ResourceRequiredInterfaces = resourceRequiredInterfacesCasted;
                    return;
                }
            }
            IRequiredInterface requiredInterfacesCasted = item.As<IRequiredInterface>();
            if ((requiredInterfacesCasted != null))
            {
                this._parent.RequiredInterfaces.Add(requiredInterfacesCasted);
            }
        }
        
        /// <summary>
        /// Clears the collection and resets all references that implement it.
        /// </summary>
        public virtual void Clear()
        {
            this._parent.ResourceRequiredInterfaces = null;
            this._parent.RequiredInterfaces.Clear();
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(IReference item)
        {
            if ((item == this._parent.ResourceRequiredInterfaces))
            {
                return true;
            }
            if (this._parent.RequiredInterfaces.Contains(item))
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
        public virtual void CopyTo(IReference[] array, int arrayIndex)
        {
            if ((this._parent.ResourceRequiredInterfaces != null))
            {
                array[arrayIndex] = this._parent.ResourceRequiredInterfaces;
                arrayIndex = (arrayIndex + 1);
            }
            IEnumerator<IReference> requiredInterfacesEnumerator = this._parent.RequiredInterfaces.GetEnumerator();
            try
            {
                for (
                ; requiredInterfacesEnumerator.MoveNext(); 
                )
                {
                    array[arrayIndex] = requiredInterfacesEnumerator.Current;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            finally
            {
                requiredInterfacesEnumerator.Dispose();
            }
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(IReference item)
        {
            if ((this._parent.ResourceRequiredInterfaces == item))
            {
                this._parent.ResourceRequiredInterfaces = null;
                return true;
            }
            IRequiredInterface requiredInterfaceItem = item.As<IRequiredInterface>();
            if (((requiredInterfaceItem != null) 
                        && this._parent.RequiredInterfaces.Remove(requiredInterfaceItem)))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<IReference> GetEnumerator()
        {
            return Enumerable.Empty<IReference>().Concat(this._parent.ResourceRequiredInterfaces).Concat(this._parent.RequiredInterfaces).GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyCollection<IReference> ICollectionExpression<IReference>.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<IReference> IEnumerableExpression<IReference>.AsNotifiable()
        {
            return this;
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable IEnumerableExpression.AsNotifiable()
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

