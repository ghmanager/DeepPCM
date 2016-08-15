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
    /// The default implementation of the LoopAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//LoopAction/")]
    [DebuggerDisplayAttribute("LoopAction {Id}")]
    public class LoopAction : AbstractLoopAction, ILoopAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the IterationCount_LoopAction property
        /// </summary>
        private IPCMRandomVariable _iterationCount_LoopAction;
        
        /// <summary>
        /// The iterationCount_LoopAction property
        /// </summary>
        [XmlElementNameAttribute("iterationCount_LoopAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("loopAction_PCMRandomVariable")]
        public virtual IPCMRandomVariable IterationCount_LoopAction
        {
            get
            {
                return this._iterationCount_LoopAction;
            }
            set
            {
                if ((this._iterationCount_LoopAction != value))
                {
                    IPCMRandomVariable old = this._iterationCount_LoopAction;
                    this._iterationCount_LoopAction = value;
                    if ((old != null))
                    {
                        old.LoopAction_PCMRandomVariable = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetIterationCount_LoopAction;
                    }
                    if ((value != null))
                    {
                        value.LoopAction_PCMRandomVariable = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetIterationCount_LoopAction;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIterationCount_LoopActionChanged(e);
                    this.OnPropertyChanged("IterationCount_LoopAction", e);
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
                return base.Children.Concat(new LoopActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new LoopActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//LoopAction/");
            }
        }
        
        /// <summary>
        /// Gets fired when the IterationCount_LoopAction property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> IterationCount_LoopActionChanged;
        
        /// <summary>
        /// Raises the IterationCount_LoopActionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIterationCount_LoopActionChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.IterationCount_LoopActionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the IterationCount_LoopAction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetIterationCount_LoopAction(object sender, EventArgs eventArgs)
        {
            this.IterationCount_LoopAction = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.IterationCount_LoopAction))
            {
                return ModelHelper.CreatePath("IterationCount_LoopAction");
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
            if ((reference == "ITERATIONCOUNT_LOOPACTION"))
            {
                return this.IterationCount_LoopAction;
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
            if ((feature == "ITERATIONCOUNT_LOOPACTION"))
            {
                this.IterationCount_LoopAction = ((IPCMRandomVariable)(value));
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
            if ((attribute == "ITERATIONCOUNT_LOOPACTION"))
            {
                return new IterationCount_LoopActionProxy(this);
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
            if ((reference == "ITERATIONCOUNT_LOOPACTION"))
            {
                return new IterationCount_LoopActionProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//LoopAction/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the LoopAction class
        /// </summary>
        public class LoopActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private LoopAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LoopActionChildrenCollection(LoopAction parent)
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
                    if ((this._parent.IterationCount_LoopAction != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.IterationCount_LoopActionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.IterationCount_LoopActionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.IterationCount_LoopAction == null))
                {
                    IPCMRandomVariable iterationCount_LoopActionCasted = item.As<IPCMRandomVariable>();
                    if ((iterationCount_LoopActionCasted != null))
                    {
                        this._parent.IterationCount_LoopAction = iterationCount_LoopActionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.IterationCount_LoopAction = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.IterationCount_LoopAction))
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
                if ((this._parent.IterationCount_LoopAction != null))
                {
                    array[arrayIndex] = this._parent.IterationCount_LoopAction;
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
                if ((this._parent.IterationCount_LoopAction == item))
                {
                    this._parent.IterationCount_LoopAction = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.IterationCount_LoopAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the LoopAction class
        /// </summary>
        public class LoopActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private LoopAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public LoopActionReferencedElementsCollection(LoopAction parent)
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
                    if ((this._parent.IterationCount_LoopAction != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.IterationCount_LoopActionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.IterationCount_LoopActionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.IterationCount_LoopAction == null))
                {
                    IPCMRandomVariable iterationCount_LoopActionCasted = item.As<IPCMRandomVariable>();
                    if ((iterationCount_LoopActionCasted != null))
                    {
                        this._parent.IterationCount_LoopAction = iterationCount_LoopActionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.IterationCount_LoopAction = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.IterationCount_LoopAction))
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
                if ((this._parent.IterationCount_LoopAction != null))
                {
                    array[arrayIndex] = this._parent.IterationCount_LoopAction;
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
                if ((this._parent.IterationCount_LoopAction == item))
                {
                    this._parent.IterationCount_LoopAction = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.IterationCount_LoopAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the iterationCount_LoopAction property
        /// </summary>
        private sealed class IterationCount_LoopActionProxy : ModelPropertyChange<ILoopAction, IPCMRandomVariable>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IterationCount_LoopActionProxy(ILoopAction modelElement) : 
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
                    return this.ModelElement.IterationCount_LoopAction;
                }
                set
                {
                    this.ModelElement.IterationCount_LoopAction = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IterationCount_LoopActionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.IterationCount_LoopActionChanged -= handler;
            }
        }
    }
}

