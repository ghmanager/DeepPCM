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
using Metamodel.DeepPCM.Core.Composition;
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Repository;
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

namespace Metamodel.DeepPCM.Usagemodel
{
    
    
    /// <summary>
    /// The default implementation of the OpenWorkload class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/UsageModel/1.0")]
    [XmlNamespacePrefixAttribute("usagemodel")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//usagemodel//OpenWorkload/")]
    public class OpenWorkload : Workload, IOpenWorkload, IModelElement
    {
        
        /// <summary>
        /// The backing field for the InterArrivalTime_OpenWorkload property
        /// </summary>
        private IPCMRandomVariable _interArrivalTime_OpenWorkload;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The interArrivalTime_OpenWorkload property
        /// </summary>
        [XmlElementNameAttribute("interArrivalTime_OpenWorkload")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("openWorkload_PCMRandomVariable")]
        public virtual IPCMRandomVariable InterArrivalTime_OpenWorkload
        {
            get
            {
                return this._interArrivalTime_OpenWorkload;
            }
            set
            {
                if ((this._interArrivalTime_OpenWorkload != value))
                {
                    IPCMRandomVariable old = this._interArrivalTime_OpenWorkload;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInterArrivalTime_OpenWorkloadChanging(e);
                    this.OnPropertyChanging("InterArrivalTime_OpenWorkload", e);
                    this._interArrivalTime_OpenWorkload = value;
                    if ((old != null))
                    {
                        old.OpenWorkload_PCMRandomVariable = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetInterArrivalTime_OpenWorkload;
                    }
                    if ((value != null))
                    {
                        value.OpenWorkload_PCMRandomVariable = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetInterArrivalTime_OpenWorkload;
                    }
                    this.OnInterArrivalTime_OpenWorkloadChanged(e);
                    this.OnPropertyChanged("InterArrivalTime_OpenWorkload", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new OpenWorkloadChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OpenWorkloadReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//usagemodel//OpenWorkload/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the InterArrivalTime_OpenWorkload property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InterArrivalTime_OpenWorkloadChanging;
        
        /// <summary>
        /// Gets fired when the InterArrivalTime_OpenWorkload property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> InterArrivalTime_OpenWorkloadChanged;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="diagnostics"></param>
        /// <param name="context"></param>
        private void InterArrivalTimeInOpenWorkloadNeedsToBeSpecified(object diagnostics, object context)
        {
            if ((diagnostics != null))
            {
                throw new ArgumentNullException("diagnostics");
            }
            if ((context != null))
            {
                throw new ArgumentNullException("context");
            }
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Raises the InterArrivalTime_OpenWorkloadChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterArrivalTime_OpenWorkloadChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InterArrivalTime_OpenWorkloadChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InterArrivalTime_OpenWorkloadChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterArrivalTime_OpenWorkloadChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.InterArrivalTime_OpenWorkloadChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InterArrivalTime_OpenWorkload property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInterArrivalTime_OpenWorkload(object sender, System.EventArgs eventArgs)
        {
            this.InterArrivalTime_OpenWorkload = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.InterArrivalTime_OpenWorkload))
            {
                return ModelHelper.CreatePath("InterArrivalTime_OpenWorkload");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "INTERARRIVALTIME_OPENWORKLOAD"))
            {
                return this.InterArrivalTime_OpenWorkload;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INTERARRIVALTIME_OPENWORKLOAD"))
            {
                this.InterArrivalTime_OpenWorkload = ((IPCMRandomVariable)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "INTERARRIVALTIME_OPENWORKLOAD"))
            {
                return new InterArrivalTime_OpenWorkloadProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "INTERARRIVALTIME_OPENWORKLOAD"))
            {
                return new InterArrivalTime_OpenWorkloadProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//usagemodel//OpenWorkload/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OpenWorkload class
        /// </summary>
        public class OpenWorkloadChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OpenWorkload _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OpenWorkloadChildrenCollection(OpenWorkload parent)
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
                    if ((this._parent.InterArrivalTime_OpenWorkload != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InterArrivalTime_OpenWorkloadChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InterArrivalTime_OpenWorkloadChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InterArrivalTime_OpenWorkload == null))
                {
                    IPCMRandomVariable interArrivalTime_OpenWorkloadCasted = item.As<IPCMRandomVariable>();
                    if ((interArrivalTime_OpenWorkloadCasted != null))
                    {
                        this._parent.InterArrivalTime_OpenWorkload = interArrivalTime_OpenWorkloadCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InterArrivalTime_OpenWorkload = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InterArrivalTime_OpenWorkload))
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
                if ((this._parent.InterArrivalTime_OpenWorkload != null))
                {
                    array[arrayIndex] = this._parent.InterArrivalTime_OpenWorkload;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.InterArrivalTime_OpenWorkload == item))
                {
                    this._parent.InterArrivalTime_OpenWorkload = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InterArrivalTime_OpenWorkload).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OpenWorkload class
        /// </summary>
        public class OpenWorkloadReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OpenWorkload _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OpenWorkloadReferencedElementsCollection(OpenWorkload parent)
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
                    if ((this._parent.InterArrivalTime_OpenWorkload != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InterArrivalTime_OpenWorkloadChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InterArrivalTime_OpenWorkloadChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InterArrivalTime_OpenWorkload == null))
                {
                    IPCMRandomVariable interArrivalTime_OpenWorkloadCasted = item.As<IPCMRandomVariable>();
                    if ((interArrivalTime_OpenWorkloadCasted != null))
                    {
                        this._parent.InterArrivalTime_OpenWorkload = interArrivalTime_OpenWorkloadCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InterArrivalTime_OpenWorkload = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InterArrivalTime_OpenWorkload))
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
                if ((this._parent.InterArrivalTime_OpenWorkload != null))
                {
                    array[arrayIndex] = this._parent.InterArrivalTime_OpenWorkload;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.InterArrivalTime_OpenWorkload == item))
                {
                    this._parent.InterArrivalTime_OpenWorkload = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InterArrivalTime_OpenWorkload).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the interArrivalTime_OpenWorkload property
        /// </summary>
        private sealed class InterArrivalTime_OpenWorkloadProxy : ModelPropertyChange<IOpenWorkload, IPCMRandomVariable>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InterArrivalTime_OpenWorkloadProxy(IOpenWorkload modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPCMRandomVariable Value
            {
                get
                {
                    return this.ModelElement.InterArrivalTime_OpenWorkload;
                }
                set
                {
                    this.ModelElement.InterArrivalTime_OpenWorkload = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InterArrivalTime_OpenWorkloadChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.InterArrivalTime_OpenWorkloadChanged -= handler;
            }
        }
    }
}

