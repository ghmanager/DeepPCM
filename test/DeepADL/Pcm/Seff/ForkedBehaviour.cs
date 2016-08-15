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
    /// The default implementation of the ForkedBehaviour class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//ForkedBehaviour/")]
    [DebuggerDisplayAttribute("ForkedBehaviour {Id}")]
    public class ForkedBehaviour : ResourceDemandingBehaviour, IForkedBehaviour, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SynchronisationPoint_ForkedBehaviour property
        /// </summary>
        private ISynchronisationPoint _synchronisationPoint_ForkedBehaviour;
        
        /// <summary>
        /// The backing field for the ForkAction_ForkedBehaivour property
        /// </summary>
        private IForkAction _forkAction_ForkedBehaivour;
        
        /// <summary>
        /// The synchronisationPoint_ForkedBehaviour property
        /// </summary>
        [XmlElementNameAttribute("synchronisationPoint_ForkedBehaviour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("synchronousForkedBehaviours_SynchronisationPoint")]
        public virtual ISynchronisationPoint SynchronisationPoint_ForkedBehaviour
        {
            get
            {
                return this._synchronisationPoint_ForkedBehaviour;
            }
            set
            {
                if ((this._synchronisationPoint_ForkedBehaviour != value))
                {
                    ISynchronisationPoint old = this._synchronisationPoint_ForkedBehaviour;
                    this._synchronisationPoint_ForkedBehaviour = value;
                    if ((old != null))
                    {
                        old.SynchronousForkedBehaviours_SynchronisationPoint.Remove(this);
                        old.Deleted -= this.OnResetSynchronisationPoint_ForkedBehaviour;
                    }
                    if ((value != null))
                    {
                        if ((value.SynchronousForkedBehaviours_SynchronisationPoint.Contains(this) != true))
                        {
                            value.SynchronousForkedBehaviours_SynchronisationPoint.Add(this);
                        }
                        value.Deleted += this.OnResetSynchronisationPoint_ForkedBehaviour;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSynchronisationPoint_ForkedBehaviourChanged(e);
                    this.OnPropertyChanged("SynchronisationPoint_ForkedBehaviour", e);
                }
            }
        }
        
        /// <summary>
        /// The forkAction_ForkedBehaivour property
        /// </summary>
        [XmlElementNameAttribute("forkAction_ForkedBehaivour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("asynchronousForkedBehaviours_ForkAction")]
        public virtual IForkAction ForkAction_ForkedBehaivour
        {
            get
            {
                return this._forkAction_ForkedBehaivour;
            }
            set
            {
                if ((this._forkAction_ForkedBehaivour != value))
                {
                    IForkAction old = this._forkAction_ForkedBehaivour;
                    this._forkAction_ForkedBehaivour = value;
                    if ((old != null))
                    {
                        old.AsynchronousForkedBehaviours_ForkAction.Remove(this);
                        old.Deleted -= this.OnResetForkAction_ForkedBehaivour;
                    }
                    if ((value != null))
                    {
                        if ((value.AsynchronousForkedBehaviours_ForkAction.Contains(this) != true))
                        {
                            value.AsynchronousForkedBehaviours_ForkAction.Add(this);
                        }
                        value.Deleted += this.OnResetForkAction_ForkedBehaivour;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnForkAction_ForkedBehaivourChanged(e);
                    this.OnPropertyChanged("ForkAction_ForkedBehaivour", e);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ForkedBehaviourReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//ForkedBehaviour/");
            }
        }
        
        /// <summary>
        /// Gets fired when the SynchronisationPoint_ForkedBehaviour property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> SynchronisationPoint_ForkedBehaviourChanged;
        
        /// <summary>
        /// Gets fired when the ForkAction_ForkedBehaivour property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ForkAction_ForkedBehaivourChanged;
        
        /// <summary>
        /// Raises the SynchronisationPoint_ForkedBehaviourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSynchronisationPoint_ForkedBehaviourChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.SynchronisationPoint_ForkedBehaviourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the SynchronisationPoint_ForkedBehaviour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSynchronisationPoint_ForkedBehaviour(object sender, EventArgs eventArgs)
        {
            this.SynchronisationPoint_ForkedBehaviour = null;
        }
        
        /// <summary>
        /// Raises the ForkAction_ForkedBehaivourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnForkAction_ForkedBehaivourChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ForkAction_ForkedBehaivourChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ForkAction_ForkedBehaivour property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetForkAction_ForkedBehaivour(object sender, EventArgs eventArgs)
        {
            this.ForkAction_ForkedBehaivour = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SYNCHRONISATIONPOINT_FORKEDBEHAVIOUR"))
            {
                this.SynchronisationPoint_ForkedBehaviour = ((ISynchronisationPoint)(value));
                return;
            }
            if ((feature == "FORKACTION_FORKEDBEHAIVOUR"))
            {
                this.ForkAction_ForkedBehaivour = ((IForkAction)(value));
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
            if ((attribute == "SYNCHRONISATIONPOINT_FORKEDBEHAVIOUR"))
            {
                return new SynchronisationPoint_ForkedBehaviourProxy(this);
            }
            if ((attribute == "FORKACTION_FORKEDBEHAIVOUR"))
            {
                return new ForkAction_ForkedBehaivourProxy(this);
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
            if ((reference == "SYNCHRONISATIONPOINT_FORKEDBEHAVIOUR"))
            {
                return new SynchronisationPoint_ForkedBehaviourProxy(this);
            }
            if ((reference == "FORKACTION_FORKEDBEHAIVOUR"))
            {
                return new ForkAction_ForkedBehaivourProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//ForkedBehaviour/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ForkedBehaviour class
        /// </summary>
        public class ForkedBehaviourReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ForkedBehaviour _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ForkedBehaviourReferencedElementsCollection(ForkedBehaviour parent)
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
                    if ((this._parent.SynchronisationPoint_ForkedBehaviour != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ForkAction_ForkedBehaivour != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SynchronisationPoint_ForkedBehaviourChanged += this.PropagateValueChanges;
                this._parent.ForkAction_ForkedBehaivourChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SynchronisationPoint_ForkedBehaviourChanged -= this.PropagateValueChanges;
                this._parent.ForkAction_ForkedBehaivourChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.SynchronisationPoint_ForkedBehaviour == null))
                {
                    ISynchronisationPoint synchronisationPoint_ForkedBehaviourCasted = item.As<ISynchronisationPoint>();
                    if ((synchronisationPoint_ForkedBehaviourCasted != null))
                    {
                        this._parent.SynchronisationPoint_ForkedBehaviour = synchronisationPoint_ForkedBehaviourCasted;
                        return;
                    }
                }
                if ((this._parent.ForkAction_ForkedBehaivour == null))
                {
                    IForkAction forkAction_ForkedBehaivourCasted = item.As<IForkAction>();
                    if ((forkAction_ForkedBehaivourCasted != null))
                    {
                        this._parent.ForkAction_ForkedBehaivour = forkAction_ForkedBehaivourCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SynchronisationPoint_ForkedBehaviour = null;
                this._parent.ForkAction_ForkedBehaivour = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.SynchronisationPoint_ForkedBehaviour))
                {
                    return true;
                }
                if ((item == this._parent.ForkAction_ForkedBehaivour))
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
                if ((this._parent.SynchronisationPoint_ForkedBehaviour != null))
                {
                    array[arrayIndex] = this._parent.SynchronisationPoint_ForkedBehaviour;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ForkAction_ForkedBehaivour != null))
                {
                    array[arrayIndex] = this._parent.ForkAction_ForkedBehaivour;
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
                if ((this._parent.SynchronisationPoint_ForkedBehaviour == item))
                {
                    this._parent.SynchronisationPoint_ForkedBehaviour = null;
                    return true;
                }
                if ((this._parent.ForkAction_ForkedBehaivour == item))
                {
                    this._parent.ForkAction_ForkedBehaivour = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SynchronisationPoint_ForkedBehaviour).Concat(this._parent.ForkAction_ForkedBehaivour).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the synchronisationPoint_ForkedBehaviour property
        /// </summary>
        private sealed class SynchronisationPoint_ForkedBehaviourProxy : ModelPropertyChange<IForkedBehaviour, ISynchronisationPoint>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public SynchronisationPoint_ForkedBehaviourProxy(IForkedBehaviour modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISynchronisationPoint Value
            {
                get
                {
                    return this.ModelElement.SynchronisationPoint_ForkedBehaviour;
                }
                set
                {
                    this.ModelElement.SynchronisationPoint_ForkedBehaviour = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SynchronisationPoint_ForkedBehaviourChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.SynchronisationPoint_ForkedBehaviourChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the forkAction_ForkedBehaivour property
        /// </summary>
        private sealed class ForkAction_ForkedBehaivourProxy : ModelPropertyChange<IForkedBehaviour, IForkAction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ForkAction_ForkedBehaivourProxy(IForkedBehaviour modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IForkAction Value
            {
                get
                {
                    return this.ModelElement.ForkAction_ForkedBehaivour;
                }
                set
                {
                    this.ModelElement.ForkAction_ForkedBehaivour = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ForkAction_ForkedBehaivourChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ForkAction_ForkedBehaivourChanged -= handler;
            }
        }
    }
}

