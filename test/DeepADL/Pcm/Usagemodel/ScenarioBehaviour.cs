//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Composition;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Repository;
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

namespace GeneratedCode.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The default implementation of the ScenarioBehaviour class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/UsageModel/5.0")]
    [XmlNamespacePrefixAttribute("usagemodel")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel//ScenarioBehaviour/" +
        "")]
    [DebuggerDisplayAttribute("ScenarioBehaviour {Id}")]
    public class ScenarioBehaviour : GeneratedCode.Pcm.Core.Entity.Entity, IScenarioBehaviour, IModelElement
    {
        
        /// <summary>
        /// The backing field for the UsageScenario_SenarioBehaviour property
        /// </summary>
        private IUsageScenario _usageScenario_SenarioBehaviour;
        
        /// <summary>
        /// The backing field for the BranchTransition_ScenarioBehaviour property
        /// </summary>
        private IBranchTransition _branchTransition_ScenarioBehaviour;
        
        /// <summary>
        /// The backing field for the Loop_ScenarioBehaviour property
        /// </summary>
        private ILoop _loop_ScenarioBehaviour;
        
        /// <summary>
        /// The backing field for the Actions_ScenarioBehaviour property
        /// </summary>
        private ScenarioBehaviourActions_ScenarioBehaviourCollection _actions_ScenarioBehaviour;
        
        public ScenarioBehaviour()
        {
            this._actions_ScenarioBehaviour = new ScenarioBehaviourActions_ScenarioBehaviourCollection(this);
            this._actions_ScenarioBehaviour.CollectionChanged += this.Actions_ScenarioBehaviourCollectionChanged;
        }
        
        /// <summary>
        /// The usageScenario_SenarioBehaviour property
        /// </summary>
        [XmlElementNameAttribute("usageScenario_SenarioBehaviour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("scenarioBehaviour_UsageScenario")]
        public virtual IUsageScenario UsageScenario_SenarioBehaviour
        {
            get
            {
                return this._usageScenario_SenarioBehaviour;
            }
            set
            {
                if ((this._usageScenario_SenarioBehaviour != value))
                {
                    IUsageScenario old = this._usageScenario_SenarioBehaviour;
                    this._usageScenario_SenarioBehaviour = value;
                    if ((old != null))
                    {
                        old.ScenarioBehaviour_UsageScenario = null;
                        old.Deleted -= this.OnResetUsageScenario_SenarioBehaviour;
                    }
                    if ((value != null))
                    {
                        value.ScenarioBehaviour_UsageScenario = this;
                        value.Deleted += this.OnResetUsageScenario_SenarioBehaviour;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUsageScenario_SenarioBehaviourChanged(e);
                    this.OnPropertyChanged("UsageScenario_SenarioBehaviour", e);
                }
            }
        }
        
        /// <summary>
        /// The branchTransition_ScenarioBehaviour property
        /// </summary>
        [XmlElementNameAttribute("branchTransition_ScenarioBehaviour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("branchedBehaviour_BranchTransition")]
        public virtual IBranchTransition BranchTransition_ScenarioBehaviour
        {
            get
            {
                return this._branchTransition_ScenarioBehaviour;
            }
            set
            {
                if ((this._branchTransition_ScenarioBehaviour != value))
                {
                    IBranchTransition old = this._branchTransition_ScenarioBehaviour;
                    this._branchTransition_ScenarioBehaviour = value;
                    if ((old != null))
                    {
                        old.BranchedBehaviour_BranchTransition = null;
                        old.Deleted -= this.OnResetBranchTransition_ScenarioBehaviour;
                    }
                    if ((value != null))
                    {
                        value.BranchedBehaviour_BranchTransition = this;
                        value.Deleted += this.OnResetBranchTransition_ScenarioBehaviour;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnBranchTransition_ScenarioBehaviourChanged(e);
                    this.OnPropertyChanged("BranchTransition_ScenarioBehaviour", e);
                }
            }
        }
        
        /// <summary>
        /// The loop_ScenarioBehaviour property
        /// </summary>
        [XmlElementNameAttribute("loop_ScenarioBehaviour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("bodyBehaviour_Loop")]
        public virtual ILoop Loop_ScenarioBehaviour
        {
            get
            {
                return this._loop_ScenarioBehaviour;
            }
            set
            {
                if ((this._loop_ScenarioBehaviour != value))
                {
                    ILoop old = this._loop_ScenarioBehaviour;
                    this._loop_ScenarioBehaviour = value;
                    if ((old != null))
                    {
                        old.BodyBehaviour_Loop = null;
                        old.Deleted -= this.OnResetLoop_ScenarioBehaviour;
                    }
                    if ((value != null))
                    {
                        value.BodyBehaviour_Loop = this;
                        value.Deleted += this.OnResetLoop_ScenarioBehaviour;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLoop_ScenarioBehaviourChanged(e);
                    this.OnPropertyChanged("Loop_ScenarioBehaviour", e);
                }
            }
        }
        
        /// <summary>
        /// The actions_ScenarioBehaviour property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("actions_ScenarioBehaviour")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("scenarioBehaviour_AbstractUserAction")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IAbstractUserAction> Actions_ScenarioBehaviour
        {
            get
            {
                return this._actions_ScenarioBehaviour;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ScenarioBehaviourChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ScenarioBehaviourReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel//ScenarioBehaviour/" +
                        "");
            }
        }
        
        /// <summary>
        /// Gets fired when the UsageScenario_SenarioBehaviour property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> UsageScenario_SenarioBehaviourChanged;
        
        /// <summary>
        /// Gets fired when the BranchTransition_ScenarioBehaviour property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> BranchTransition_ScenarioBehaviourChanged;
        
        /// <summary>
        /// Gets fired when the Loop_ScenarioBehaviour property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Loop_ScenarioBehaviourChanged;
        
        /// <summary>
        /// Raises the UsageScenario_SenarioBehaviourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUsageScenario_SenarioBehaviourChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.UsageScenario_SenarioBehaviourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the UsageScenario_SenarioBehaviour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetUsageScenario_SenarioBehaviour(object sender, EventArgs eventArgs)
        {
            this.UsageScenario_SenarioBehaviour = null;
        }
        
        /// <summary>
        /// Raises the BranchTransition_ScenarioBehaviourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnBranchTransition_ScenarioBehaviourChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.BranchTransition_ScenarioBehaviourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the BranchTransition_ScenarioBehaviour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetBranchTransition_ScenarioBehaviour(object sender, EventArgs eventArgs)
        {
            this.BranchTransition_ScenarioBehaviour = null;
        }
        
        /// <summary>
        /// Raises the Loop_ScenarioBehaviourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLoop_ScenarioBehaviourChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Loop_ScenarioBehaviourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Loop_ScenarioBehaviour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLoop_ScenarioBehaviour(object sender, EventArgs eventArgs)
        {
            this.Loop_ScenarioBehaviour = null;
        }
        
        /// <summary>
        /// Forwards change notifications for the Actions_ScenarioBehaviour property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Actions_ScenarioBehaviourCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Actions_ScenarioBehaviour", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "ACTIONS_SCENARIOBEHAVIOUR"))
            {
                return this._actions_ScenarioBehaviour;
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
            if ((feature == "USAGESCENARIO_SENARIOBEHAVIOUR"))
            {
                this.UsageScenario_SenarioBehaviour = ((IUsageScenario)(value));
                return;
            }
            if ((feature == "BRANCHTRANSITION_SCENARIOBEHAVIOUR"))
            {
                this.BranchTransition_ScenarioBehaviour = ((IBranchTransition)(value));
                return;
            }
            if ((feature == "LOOP_SCENARIOBEHAVIOUR"))
            {
                this.Loop_ScenarioBehaviour = ((ILoop)(value));
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
            if ((attribute == "USAGESCENARIO_SENARIOBEHAVIOUR"))
            {
                return new UsageScenario_SenarioBehaviourProxy(this);
            }
            if ((attribute == "BRANCHTRANSITION_SCENARIOBEHAVIOUR"))
            {
                return new BranchTransition_ScenarioBehaviourProxy(this);
            }
            if ((attribute == "LOOP_SCENARIOBEHAVIOUR"))
            {
                return new Loop_ScenarioBehaviourProxy(this);
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
            if ((reference == "USAGESCENARIO_SENARIOBEHAVIOUR"))
            {
                return new UsageScenario_SenarioBehaviourProxy(this);
            }
            if ((reference == "BRANCHTRANSITION_SCENARIOBEHAVIOUR"))
            {
                return new BranchTransition_ScenarioBehaviourProxy(this);
            }
            if ((reference == "LOOP_SCENARIOBEHAVIOUR"))
            {
                return new Loop_ScenarioBehaviourProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel//ScenarioBehaviour/" +
                    "")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ScenarioBehaviour class
        /// </summary>
        public class ScenarioBehaviourChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ScenarioBehaviour _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ScenarioBehaviourChildrenCollection(ScenarioBehaviour parent)
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
                    count = (count + this._parent.Actions_ScenarioBehaviour.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Actions_ScenarioBehaviour.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Actions_ScenarioBehaviour.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAbstractUserAction actions_ScenarioBehaviourCasted = item.As<IAbstractUserAction>();
                if ((actions_ScenarioBehaviourCasted != null))
                {
                    this._parent.Actions_ScenarioBehaviour.Add(actions_ScenarioBehaviourCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Actions_ScenarioBehaviour.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Actions_ScenarioBehaviour.Contains(item))
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
                IEnumerator<IModelElement> actions_ScenarioBehaviourEnumerator = this._parent.Actions_ScenarioBehaviour.GetEnumerator();
                try
                {
                    for (
                    ; actions_ScenarioBehaviourEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = actions_ScenarioBehaviourEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    actions_ScenarioBehaviourEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAbstractUserAction abstractUserActionItem = item.As<IAbstractUserAction>();
                if (((abstractUserActionItem != null) 
                            && this._parent.Actions_ScenarioBehaviour.Remove(abstractUserActionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Actions_ScenarioBehaviour).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ScenarioBehaviour class
        /// </summary>
        public class ScenarioBehaviourReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ScenarioBehaviour _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ScenarioBehaviourReferencedElementsCollection(ScenarioBehaviour parent)
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
                    if ((this._parent.UsageScenario_SenarioBehaviour != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.BranchTransition_ScenarioBehaviour != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Loop_ScenarioBehaviour != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Actions_ScenarioBehaviour.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.UsageScenario_SenarioBehaviourChanged += this.PropagateValueChanges;
                this._parent.BranchTransition_ScenarioBehaviourChanged += this.PropagateValueChanges;
                this._parent.Loop_ScenarioBehaviourChanged += this.PropagateValueChanges;
                this._parent.Actions_ScenarioBehaviour.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.UsageScenario_SenarioBehaviourChanged -= this.PropagateValueChanges;
                this._parent.BranchTransition_ScenarioBehaviourChanged -= this.PropagateValueChanges;
                this._parent.Loop_ScenarioBehaviourChanged -= this.PropagateValueChanges;
                this._parent.Actions_ScenarioBehaviour.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.UsageScenario_SenarioBehaviour == null))
                {
                    IUsageScenario usageScenario_SenarioBehaviourCasted = item.As<IUsageScenario>();
                    if ((usageScenario_SenarioBehaviourCasted != null))
                    {
                        this._parent.UsageScenario_SenarioBehaviour = usageScenario_SenarioBehaviourCasted;
                        return;
                    }
                }
                if ((this._parent.BranchTransition_ScenarioBehaviour == null))
                {
                    IBranchTransition branchTransition_ScenarioBehaviourCasted = item.As<IBranchTransition>();
                    if ((branchTransition_ScenarioBehaviourCasted != null))
                    {
                        this._parent.BranchTransition_ScenarioBehaviour = branchTransition_ScenarioBehaviourCasted;
                        return;
                    }
                }
                if ((this._parent.Loop_ScenarioBehaviour == null))
                {
                    ILoop loop_ScenarioBehaviourCasted = item.As<ILoop>();
                    if ((loop_ScenarioBehaviourCasted != null))
                    {
                        this._parent.Loop_ScenarioBehaviour = loop_ScenarioBehaviourCasted;
                        return;
                    }
                }
                IAbstractUserAction actions_ScenarioBehaviourCasted = item.As<IAbstractUserAction>();
                if ((actions_ScenarioBehaviourCasted != null))
                {
                    this._parent.Actions_ScenarioBehaviour.Add(actions_ScenarioBehaviourCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.UsageScenario_SenarioBehaviour = null;
                this._parent.BranchTransition_ScenarioBehaviour = null;
                this._parent.Loop_ScenarioBehaviour = null;
                this._parent.Actions_ScenarioBehaviour.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.UsageScenario_SenarioBehaviour))
                {
                    return true;
                }
                if ((item == this._parent.BranchTransition_ScenarioBehaviour))
                {
                    return true;
                }
                if ((item == this._parent.Loop_ScenarioBehaviour))
                {
                    return true;
                }
                if (this._parent.Actions_ScenarioBehaviour.Contains(item))
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
                if ((this._parent.UsageScenario_SenarioBehaviour != null))
                {
                    array[arrayIndex] = this._parent.UsageScenario_SenarioBehaviour;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.BranchTransition_ScenarioBehaviour != null))
                {
                    array[arrayIndex] = this._parent.BranchTransition_ScenarioBehaviour;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Loop_ScenarioBehaviour != null))
                {
                    array[arrayIndex] = this._parent.Loop_ScenarioBehaviour;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> actions_ScenarioBehaviourEnumerator = this._parent.Actions_ScenarioBehaviour.GetEnumerator();
                try
                {
                    for (
                    ; actions_ScenarioBehaviourEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = actions_ScenarioBehaviourEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    actions_ScenarioBehaviourEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.UsageScenario_SenarioBehaviour == item))
                {
                    this._parent.UsageScenario_SenarioBehaviour = null;
                    return true;
                }
                if ((this._parent.BranchTransition_ScenarioBehaviour == item))
                {
                    this._parent.BranchTransition_ScenarioBehaviour = null;
                    return true;
                }
                if ((this._parent.Loop_ScenarioBehaviour == item))
                {
                    this._parent.Loop_ScenarioBehaviour = null;
                    return true;
                }
                IAbstractUserAction abstractUserActionItem = item.As<IAbstractUserAction>();
                if (((abstractUserActionItem != null) 
                            && this._parent.Actions_ScenarioBehaviour.Remove(abstractUserActionItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.UsageScenario_SenarioBehaviour).Concat(this._parent.BranchTransition_ScenarioBehaviour).Concat(this._parent.Loop_ScenarioBehaviour).Concat(this._parent.Actions_ScenarioBehaviour).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the usageScenario_SenarioBehaviour property
        /// </summary>
        private sealed class UsageScenario_SenarioBehaviourProxy : ModelPropertyChange<IScenarioBehaviour, IUsageScenario>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UsageScenario_SenarioBehaviourProxy(IScenarioBehaviour modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IUsageScenario Value
            {
                get
                {
                    return this.ModelElement.UsageScenario_SenarioBehaviour;
                }
                set
                {
                    this.ModelElement.UsageScenario_SenarioBehaviour = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UsageScenario_SenarioBehaviourChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UsageScenario_SenarioBehaviourChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the branchTransition_ScenarioBehaviour property
        /// </summary>
        private sealed class BranchTransition_ScenarioBehaviourProxy : ModelPropertyChange<IScenarioBehaviour, IBranchTransition>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public BranchTransition_ScenarioBehaviourProxy(IScenarioBehaviour modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBranchTransition Value
            {
                get
                {
                    return this.ModelElement.BranchTransition_ScenarioBehaviour;
                }
                set
                {
                    this.ModelElement.BranchTransition_ScenarioBehaviour = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.BranchTransition_ScenarioBehaviourChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.BranchTransition_ScenarioBehaviourChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the loop_ScenarioBehaviour property
        /// </summary>
        private sealed class Loop_ScenarioBehaviourProxy : ModelPropertyChange<IScenarioBehaviour, ILoop>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Loop_ScenarioBehaviourProxy(IScenarioBehaviour modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ILoop Value
            {
                get
                {
                    return this.ModelElement.Loop_ScenarioBehaviour;
                }
                set
                {
                    this.ModelElement.Loop_ScenarioBehaviour = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Loop_ScenarioBehaviourChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Loop_ScenarioBehaviourChanged -= handler;
            }
        }
    }
}
