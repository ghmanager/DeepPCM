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
using DeepPCM.Deeppcm.Core.Composition;
using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.Seff.Seff_performance;
using DeepPCM.Deeppcm.Seff.Seff_reliability;
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

namespace DeepPCM.Deeppcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the CollectionIteratorAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//CollectionIteratorAction" +
        "/")]
    [DebuggerDisplayAttribute("CollectionIteratorAction {Id}")]
    public class CollectionIteratorAction : DeepPCM.Deeppcm.Seff.AbstractLoopAction, ICollectionIteratorAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Parameter_CollectionIteratorAction property
        /// </summary>
        private DeepPCM.Deeppcm.Repository.IParameter _parameter_CollectionIteratorAction;
        
        /// <summary>
        /// The parameter_CollectionIteratorAction property
        /// </summary>
        [XmlElementNameAttribute("parameter_CollectionIteratorAction")]
        [XmlAttributeAttribute(true)]
        public virtual DeepPCM.Deeppcm.Repository.IParameter Parameter_CollectionIteratorAction
        {
            get
            {
                return this._parameter_CollectionIteratorAction;
            }
            set
            {
                if ((this._parameter_CollectionIteratorAction != value))
                {
                    DeepPCM.Deeppcm.Repository.IParameter old = this._parameter_CollectionIteratorAction;
                    this._parameter_CollectionIteratorAction = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetParameter_CollectionIteratorAction;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetParameter_CollectionIteratorAction;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnParameter_CollectionIteratorActionChanged(e);
                    this.OnPropertyChanged("Parameter_CollectionIteratorAction", e);
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
                return base.ReferencedElements.Concat(new CollectionIteratorActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//CollectionIteratorAction" +
                        "/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Parameter_CollectionIteratorAction property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Parameter_CollectionIteratorActionChanged;
        
        /// <summary>
        /// Raises the Parameter_CollectionIteratorActionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParameter_CollectionIteratorActionChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Parameter_CollectionIteratorActionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Parameter_CollectionIteratorAction property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetParameter_CollectionIteratorAction(object sender, EventArgs eventArgs)
        {
            this.Parameter_CollectionIteratorAction = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PARAMETER_COLLECTIONITERATORACTION"))
            {
                this.Parameter_CollectionIteratorAction = ((DeepPCM.Deeppcm.Repository.IParameter)(value));
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
            if ((attribute == "PARAMETER_COLLECTIONITERATORACTION"))
            {
                return new Parameter_CollectionIteratorActionProxy(this);
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
            if ((reference == "PARAMETER_COLLECTIONITERATORACTION"))
            {
                return new Parameter_CollectionIteratorActionProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//CollectionIteratorAction" +
                    "/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CollectionIteratorAction class
        /// </summary>
        public class CollectionIteratorActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CollectionIteratorAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CollectionIteratorActionReferencedElementsCollection(CollectionIteratorAction parent)
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
                    if ((this._parent.Parameter_CollectionIteratorAction != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter_CollectionIteratorActionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter_CollectionIteratorActionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Parameter_CollectionIteratorAction == null))
                {
                    DeepPCM.Deeppcm.Repository.IParameter parameter_CollectionIteratorActionCasted = item.As<DeepPCM.Deeppcm.Repository.IParameter>();
                    if ((parameter_CollectionIteratorActionCasted != null))
                    {
                        this._parent.Parameter_CollectionIteratorAction = parameter_CollectionIteratorActionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter_CollectionIteratorAction = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Parameter_CollectionIteratorAction))
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
                if ((this._parent.Parameter_CollectionIteratorAction != null))
                {
                    array[arrayIndex] = this._parent.Parameter_CollectionIteratorAction;
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
                if ((this._parent.Parameter_CollectionIteratorAction == item))
                {
                    this._parent.Parameter_CollectionIteratorAction = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter_CollectionIteratorAction).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parameter_CollectionIteratorAction property
        /// </summary>
        private sealed class Parameter_CollectionIteratorActionProxy : ModelPropertyChange<ICollectionIteratorAction, DeepPCM.Deeppcm.Repository.IParameter>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Parameter_CollectionIteratorActionProxy(ICollectionIteratorAction modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override DeepPCM.Deeppcm.Repository.IParameter Value
            {
                get
                {
                    return this.ModelElement.Parameter_CollectionIteratorAction;
                }
                set
                {
                    this.ModelElement.Parameter_CollectionIteratorAction = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Parameter_CollectionIteratorActionChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Parameter_CollectionIteratorActionChanged -= handler;
            }
        }
    }
}
