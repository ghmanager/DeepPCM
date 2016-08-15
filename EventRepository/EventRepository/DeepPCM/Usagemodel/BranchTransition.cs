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
    /// The default implementation of the BranchTransition class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/UsageModel/1.0")]
    [XmlNamespacePrefixAttribute("usagemodel")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//usagemodel//BranchTransition/")]
    public class BranchTransition : ModelElement, IBranchTransition, IModelElement
    {
        
        /// <summary>
        /// The backing field for the BranchProbability property
        /// </summary>
        private double _branchProbability;
        
        /// <summary>
        /// The backing field for the BranchedBehaviour_BranchTransition property
        /// </summary>
        private IScenarioBehaviour _branchedBehaviour_BranchTransition;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The branchProbability property
        /// </summary>
        [XmlElementNameAttribute("branchProbability")]
        [XmlAttributeAttribute(true)]
        public virtual double BranchProbability
        {
            get
            {
                return this._branchProbability;
            }
            set
            {
                if ((this._branchProbability != value))
                {
                    double old = this._branchProbability;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBranchProbabilityChanging(e);
                    this.OnPropertyChanging("BranchProbability", e);
                    this._branchProbability = value;
                    this.OnBranchProbabilityChanged(e);
                    this.OnPropertyChanged("BranchProbability", e);
                }
            }
        }
        
        /// <summary>
        /// The branch_BranchTransition property
        /// </summary>
        [XmlElementNameAttribute("branch_BranchTransition")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("branchTransitions_Branch")]
        public virtual IBranch Branch_BranchTransition
        {
            get
            {
                return ModelHelper.CastAs<IBranch>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The branchedBehaviour_BranchTransition property
        /// </summary>
        [XmlElementNameAttribute("branchedBehaviour_BranchTransition")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("branchTransition_ScenarioBehaviour")]
        public virtual IScenarioBehaviour BranchedBehaviour_BranchTransition
        {
            get
            {
                return this._branchedBehaviour_BranchTransition;
            }
            set
            {
                if ((this._branchedBehaviour_BranchTransition != value))
                {
                    IScenarioBehaviour old = this._branchedBehaviour_BranchTransition;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBranchedBehaviour_BranchTransitionChanging(e);
                    this.OnPropertyChanging("BranchedBehaviour_BranchTransition", e);
                    this._branchedBehaviour_BranchTransition = value;
                    if ((old != null))
                    {
                        old.BranchTransition_ScenarioBehaviour = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetBranchedBehaviour_BranchTransition;
                    }
                    if ((value != null))
                    {
                        value.BranchTransition_ScenarioBehaviour = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetBranchedBehaviour_BranchTransition;
                    }
                    this.OnBranchedBehaviour_BranchTransitionChanged(e);
                    this.OnPropertyChanged("BranchedBehaviour_BranchTransition", e);
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
                return base.Children.Concat(new BranchTransitionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new BranchTransitionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//usagemodel//BranchTransition/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the BranchProbability property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BranchProbabilityChanging;
        
        /// <summary>
        /// Gets fired when the BranchProbability property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BranchProbabilityChanged;
        
        /// <summary>
        /// Gets fired before the Branch_BranchTransition property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Branch_BranchTransitionChanging;
        
        /// <summary>
        /// Gets fired when the Branch_BranchTransition property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Branch_BranchTransitionChanged;
        
        /// <summary>
        /// Gets fired before the BranchedBehaviour_BranchTransition property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BranchedBehaviour_BranchTransitionChanging;
        
        /// <summary>
        /// Gets fired when the BranchedBehaviour_BranchTransition property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> BranchedBehaviour_BranchTransitionChanged;
        
        /// <summary>
        /// Raises the BranchProbabilityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranchProbabilityChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BranchProbabilityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BranchProbabilityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranchProbabilityChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BranchProbabilityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Branch_BranchTransitionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranch_BranchTransitionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Branch_BranchTransitionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IBranch oldBranch_BranchTransition = ModelHelper.CastAs<IBranch>(oldParent);
            IBranch newBranch_BranchTransition = ModelHelper.CastAs<IBranch>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldBranch_BranchTransition, newBranch_BranchTransition);
            this.OnBranch_BranchTransitionChanging(e);
            this.OnPropertyChanging("Branch_BranchTransition");
        }
        
        /// <summary>
        /// Raises the Branch_BranchTransitionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranch_BranchTransitionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Branch_BranchTransitionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            IBranch oldBranch_BranchTransition = ModelHelper.CastAs<IBranch>(oldParent);
            IBranch newBranch_BranchTransition = ModelHelper.CastAs<IBranch>(newParent);
            if ((oldBranch_BranchTransition != null))
            {
                oldBranch_BranchTransition.BranchTransitions_Branch.Remove(this);
            }
            if ((newBranch_BranchTransition != null))
            {
                newBranch_BranchTransition.BranchTransitions_Branch.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldBranch_BranchTransition, newBranch_BranchTransition);
            this.OnBranch_BranchTransitionChanged(e);
            this.OnPropertyChanged("Branch_BranchTransition", e);
        }
        
        /// <summary>
        /// Raises the BranchedBehaviour_BranchTransitionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranchedBehaviour_BranchTransitionChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BranchedBehaviour_BranchTransitionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the BranchedBehaviour_BranchTransitionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranchedBehaviour_BranchTransitionChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.BranchedBehaviour_BranchTransitionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the BranchedBehaviour_BranchTransition property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetBranchedBehaviour_BranchTransition(object sender, System.EventArgs eventArgs)
        {
            this.BranchedBehaviour_BranchTransition = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.BranchedBehaviour_BranchTransition))
            {
                return ModelHelper.CreatePath("BranchedBehaviour_BranchTransition");
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
            if ((reference == "BRANCHEDBEHAVIOUR_BRANCHTRANSITION"))
            {
                return this.BranchedBehaviour_BranchTransition;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "BRANCHPROBABILITY"))
            {
                return this.BranchProbability;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "BRANCH_BRANCHTRANSITION"))
            {
                this.Branch_BranchTransition = ((IBranch)(value));
                return;
            }
            if ((feature == "BRANCHEDBEHAVIOUR_BRANCHTRANSITION"))
            {
                this.BranchedBehaviour_BranchTransition = ((IScenarioBehaviour)(value));
                return;
            }
            if ((feature == "BRANCHPROBABILITY"))
            {
                this.BranchProbability = ((double)(value));
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
            if ((attribute == "BRANCH_BRANCHTRANSITION"))
            {
                return new Branch_BranchTransitionProxy(this);
            }
            if ((attribute == "BRANCHEDBEHAVIOUR_BRANCHTRANSITION"))
            {
                return new BranchedBehaviour_BranchTransitionProxy(this);
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
            if ((reference == "BRANCH_BRANCHTRANSITION"))
            {
                return new Branch_BranchTransitionProxy(this);
            }
            if ((reference == "BRANCHEDBEHAVIOUR_BRANCHTRANSITION"))
            {
                return new BranchedBehaviour_BranchTransitionProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//usagemodel//BranchTransition/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BranchTransition class
        /// </summary>
        public class BranchTransitionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BranchTransition _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BranchTransitionChildrenCollection(BranchTransition parent)
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
                    if ((this._parent.BranchedBehaviour_BranchTransition != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.BranchedBehaviour_BranchTransitionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.BranchedBehaviour_BranchTransitionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.BranchedBehaviour_BranchTransition == null))
                {
                    IScenarioBehaviour branchedBehaviour_BranchTransitionCasted = item.As<IScenarioBehaviour>();
                    if ((branchedBehaviour_BranchTransitionCasted != null))
                    {
                        this._parent.BranchedBehaviour_BranchTransition = branchedBehaviour_BranchTransitionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.BranchedBehaviour_BranchTransition = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.BranchedBehaviour_BranchTransition))
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
                if ((this._parent.BranchedBehaviour_BranchTransition != null))
                {
                    array[arrayIndex] = this._parent.BranchedBehaviour_BranchTransition;
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
                if ((this._parent.BranchedBehaviour_BranchTransition == item))
                {
                    this._parent.BranchedBehaviour_BranchTransition = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.BranchedBehaviour_BranchTransition).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the BranchTransition class
        /// </summary>
        public class BranchTransitionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private BranchTransition _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public BranchTransitionReferencedElementsCollection(BranchTransition parent)
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
                    if ((this._parent.Branch_BranchTransition != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.BranchedBehaviour_BranchTransition != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Branch_BranchTransitionChanged += this.PropagateValueChanges;
                this._parent.BranchedBehaviour_BranchTransitionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Branch_BranchTransitionChanged -= this.PropagateValueChanges;
                this._parent.BranchedBehaviour_BranchTransitionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Branch_BranchTransition == null))
                {
                    IBranch branch_BranchTransitionCasted = item.As<IBranch>();
                    if ((branch_BranchTransitionCasted != null))
                    {
                        this._parent.Branch_BranchTransition = branch_BranchTransitionCasted;
                        return;
                    }
                }
                if ((this._parent.BranchedBehaviour_BranchTransition == null))
                {
                    IScenarioBehaviour branchedBehaviour_BranchTransitionCasted = item.As<IScenarioBehaviour>();
                    if ((branchedBehaviour_BranchTransitionCasted != null))
                    {
                        this._parent.BranchedBehaviour_BranchTransition = branchedBehaviour_BranchTransitionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Branch_BranchTransition = null;
                this._parent.BranchedBehaviour_BranchTransition = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Branch_BranchTransition))
                {
                    return true;
                }
                if ((item == this._parent.BranchedBehaviour_BranchTransition))
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
                if ((this._parent.Branch_BranchTransition != null))
                {
                    array[arrayIndex] = this._parent.Branch_BranchTransition;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.BranchedBehaviour_BranchTransition != null))
                {
                    array[arrayIndex] = this._parent.BranchedBehaviour_BranchTransition;
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
                if ((this._parent.Branch_BranchTransition == item))
                {
                    this._parent.Branch_BranchTransition = null;
                    return true;
                }
                if ((this._parent.BranchedBehaviour_BranchTransition == item))
                {
                    this._parent.BranchedBehaviour_BranchTransition = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Branch_BranchTransition).Concat(this._parent.BranchedBehaviour_BranchTransition).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the branchProbability property
        /// </summary>
        private sealed class BranchProbabilityProxy : ModelPropertyChange<IBranchTransition, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BranchProbabilityProxy(IBranchTransition modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override double Value
            {
                get
                {
                    return this.ModelElement.BranchProbability;
                }
                set
                {
                    this.ModelElement.BranchProbability = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.BranchProbabilityChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.BranchProbabilityChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the branch_BranchTransition property
        /// </summary>
        private sealed class Branch_BranchTransitionProxy : ModelPropertyChange<IBranchTransition, IBranch>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Branch_BranchTransitionProxy(IBranchTransition modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBranch Value
            {
                get
                {
                    return this.ModelElement.Branch_BranchTransition;
                }
                set
                {
                    this.ModelElement.Branch_BranchTransition = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Branch_BranchTransitionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Branch_BranchTransitionChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the branchedBehaviour_BranchTransition property
        /// </summary>
        private sealed class BranchedBehaviour_BranchTransitionProxy : ModelPropertyChange<IBranchTransition, IScenarioBehaviour>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BranchedBehaviour_BranchTransitionProxy(IBranchTransition modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IScenarioBehaviour Value
            {
                get
                {
                    return this.ModelElement.BranchedBehaviour_BranchTransition;
                }
                set
                {
                    this.ModelElement.BranchedBehaviour_BranchTransition = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.BranchedBehaviour_BranchTransitionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.BranchedBehaviour_BranchTransitionChanged -= handler;
            }
        }
    }
}
