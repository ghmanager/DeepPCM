//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.Units;
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

namespace Metamodel.Probfunction
{
    
    
    /// <summary>
    /// The default implementation of the ProbabilityMassFunction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0")]
    [XmlNamespacePrefixAttribute("probfunction")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/ProbFunction/1.0#//ProbabilityMassFunction/")]
    public class ProbabilityMassFunction : ProbabilityFunction, IProbabilityMassFunction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the OrderedDomain property
        /// </summary>
        private bool _orderedDomain;
        
        /// <summary>
        /// The backing field for the Samples property
        /// </summary>
        private ObservableCompositionList<ISample> _samples;
        
        private static IClass _classInstance;
        
        public ProbabilityMassFunction()
        {
            this._samples = new ObservableCompositionList<ISample>(this);
            this._samples.CollectionChanging += this.SamplesCollectionChanging;
            this._samples.CollectionChanged += this.SamplesCollectionChanged;
        }
        
        /// <summary>
        /// The orderedDomain property
        /// </summary>
        [XmlElementNameAttribute("orderedDomain")]
        [XmlAttributeAttribute(true)]
        public virtual bool OrderedDomain
        {
            get
            {
                return this._orderedDomain;
            }
            set
            {
                if ((this._orderedDomain != value))
                {
                    bool old = this._orderedDomain;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOrderedDomainChanging(e);
                    this.OnPropertyChanging("OrderedDomain", e);
                    this._orderedDomain = value;
                    this.OnOrderedDomainChanged(e);
                    this.OnPropertyChanged("OrderedDomain", e);
                }
            }
        }
        
        /// <summary>
        /// The samples property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("samples")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IListExpression<ISample> Samples
        {
            get
            {
                return this._samples;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ProbabilityMassFunctionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ProbabilityMassFunctionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//ProbabilityMassFunction/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the OrderedDomain property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OrderedDomainChanging;
        
        /// <summary>
        /// Gets fired when the OrderedDomain property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OrderedDomainChanged;
        
        /// <summary>
        /// Raises the OrderedDomainChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOrderedDomainChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OrderedDomainChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OrderedDomainChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOrderedDomainChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OrderedDomainChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Samples property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SamplesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Samples", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Samples property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SamplesCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Samples", e);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int samplesIndex = ModelHelper.IndexOfReference(this.Samples, element);
            if ((samplesIndex != -1))
            {
                return ModelHelper.CreatePath("samples", samplesIndex);
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
            if ((reference == "SAMPLES"))
            {
                if ((index < this.Samples.Count))
                {
                    return this.Samples[index];
                }
                else
                {
                    return null;
                }
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
            if ((attribute == "ORDEREDDOMAIN"))
            {
                return this.OrderedDomain;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SAMPLES"))
            {
                return this._samples;
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
            if ((feature == "ORDEREDDOMAIN"))
            {
                this.OrderedDomain = ((bool)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/ProbFunction/1.0#//ProbabilityMassFunction/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProbabilityMassFunction class
        /// </summary>
        public class ProbabilityMassFunctionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProbabilityMassFunction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProbabilityMassFunctionChildrenCollection(ProbabilityMassFunction parent)
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
                    count = (count + this._parent.Samples.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Samples.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Samples.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISample samplesCasted = item.As<ISample>();
                if ((samplesCasted != null))
                {
                    this._parent.Samples.Add(samplesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Samples.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Samples.Contains(item))
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
                IEnumerator<IModelElement> samplesEnumerator = this._parent.Samples.GetEnumerator();
                try
                {
                    for (
                    ; samplesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = samplesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    samplesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISample sampleItem = item.As<ISample>();
                if (((sampleItem != null) 
                            && this._parent.Samples.Remove(sampleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Samples).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProbabilityMassFunction class
        /// </summary>
        public class ProbabilityMassFunctionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProbabilityMassFunction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProbabilityMassFunctionReferencedElementsCollection(ProbabilityMassFunction parent)
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
                    count = (count + this._parent.Samples.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Samples.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Samples.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISample samplesCasted = item.As<ISample>();
                if ((samplesCasted != null))
                {
                    this._parent.Samples.Add(samplesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Samples.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Samples.Contains(item))
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
                IEnumerator<IModelElement> samplesEnumerator = this._parent.Samples.GetEnumerator();
                try
                {
                    for (
                    ; samplesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = samplesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    samplesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISample sampleItem = item.As<ISample>();
                if (((sampleItem != null) 
                            && this._parent.Samples.Remove(sampleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Samples).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the orderedDomain property
        /// </summary>
        private sealed class OrderedDomainProxy : ModelPropertyChange<IProbabilityMassFunction, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OrderedDomainProxy(IProbabilityMassFunction modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.OrderedDomain;
                }
                set
                {
                    this.ModelElement.OrderedDomain = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OrderedDomainChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OrderedDomainChanged -= handler;
            }
        }
    }
}
