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
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Seff;
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

namespace DeepPCM.Deeppcm.Seff.Seff_reliability
{
    
    
    /// <summary>
    /// The default implementation of the RecoveryAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/SEFF_Reliability/5.0")]
    [XmlNamespacePrefixAttribute("seff_reliability")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//seff_reliability//Recove" +
        "ryAction/")]
    [DebuggerDisplayAttribute("RecoveryAction {Id}")]
    public class RecoveryAction : AbstractInternalControlFlowAction, IRecoveryAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the PrimaryBehaviour__RecoveryAction property
        /// </summary>
        private IRecoveryActionBehaviour _primaryBehaviour__RecoveryAction;
        
        /// <summary>
        /// The backing field for the RecoveryActionBehaviours__RecoveryAction property
        /// </summary>
        private RecoveryActionRecoveryActionBehaviours__RecoveryActionCollection _recoveryActionBehaviours__RecoveryAction;
        
        public RecoveryAction()
        {
            this._recoveryActionBehaviours__RecoveryAction = new RecoveryActionRecoveryActionBehaviours__RecoveryActionCollection(this);
            this._recoveryActionBehaviours__RecoveryAction.CollectionChanged += this.RecoveryActionBehaviours__RecoveryActionCollectionChanged;
        }
        
        /// <summary>
        /// The primaryBehaviour__RecoveryAction property
        /// </summary>
        [XmlElementNameAttribute("primaryBehaviour__RecoveryAction")]
        [XmlAttributeAttribute(true)]
        public virtual IRecoveryActionBehaviour PrimaryBehaviour__RecoveryAction
        {
            get
            {
                return this._primaryBehaviour__RecoveryAction;
            }
            set
            {
                if ((this._primaryBehaviour__RecoveryAction != value))
                {
                    IRecoveryActionBehaviour old = this._primaryBehaviour__RecoveryAction;
                    this._primaryBehaviour__RecoveryAction = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetPrimaryBehaviour__RecoveryAction;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetPrimaryBehaviour__RecoveryAction;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnPrimaryBehaviour__RecoveryActionChanged(e);
                    this.OnPropertyChanged("PrimaryBehaviour__RecoveryAction", e);
                }
            }
        }
        
        /// <summary>
        /// The recoveryActionBehaviours__RecoveryAction property
        /// </summary>
        [LowerBoundAttribute(2)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("recoveryActionBehaviours__RecoveryAction")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("recoveryAction__RecoveryActionBehaviour")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IRecoveryActionBehaviour> RecoveryActionBehaviours__RecoveryAction
        {
            get
            {
                return this._recoveryActionBehaviours__RecoveryAction;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new RecoveryActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new RecoveryActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//seff_reliability//Recove" +
                        "ryAction/");
            }
        }
        
        /// <summary>
        /// Gets fired when the PrimaryBehaviour__RecoveryAction property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> PrimaryBehaviour__RecoveryActionChanged;
        
        /// <summary>
        /// Raises the PrimaryBehaviour__RecoveryActionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnPrimaryBehaviour__RecoveryActionChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.PrimaryBehaviour__RecoveryActionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the PrimaryBehaviour__RecoveryAction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetPrimaryBehaviour__RecoveryAction(object sender, EventArgs eventArgs)
        {
            this.PrimaryBehaviour__RecoveryAction = null;
        }
        
        /// <summary>
        /// Forwards change notifications for the RecoveryActionBehaviours__RecoveryAction property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RecoveryActionBehaviours__RecoveryActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RecoveryActionBehaviours__RecoveryAction", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RECOVERYACTIONBEHAVIOURS__RECOVERYACTION"))
            {
                return this._recoveryActionBehaviours__RecoveryAction;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PRIMARYBEHAVIOUR__RECOVERYACTION"))
            {
                this.PrimaryBehaviour__RecoveryAction = ((IRecoveryActionBehaviour)(value));
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
            if ((attribute == "PRIMARYBEHAVIOUR__RECOVERYACTION"))
            {
                return new PrimaryBehaviour__RecoveryActionProxy(this);
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
            if ((reference == "PRIMARYBEHAVIOUR__RECOVERYACTION"))
            {
                return new PrimaryBehaviour__RecoveryActionProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//seff_reliability//Recove" +
                    "ryAction/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RecoveryAction class
        /// </summary>
        public class RecoveryActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RecoveryAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RecoveryActionChildrenCollection(RecoveryAction parent)
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
                    count = (count + this._parent.RecoveryActionBehaviours__RecoveryAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RecoveryActionBehaviours__RecoveryAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RecoveryActionBehaviours__RecoveryAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRecoveryActionBehaviour recoveryActionBehaviours__RecoveryActionCasted = item.As<IRecoveryActionBehaviour>();
                if ((recoveryActionBehaviours__RecoveryActionCasted != null))
                {
                    this._parent.RecoveryActionBehaviours__RecoveryAction.Add(recoveryActionBehaviours__RecoveryActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RecoveryActionBehaviours__RecoveryAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RecoveryActionBehaviours__RecoveryAction.Contains(item))
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
                IEnumerator<IModelElement> recoveryActionBehaviours__RecoveryActionEnumerator = this._parent.RecoveryActionBehaviours__RecoveryAction.GetEnumerator();
                try
                {
                    for (
                    ; recoveryActionBehaviours__RecoveryActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = recoveryActionBehaviours__RecoveryActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    recoveryActionBehaviours__RecoveryActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRecoveryActionBehaviour recoveryActionBehaviourItem = item.As<IRecoveryActionBehaviour>();
                if (((recoveryActionBehaviourItem != null) 
                            && this._parent.RecoveryActionBehaviours__RecoveryAction.Remove(recoveryActionBehaviourItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RecoveryActionBehaviours__RecoveryAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RecoveryAction class
        /// </summary>
        public class RecoveryActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RecoveryAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RecoveryActionReferencedElementsCollection(RecoveryAction parent)
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
                    if ((this._parent.PrimaryBehaviour__RecoveryAction != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.RecoveryActionBehaviours__RecoveryAction.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.PrimaryBehaviour__RecoveryActionChanged += this.PropagateValueChanges;
                this._parent.RecoveryActionBehaviours__RecoveryAction.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.PrimaryBehaviour__RecoveryActionChanged -= this.PropagateValueChanges;
                this._parent.RecoveryActionBehaviours__RecoveryAction.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.PrimaryBehaviour__RecoveryAction == null))
                {
                    IRecoveryActionBehaviour primaryBehaviour__RecoveryActionCasted = item.As<IRecoveryActionBehaviour>();
                    if ((primaryBehaviour__RecoveryActionCasted != null))
                    {
                        this._parent.PrimaryBehaviour__RecoveryAction = primaryBehaviour__RecoveryActionCasted;
                        return;
                    }
                }
                IRecoveryActionBehaviour recoveryActionBehaviours__RecoveryActionCasted = item.As<IRecoveryActionBehaviour>();
                if ((recoveryActionBehaviours__RecoveryActionCasted != null))
                {
                    this._parent.RecoveryActionBehaviours__RecoveryAction.Add(recoveryActionBehaviours__RecoveryActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.PrimaryBehaviour__RecoveryAction = null;
                this._parent.RecoveryActionBehaviours__RecoveryAction.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.PrimaryBehaviour__RecoveryAction))
                {
                    return true;
                }
                if (this._parent.RecoveryActionBehaviours__RecoveryAction.Contains(item))
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
                if ((this._parent.PrimaryBehaviour__RecoveryAction != null))
                {
                    array[arrayIndex] = this._parent.PrimaryBehaviour__RecoveryAction;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> recoveryActionBehaviours__RecoveryActionEnumerator = this._parent.RecoveryActionBehaviours__RecoveryAction.GetEnumerator();
                try
                {
                    for (
                    ; recoveryActionBehaviours__RecoveryActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = recoveryActionBehaviours__RecoveryActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    recoveryActionBehaviours__RecoveryActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.PrimaryBehaviour__RecoveryAction == item))
                {
                    this._parent.PrimaryBehaviour__RecoveryAction = null;
                    return true;
                }
                IRecoveryActionBehaviour recoveryActionBehaviourItem = item.As<IRecoveryActionBehaviour>();
                if (((recoveryActionBehaviourItem != null) 
                            && this._parent.RecoveryActionBehaviours__RecoveryAction.Remove(recoveryActionBehaviourItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.PrimaryBehaviour__RecoveryAction).Concat(this._parent.RecoveryActionBehaviours__RecoveryAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the primaryBehaviour__RecoveryAction property
        /// </summary>
        private sealed class PrimaryBehaviour__RecoveryActionProxy : ModelPropertyChange<IRecoveryAction, IRecoveryActionBehaviour>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public PrimaryBehaviour__RecoveryActionProxy(IRecoveryAction modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRecoveryActionBehaviour Value
            {
                get
                {
                    return this.ModelElement.PrimaryBehaviour__RecoveryAction;
                }
                set
                {
                    this.ModelElement.PrimaryBehaviour__RecoveryAction = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PrimaryBehaviour__RecoveryActionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.PrimaryBehaviour__RecoveryActionChanged -= handler;
            }
        }
    }
}

