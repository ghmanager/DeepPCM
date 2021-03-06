//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core;
using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.Resourcetype;
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

namespace DeepPCM.Deeppcm.Seff.Seff_performance
{
    
    
    /// <summary>
    /// The default implementation of the ParametricResourceDemand class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/SEFF_Performance/5.0")]
    [XmlNamespacePrefixAttribute("seff_performance")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//seff_performance//Parame" +
        "tricResourceDemand/")]
    public class ParametricResourceDemand : ModelElement, IParametricResourceDemand, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Specification_ParametericResourceDemand property
        /// </summary>
        private IPCMRandomVariable _specification_ParametericResourceDemand;
        
        /// <summary>
        /// The backing field for the RequiredResource_ParametricResourceDemand property
        /// </summary>
        private IProcessingResourceType _requiredResource_ParametricResourceDemand;
        
        /// <summary>
        /// The specification_ParametericResourceDemand property
        /// </summary>
        [XmlElementNameAttribute("specification_ParametericResourceDemand")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("parametricResourceDemand_PCMRandomVariable")]
        public virtual IPCMRandomVariable Specification_ParametericResourceDemand
        {
            get
            {
                return this._specification_ParametericResourceDemand;
            }
            set
            {
                if ((this._specification_ParametericResourceDemand != value))
                {
                    IPCMRandomVariable old = this._specification_ParametericResourceDemand;
                    this._specification_ParametericResourceDemand = value;
                    if ((old != null))
                    {
                        old.ParametricResourceDemand_PCMRandomVariable = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetSpecification_ParametericResourceDemand;
                    }
                    if ((value != null))
                    {
                        value.ParametricResourceDemand_PCMRandomVariable = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetSpecification_ParametericResourceDemand;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSpecification_ParametericResourceDemandChanged(e);
                    this.OnPropertyChanged("Specification_ParametericResourceDemand", e);
                }
            }
        }
        
        /// <summary>
        /// The requiredResource_ParametricResourceDemand property
        /// </summary>
        [XmlElementNameAttribute("requiredResource_ParametricResourceDemand")]
        [XmlAttributeAttribute(true)]
        public virtual IProcessingResourceType RequiredResource_ParametricResourceDemand
        {
            get
            {
                return this._requiredResource_ParametricResourceDemand;
            }
            set
            {
                if ((this._requiredResource_ParametricResourceDemand != value))
                {
                    IProcessingResourceType old = this._requiredResource_ParametricResourceDemand;
                    this._requiredResource_ParametricResourceDemand = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetRequiredResource_ParametricResourceDemand;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetRequiredResource_ParametricResourceDemand;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRequiredResource_ParametricResourceDemandChanged(e);
                    this.OnPropertyChanged("RequiredResource_ParametricResourceDemand", e);
                }
            }
        }
        
        /// <summary>
        /// The action_ParametricResourceDemand property
        /// </summary>
        [XmlElementNameAttribute("action_ParametricResourceDemand")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("resourceDemand_Action")]
        public virtual IAbstractInternalControlFlowAction Action_ParametricResourceDemand
        {
            get
            {
                return ModelHelper.CastAs<IAbstractInternalControlFlowAction>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ParametricResourceDemandChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ParametricResourceDemandReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//seff_performance//Parame" +
                        "tricResourceDemand/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Specification_ParametericResourceDemand property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Specification_ParametericResourceDemandChanged;
        
        /// <summary>
        /// Gets fired when the RequiredResource_ParametricResourceDemand property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> RequiredResource_ParametricResourceDemandChanged;
        
        /// <summary>
        /// Gets fired when the Action_ParametricResourceDemand property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Action_ParametricResourceDemandChanged;
        
        /// <summary>
        /// Raises the Specification_ParametericResourceDemandChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSpecification_ParametericResourceDemandChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Specification_ParametericResourceDemandChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Specification_ParametericResourceDemand property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSpecification_ParametericResourceDemand(object sender, EventArgs eventArgs)
        {
            this.Specification_ParametericResourceDemand = null;
        }
        
        /// <summary>
        /// Raises the RequiredResource_ParametricResourceDemandChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRequiredResource_ParametricResourceDemandChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.RequiredResource_ParametricResourceDemandChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the RequiredResource_ParametricResourceDemand property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRequiredResource_ParametricResourceDemand(object sender, EventArgs eventArgs)
        {
            this.RequiredResource_ParametricResourceDemand = null;
        }
        
        /// <summary>
        /// Raises the Action_ParametricResourceDemandChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAction_ParametricResourceDemandChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Action_ParametricResourceDemandChanged;
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
            IAbstractInternalControlFlowAction oldAction_ParametricResourceDemand = ModelHelper.CastAs<IAbstractInternalControlFlowAction>(oldParent);
            IAbstractInternalControlFlowAction newAction_ParametricResourceDemand = ModelHelper.CastAs<IAbstractInternalControlFlowAction>(newParent);
            if ((oldAction_ParametricResourceDemand != null))
            {
                oldAction_ParametricResourceDemand.ResourceDemand_Action.Remove(this);
            }
            if ((newAction_ParametricResourceDemand != null))
            {
                newAction_ParametricResourceDemand.ResourceDemand_Action.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldAction_ParametricResourceDemand, newAction_ParametricResourceDemand);
            this.OnAction_ParametricResourceDemandChanged(e);
            this.OnPropertyChanged("Action_ParametricResourceDemand", e);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Specification_ParametericResourceDemand))
            {
                return ModelHelper.CreatePath("Specification_ParametericResourceDemand");
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
            if ((reference == "SPECIFICATION_PARAMETERICRESOURCEDEMAND"))
            {
                return this.Specification_ParametericResourceDemand;
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
            if ((feature == "SPECIFICATION_PARAMETERICRESOURCEDEMAND"))
            {
                this.Specification_ParametericResourceDemand = ((IPCMRandomVariable)(value));
                return;
            }
            if ((feature == "REQUIREDRESOURCE_PARAMETRICRESOURCEDEMAND"))
            {
                this.RequiredResource_ParametricResourceDemand = ((IProcessingResourceType)(value));
                return;
            }
            if ((feature == "ACTION_PARAMETRICRESOURCEDEMAND"))
            {
                this.Action_ParametricResourceDemand = ((IAbstractInternalControlFlowAction)(value));
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
            if ((attribute == "SPECIFICATION_PARAMETERICRESOURCEDEMAND"))
            {
                return new Specification_ParametericResourceDemandProxy(this);
            }
            if ((attribute == "REQUIREDRESOURCE_PARAMETRICRESOURCEDEMAND"))
            {
                return new RequiredResource_ParametricResourceDemandProxy(this);
            }
            if ((attribute == "ACTION_PARAMETRICRESOURCEDEMAND"))
            {
                return new Action_ParametricResourceDemandProxy(this);
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
            if ((reference == "SPECIFICATION_PARAMETERICRESOURCEDEMAND"))
            {
                return new Specification_ParametericResourceDemandProxy(this);
            }
            if ((reference == "REQUIREDRESOURCE_PARAMETRICRESOURCEDEMAND"))
            {
                return new RequiredResource_ParametricResourceDemandProxy(this);
            }
            if ((reference == "ACTION_PARAMETRICRESOURCEDEMAND"))
            {
                return new Action_ParametricResourceDemandProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//seff_performance//Parame" +
                    "tricResourceDemand/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ParametricResourceDemand class
        /// </summary>
        public class ParametricResourceDemandChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ParametricResourceDemand _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ParametricResourceDemandChildrenCollection(ParametricResourceDemand parent)
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
                    if ((this._parent.Specification_ParametericResourceDemand != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Specification_ParametericResourceDemandChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Specification_ParametericResourceDemandChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Specification_ParametericResourceDemand == null))
                {
                    IPCMRandomVariable specification_ParametericResourceDemandCasted = item.As<IPCMRandomVariable>();
                    if ((specification_ParametericResourceDemandCasted != null))
                    {
                        this._parent.Specification_ParametericResourceDemand = specification_ParametericResourceDemandCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Specification_ParametericResourceDemand = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Specification_ParametericResourceDemand))
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
                if ((this._parent.Specification_ParametericResourceDemand != null))
                {
                    array[arrayIndex] = this._parent.Specification_ParametericResourceDemand;
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
                if ((this._parent.Specification_ParametericResourceDemand == item))
                {
                    this._parent.Specification_ParametericResourceDemand = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Specification_ParametericResourceDemand).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ParametricResourceDemand class
        /// </summary>
        public class ParametricResourceDemandReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ParametricResourceDemand _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ParametricResourceDemandReferencedElementsCollection(ParametricResourceDemand parent)
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
                    if ((this._parent.Specification_ParametericResourceDemand != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.RequiredResource_ParametricResourceDemand != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Action_ParametricResourceDemand != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Specification_ParametericResourceDemandChanged += this.PropagateValueChanges;
                this._parent.RequiredResource_ParametricResourceDemandChanged += this.PropagateValueChanges;
                this._parent.Action_ParametricResourceDemandChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Specification_ParametericResourceDemandChanged -= this.PropagateValueChanges;
                this._parent.RequiredResource_ParametricResourceDemandChanged -= this.PropagateValueChanges;
                this._parent.Action_ParametricResourceDemandChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Specification_ParametericResourceDemand == null))
                {
                    IPCMRandomVariable specification_ParametericResourceDemandCasted = item.As<IPCMRandomVariable>();
                    if ((specification_ParametericResourceDemandCasted != null))
                    {
                        this._parent.Specification_ParametericResourceDemand = specification_ParametericResourceDemandCasted;
                        return;
                    }
                }
                if ((this._parent.RequiredResource_ParametricResourceDemand == null))
                {
                    IProcessingResourceType requiredResource_ParametricResourceDemandCasted = item.As<IProcessingResourceType>();
                    if ((requiredResource_ParametricResourceDemandCasted != null))
                    {
                        this._parent.RequiredResource_ParametricResourceDemand = requiredResource_ParametricResourceDemandCasted;
                        return;
                    }
                }
                if ((this._parent.Action_ParametricResourceDemand == null))
                {
                    IAbstractInternalControlFlowAction action_ParametricResourceDemandCasted = item.As<IAbstractInternalControlFlowAction>();
                    if ((action_ParametricResourceDemandCasted != null))
                    {
                        this._parent.Action_ParametricResourceDemand = action_ParametricResourceDemandCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Specification_ParametericResourceDemand = null;
                this._parent.RequiredResource_ParametricResourceDemand = null;
                this._parent.Action_ParametricResourceDemand = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Specification_ParametericResourceDemand))
                {
                    return true;
                }
                if ((item == this._parent.RequiredResource_ParametricResourceDemand))
                {
                    return true;
                }
                if ((item == this._parent.Action_ParametricResourceDemand))
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
                if ((this._parent.Specification_ParametericResourceDemand != null))
                {
                    array[arrayIndex] = this._parent.Specification_ParametericResourceDemand;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.RequiredResource_ParametricResourceDemand != null))
                {
                    array[arrayIndex] = this._parent.RequiredResource_ParametricResourceDemand;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Action_ParametricResourceDemand != null))
                {
                    array[arrayIndex] = this._parent.Action_ParametricResourceDemand;
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
                if ((this._parent.Specification_ParametericResourceDemand == item))
                {
                    this._parent.Specification_ParametericResourceDemand = null;
                    return true;
                }
                if ((this._parent.RequiredResource_ParametricResourceDemand == item))
                {
                    this._parent.RequiredResource_ParametricResourceDemand = null;
                    return true;
                }
                if ((this._parent.Action_ParametricResourceDemand == item))
                {
                    this._parent.Action_ParametricResourceDemand = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Specification_ParametericResourceDemand).Concat(this._parent.RequiredResource_ParametricResourceDemand).Concat(this._parent.Action_ParametricResourceDemand).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the specification_ParametericResourceDemand property
        /// </summary>
        private sealed class Specification_ParametericResourceDemandProxy : ModelPropertyChange<IParametricResourceDemand, IPCMRandomVariable>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Specification_ParametericResourceDemandProxy(IParametricResourceDemand modelElement) : 
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
                    return this.ModelElement.Specification_ParametericResourceDemand;
                }
                set
                {
                    this.ModelElement.Specification_ParametericResourceDemand = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Specification_ParametericResourceDemandChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Specification_ParametericResourceDemandChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the requiredResource_ParametricResourceDemand property
        /// </summary>
        private sealed class RequiredResource_ParametricResourceDemandProxy : ModelPropertyChange<IParametricResourceDemand, IProcessingResourceType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RequiredResource_ParametricResourceDemandProxy(IParametricResourceDemand modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IProcessingResourceType Value
            {
                get
                {
                    return this.ModelElement.RequiredResource_ParametricResourceDemand;
                }
                set
                {
                    this.ModelElement.RequiredResource_ParametricResourceDemand = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RequiredResource_ParametricResourceDemandChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RequiredResource_ParametricResourceDemandChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the action_ParametricResourceDemand property
        /// </summary>
        private sealed class Action_ParametricResourceDemandProxy : ModelPropertyChange<IParametricResourceDemand, IAbstractInternalControlFlowAction>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Action_ParametricResourceDemandProxy(IParametricResourceDemand modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAbstractInternalControlFlowAction Value
            {
                get
                {
                    return this.ModelElement.Action_ParametricResourceDemand;
                }
                set
                {
                    this.ModelElement.Action_ParametricResourceDemand = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Action_ParametricResourceDemandChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Action_ParametricResourceDemandChanged -= handler;
            }
        }
    }
}

