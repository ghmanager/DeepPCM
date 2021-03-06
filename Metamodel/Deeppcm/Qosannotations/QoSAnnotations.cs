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
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.System0;
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

namespace DeepPCM.Deeppcm.Qosannotations
{
    
    
    /// <summary>
    /// The default implementation of the QoSAnnotations class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/QoSAnnotations/5.0")]
    [XmlNamespacePrefixAttribute("qosannotations")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//qosannotations//QoSAnnotations" +
        "/")]
    [DebuggerDisplayAttribute("QoSAnnotations {Id}")]
    public class QoSAnnotations : DeepPCM.Deeppcm.Core.Entity.Entity, IQoSAnnotations, IModelElement
    {
        
        /// <summary>
        /// The backing field for the SpecifiedOutputParameterAbstractions_QoSAnnotations property
        /// </summary>
        private QoSAnnotationsSpecifiedOutputParameterAbstractions_QoSAnnotationsCollection _specifiedOutputParameterAbstractions_QoSAnnotations;
        
        /// <summary>
        /// The backing field for the SpecifiedQoSAnnotations_QoSAnnotations property
        /// </summary>
        private QoSAnnotationsSpecifiedQoSAnnotations_QoSAnnotationsCollection _specifiedQoSAnnotations_QoSAnnotations;
        
        public QoSAnnotations()
        {
            this._specifiedOutputParameterAbstractions_QoSAnnotations = new QoSAnnotationsSpecifiedOutputParameterAbstractions_QoSAnnotationsCollection(this);
            this._specifiedOutputParameterAbstractions_QoSAnnotations.CollectionChanged += this.SpecifiedOutputParameterAbstractions_QoSAnnotationsCollectionChanged;
            this._specifiedQoSAnnotations_QoSAnnotations = new QoSAnnotationsSpecifiedQoSAnnotations_QoSAnnotationsCollection(this);
            this._specifiedQoSAnnotations_QoSAnnotations.CollectionChanged += this.SpecifiedQoSAnnotations_QoSAnnotationsCollectionChanged;
        }
        
        /// <summary>
        /// The specifiedOutputParameterAbstractions_QoSAnnotations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("specifiedOutputParameterAbstractions_QoSAnnotations")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("qosAnnotations_SpecifiedOutputParameterAbstraction")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<ISpecifiedOutputParameterAbstraction> SpecifiedOutputParameterAbstractions_QoSAnnotations
        {
            get
            {
                return this._specifiedOutputParameterAbstractions_QoSAnnotations;
            }
        }
        
        /// <summary>
        /// The system_QoSAnnotations property
        /// </summary>
        [XmlElementNameAttribute("system_QoSAnnotations")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("qosAnnotations_System")]
        public virtual ISystem0 System_QoSAnnotations
        {
            get
            {
                return ModelHelper.CastAs<ISystem0>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The specifiedQoSAnnotations_QoSAnnotations property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("specifiedQoSAnnotations_QoSAnnotations")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("qosAnnotations_SpecifiedQoSAnnotation")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<ISpecifiedQoSAnnotation> SpecifiedQoSAnnotations_QoSAnnotations
        {
            get
            {
                return this._specifiedQoSAnnotations_QoSAnnotations;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new QoSAnnotationsChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new QoSAnnotationsReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//qosannotations//QoSAnnotations" +
                        "/");
            }
        }
        
        /// <summary>
        /// Gets fired when the System_QoSAnnotations property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> System_QoSAnnotationsChanged;
        
        /// <summary>
        /// Forwards change notifications for the SpecifiedOutputParameterAbstractions_QoSAnnotations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SpecifiedOutputParameterAbstractions_QoSAnnotationsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("SpecifiedOutputParameterAbstractions_QoSAnnotations", e);
        }
        
        /// <summary>
        /// Raises the System_QoSAnnotationsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystem_QoSAnnotationsChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.System_QoSAnnotationsChanged;
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
            ISystem0 oldSystem_QoSAnnotations = ModelHelper.CastAs<ISystem0>(oldParent);
            ISystem0 newSystem_QoSAnnotations = ModelHelper.CastAs<ISystem0>(newParent);
            if ((oldSystem_QoSAnnotations != null))
            {
                oldSystem_QoSAnnotations.QosAnnotations_System.Remove(this);
            }
            if ((newSystem_QoSAnnotations != null))
            {
                newSystem_QoSAnnotations.QosAnnotations_System.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldSystem_QoSAnnotations, newSystem_QoSAnnotations);
            this.OnSystem_QoSAnnotationsChanged(e);
            this.OnPropertyChanged("System_QoSAnnotations", e);
        }
        
        /// <summary>
        /// Forwards change notifications for the SpecifiedQoSAnnotations_QoSAnnotations property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void SpecifiedQoSAnnotations_QoSAnnotationsCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("SpecifiedQoSAnnotations_QoSAnnotations", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "SPECIFIEDOUTPUTPARAMETERABSTRACTIONS_QOSANNOTATIONS"))
            {
                return this._specifiedOutputParameterAbstractions_QoSAnnotations;
            }
            if ((feature == "SPECIFIEDQOSANNOTATIONS_QOSANNOTATIONS"))
            {
                return this._specifiedQoSAnnotations_QoSAnnotations;
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
            if ((feature == "SYSTEM_QOSANNOTATIONS"))
            {
                this.System_QoSAnnotations = ((ISystem0)(value));
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
            if ((attribute == "SYSTEM_QOSANNOTATIONS"))
            {
                return new System_QoSAnnotationsProxy(this);
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
            if ((reference == "SYSTEM_QOSANNOTATIONS"))
            {
                return new System_QoSAnnotationsProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//qosannotations//QoSAnnotations" +
                    "/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the QoSAnnotations class
        /// </summary>
        public class QoSAnnotationsChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private QoSAnnotations _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public QoSAnnotationsChildrenCollection(QoSAnnotations parent)
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
                    count = (count + this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Count);
                    count = (count + this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.SpecifiedQoSAnnotations_QoSAnnotations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.SpecifiedQoSAnnotations_QoSAnnotations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISpecifiedOutputParameterAbstraction specifiedOutputParameterAbstractions_QoSAnnotationsCasted = item.As<ISpecifiedOutputParameterAbstraction>();
                if ((specifiedOutputParameterAbstractions_QoSAnnotationsCasted != null))
                {
                    this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Add(specifiedOutputParameterAbstractions_QoSAnnotationsCasted);
                }
                ISpecifiedQoSAnnotation specifiedQoSAnnotations_QoSAnnotationsCasted = item.As<ISpecifiedQoSAnnotation>();
                if ((specifiedQoSAnnotations_QoSAnnotationsCasted != null))
                {
                    this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Add(specifiedQoSAnnotations_QoSAnnotationsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Clear();
                this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Contains(item))
                {
                    return true;
                }
                if (this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Contains(item))
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
                IEnumerator<IModelElement> specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator = this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.GetEnumerator();
                try
                {
                    for (
                    ; specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> specifiedQoSAnnotations_QoSAnnotationsEnumerator = this._parent.SpecifiedQoSAnnotations_QoSAnnotations.GetEnumerator();
                try
                {
                    for (
                    ; specifiedQoSAnnotations_QoSAnnotationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = specifiedQoSAnnotations_QoSAnnotationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    specifiedQoSAnnotations_QoSAnnotationsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISpecifiedOutputParameterAbstraction specifiedOutputParameterAbstractionItem = item.As<ISpecifiedOutputParameterAbstraction>();
                if (((specifiedOutputParameterAbstractionItem != null) 
                            && this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Remove(specifiedOutputParameterAbstractionItem)))
                {
                    return true;
                }
                ISpecifiedQoSAnnotation specifiedQoSAnnotationItem = item.As<ISpecifiedQoSAnnotation>();
                if (((specifiedQoSAnnotationItem != null) 
                            && this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Remove(specifiedQoSAnnotationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations).Concat(this._parent.SpecifiedQoSAnnotations_QoSAnnotations).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the QoSAnnotations class
        /// </summary>
        public class QoSAnnotationsReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private QoSAnnotations _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public QoSAnnotationsReferencedElementsCollection(QoSAnnotations parent)
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
                    count = (count + this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Count);
                    if ((this._parent.System_QoSAnnotations != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.System_QoSAnnotationsChanged += this.PropagateValueChanges;
                this._parent.SpecifiedQoSAnnotations_QoSAnnotations.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.System_QoSAnnotationsChanged -= this.PropagateValueChanges;
                this._parent.SpecifiedQoSAnnotations_QoSAnnotations.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ISpecifiedOutputParameterAbstraction specifiedOutputParameterAbstractions_QoSAnnotationsCasted = item.As<ISpecifiedOutputParameterAbstraction>();
                if ((specifiedOutputParameterAbstractions_QoSAnnotationsCasted != null))
                {
                    this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Add(specifiedOutputParameterAbstractions_QoSAnnotationsCasted);
                }
                if ((this._parent.System_QoSAnnotations == null))
                {
                    ISystem0 system_QoSAnnotationsCasted = item.As<ISystem0>();
                    if ((system_QoSAnnotationsCasted != null))
                    {
                        this._parent.System_QoSAnnotations = system_QoSAnnotationsCasted;
                        return;
                    }
                }
                ISpecifiedQoSAnnotation specifiedQoSAnnotations_QoSAnnotationsCasted = item.As<ISpecifiedQoSAnnotation>();
                if ((specifiedQoSAnnotations_QoSAnnotationsCasted != null))
                {
                    this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Add(specifiedQoSAnnotations_QoSAnnotationsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Clear();
                this._parent.System_QoSAnnotations = null;
                this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.System_QoSAnnotations))
                {
                    return true;
                }
                if (this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Contains(item))
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
                IEnumerator<IModelElement> specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator = this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.GetEnumerator();
                try
                {
                    for (
                    ; specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    specifiedOutputParameterAbstractions_QoSAnnotationsEnumerator.Dispose();
                }
                if ((this._parent.System_QoSAnnotations != null))
                {
                    array[arrayIndex] = this._parent.System_QoSAnnotations;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> specifiedQoSAnnotations_QoSAnnotationsEnumerator = this._parent.SpecifiedQoSAnnotations_QoSAnnotations.GetEnumerator();
                try
                {
                    for (
                    ; specifiedQoSAnnotations_QoSAnnotationsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = specifiedQoSAnnotations_QoSAnnotationsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    specifiedQoSAnnotations_QoSAnnotationsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ISpecifiedOutputParameterAbstraction specifiedOutputParameterAbstractionItem = item.As<ISpecifiedOutputParameterAbstraction>();
                if (((specifiedOutputParameterAbstractionItem != null) 
                            && this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations.Remove(specifiedOutputParameterAbstractionItem)))
                {
                    return true;
                }
                if ((this._parent.System_QoSAnnotations == item))
                {
                    this._parent.System_QoSAnnotations = null;
                    return true;
                }
                ISpecifiedQoSAnnotation specifiedQoSAnnotationItem = item.As<ISpecifiedQoSAnnotation>();
                if (((specifiedQoSAnnotationItem != null) 
                            && this._parent.SpecifiedQoSAnnotations_QoSAnnotations.Remove(specifiedQoSAnnotationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.SpecifiedOutputParameterAbstractions_QoSAnnotations).Concat(this._parent.System_QoSAnnotations).Concat(this._parent.SpecifiedQoSAnnotations_QoSAnnotations).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the system_QoSAnnotations property
        /// </summary>
        private sealed class System_QoSAnnotationsProxy : ModelPropertyChange<IQoSAnnotations, ISystem0>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public System_QoSAnnotationsProxy(IQoSAnnotations modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISystem0 Value
            {
                get
                {
                    return this.ModelElement.System_QoSAnnotations;
                }
                set
                {
                    this.ModelElement.System_QoSAnnotations = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.System_QoSAnnotationsChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.System_QoSAnnotationsChanged -= handler;
            }
        }
    }
}

