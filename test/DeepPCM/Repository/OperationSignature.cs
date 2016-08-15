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
using Metamodel.DeepPCM.Protocol;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Resourcetype;
using Metamodel.DeepPCM.Seff;
using Metamodel.DeepPCM.System0;
using Metamodel.Identifier;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Repository
{
    
    
    /// <summary>
    /// The default implementation of the OperationSignature class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/Repository/1.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//repository//OperationSignature/")]
    [DebuggerDisplayAttribute("OperationSignature {Id}")]
    public class OperationSignature : Signature, IOperationSignature, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Parameters__OperationSignature property
        /// </summary>
        private OperationSignatureParameters__OperationSignatureCollection _parameters__OperationSignature;
        
        /// <summary>
        /// The backing field for the ReturnType__OperationSignature property
        /// </summary>
        private IDataType _returnType__OperationSignature;
        
        private static IClass _classInstance;
        
        public OperationSignature()
        {
            this._parameters__OperationSignature = new OperationSignatureParameters__OperationSignatureCollection(this);
            this._parameters__OperationSignature.CollectionChanging += this.Parameters__OperationSignatureCollectionChanging;
            this._parameters__OperationSignature.CollectionChanged += this.Parameters__OperationSignatureCollectionChanged;
        }
        
        /// <summary>
        /// The interface__OperationSignature property
        /// </summary>
        [XmlElementNameAttribute("interface__OperationSignature")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("signatures__OperationInterface")]
        public virtual IOperationInterface Interface__OperationSignature
        {
            get
            {
                return ModelHelper.CastAs<IOperationInterface>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The parameters__OperationSignature property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("parameters__OperationSignature")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("operationSignature__Parameter")]
        [ConstantAttribute()]
        public virtual IListExpression<Metamodel.DeepPCM.Repository.IParameter> Parameters__OperationSignature
        {
            get
            {
                return this._parameters__OperationSignature;
            }
        }
        
        /// <summary>
        /// The returnType__OperationSignature property
        /// </summary>
        [XmlElementNameAttribute("returnType__OperationSignature")]
        [XmlAttributeAttribute(true)]
        public virtual IDataType ReturnType__OperationSignature
        {
            get
            {
                return this._returnType__OperationSignature;
            }
            set
            {
                if ((this._returnType__OperationSignature != value))
                {
                    IDataType old = this._returnType__OperationSignature;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnReturnType__OperationSignatureChanging(e);
                    this.OnPropertyChanging("ReturnType__OperationSignature", e);
                    this._returnType__OperationSignature = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetReturnType__OperationSignature;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetReturnType__OperationSignature;
                    }
                    this.OnReturnType__OperationSignatureChanged(e);
                    this.OnPropertyChanged("ReturnType__OperationSignature", e);
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
                return base.Children.Concat(new OperationSignatureChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new OperationSignatureReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//repository//OperationSignature/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Interface__OperationSignature property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Interface__OperationSignatureChanging;
        
        /// <summary>
        /// Gets fired when the Interface__OperationSignature property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Interface__OperationSignatureChanged;
        
        /// <summary>
        /// Gets fired before the ReturnType__OperationSignature property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReturnType__OperationSignatureChanging;
        
        /// <summary>
        /// Gets fired when the ReturnType__OperationSignature property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ReturnType__OperationSignatureChanged;
        
        /// <summary>
        /// Raises the Interface__OperationSignatureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterface__OperationSignatureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Interface__OperationSignatureChanging;
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
            IOperationInterface oldInterface__OperationSignature = ModelHelper.CastAs<IOperationInterface>(oldParent);
            IOperationInterface newInterface__OperationSignature = ModelHelper.CastAs<IOperationInterface>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldInterface__OperationSignature, newInterface__OperationSignature);
            this.OnInterface__OperationSignatureChanging(e);
            this.OnPropertyChanging("Interface__OperationSignature");
        }
        
        /// <summary>
        /// Raises the Interface__OperationSignatureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterface__OperationSignatureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Interface__OperationSignatureChanged;
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
            IOperationInterface oldInterface__OperationSignature = ModelHelper.CastAs<IOperationInterface>(oldParent);
            IOperationInterface newInterface__OperationSignature = ModelHelper.CastAs<IOperationInterface>(newParent);
            if ((oldInterface__OperationSignature != null))
            {
                oldInterface__OperationSignature.Signatures__OperationInterface.Remove(this);
            }
            if ((newInterface__OperationSignature != null))
            {
                newInterface__OperationSignature.Signatures__OperationInterface.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldInterface__OperationSignature, newInterface__OperationSignature);
            this.OnInterface__OperationSignatureChanged(e);
            this.OnPropertyChanged("Interface__OperationSignature", e);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Parameters__OperationSignature property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Parameters__OperationSignatureCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Parameters__OperationSignature", e);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Parameters__OperationSignature property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void Parameters__OperationSignatureCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Parameters__OperationSignature", e);
        }
        
        /// <summary>
        /// Raises the ReturnType__OperationSignatureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReturnType__OperationSignatureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReturnType__OperationSignatureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ReturnType__OperationSignatureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnReturnType__OperationSignatureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ReturnType__OperationSignatureChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ReturnType__OperationSignature property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetReturnType__OperationSignature(object sender, System.EventArgs eventArgs)
        {
            this.ReturnType__OperationSignature = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int parameters__OperationSignatureIndex = ModelHelper.IndexOfReference(this.Parameters__OperationSignature, element);
            if ((parameters__OperationSignatureIndex != -1))
            {
                return ModelHelper.CreatePath("parameters__OperationSignature", parameters__OperationSignatureIndex);
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
            if ((reference == "PARAMETERS__OPERATIONSIGNATURE"))
            {
                if ((index < this.Parameters__OperationSignature.Count))
                {
                    return this.Parameters__OperationSignature[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "PARAMETERS__OPERATIONSIGNATURE"))
            {
                return this._parameters__OperationSignature;
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
            if ((feature == "INTERFACE__OPERATIONSIGNATURE"))
            {
                this.Interface__OperationSignature = ((IOperationInterface)(value));
                return;
            }
            if ((feature == "RETURNTYPE__OPERATIONSIGNATURE"))
            {
                this.ReturnType__OperationSignature = ((IDataType)(value));
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
            if ((attribute == "INTERFACE__OPERATIONSIGNATURE"))
            {
                return new Interface__OperationSignatureProxy(this);
            }
            if ((attribute == "RETURNTYPE__OPERATIONSIGNATURE"))
            {
                return new ReturnType__OperationSignatureProxy(this);
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
            if ((reference == "INTERFACE__OPERATIONSIGNATURE"))
            {
                return new Interface__OperationSignatureProxy(this);
            }
            if ((reference == "RETURNTYPE__OPERATIONSIGNATURE"))
            {
                return new ReturnType__OperationSignatureProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//repository//OperationSignature/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OperationSignature class
        /// </summary>
        public class OperationSignatureChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OperationSignature _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OperationSignatureChildrenCollection(OperationSignature parent)
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
                    count = (count + this._parent.Parameters__OperationSignature.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameters__OperationSignature.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameters__OperationSignature.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                Metamodel.DeepPCM.Repository.IParameter parameters__OperationSignatureCasted = item.As<Metamodel.DeepPCM.Repository.IParameter>();
                if ((parameters__OperationSignatureCasted != null))
                {
                    this._parent.Parameters__OperationSignature.Add(parameters__OperationSignatureCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameters__OperationSignature.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Parameters__OperationSignature.Contains(item))
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
                IEnumerator<IModelElement> parameters__OperationSignatureEnumerator = this._parent.Parameters__OperationSignature.GetEnumerator();
                try
                {
                    for (
                    ; parameters__OperationSignatureEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parameters__OperationSignatureEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parameters__OperationSignatureEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                Metamodel.DeepPCM.Repository.IParameter parameterItem = item.As<Metamodel.DeepPCM.Repository.IParameter>();
                if (((parameterItem != null) 
                            && this._parent.Parameters__OperationSignature.Remove(parameterItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameters__OperationSignature).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the OperationSignature class
        /// </summary>
        public class OperationSignatureReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private OperationSignature _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public OperationSignatureReferencedElementsCollection(OperationSignature parent)
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
                    if ((this._parent.Interface__OperationSignature != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.Parameters__OperationSignature.Count);
                    if ((this._parent.ReturnType__OperationSignature != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Interface__OperationSignatureChanged += this.PropagateValueChanges;
                this._parent.Parameters__OperationSignature.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ReturnType__OperationSignatureChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Interface__OperationSignatureChanged -= this.PropagateValueChanges;
                this._parent.Parameters__OperationSignature.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ReturnType__OperationSignatureChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Interface__OperationSignature == null))
                {
                    IOperationInterface interface__OperationSignatureCasted = item.As<IOperationInterface>();
                    if ((interface__OperationSignatureCasted != null))
                    {
                        this._parent.Interface__OperationSignature = interface__OperationSignatureCasted;
                        return;
                    }
                }
                Metamodel.DeepPCM.Repository.IParameter parameters__OperationSignatureCasted = item.As<Metamodel.DeepPCM.Repository.IParameter>();
                if ((parameters__OperationSignatureCasted != null))
                {
                    this._parent.Parameters__OperationSignature.Add(parameters__OperationSignatureCasted);
                }
                if ((this._parent.ReturnType__OperationSignature == null))
                {
                    IDataType returnType__OperationSignatureCasted = item.As<IDataType>();
                    if ((returnType__OperationSignatureCasted != null))
                    {
                        this._parent.ReturnType__OperationSignature = returnType__OperationSignatureCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Interface__OperationSignature = null;
                this._parent.Parameters__OperationSignature.Clear();
                this._parent.ReturnType__OperationSignature = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Interface__OperationSignature))
                {
                    return true;
                }
                if (this._parent.Parameters__OperationSignature.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.ReturnType__OperationSignature))
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
                if ((this._parent.Interface__OperationSignature != null))
                {
                    array[arrayIndex] = this._parent.Interface__OperationSignature;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> parameters__OperationSignatureEnumerator = this._parent.Parameters__OperationSignature.GetEnumerator();
                try
                {
                    for (
                    ; parameters__OperationSignatureEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parameters__OperationSignatureEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parameters__OperationSignatureEnumerator.Dispose();
                }
                if ((this._parent.ReturnType__OperationSignature != null))
                {
                    array[arrayIndex] = this._parent.ReturnType__OperationSignature;
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
                if ((this._parent.Interface__OperationSignature == item))
                {
                    this._parent.Interface__OperationSignature = null;
                    return true;
                }
                Metamodel.DeepPCM.Repository.IParameter parameterItem = item.As<Metamodel.DeepPCM.Repository.IParameter>();
                if (((parameterItem != null) 
                            && this._parent.Parameters__OperationSignature.Remove(parameterItem)))
                {
                    return true;
                }
                if ((this._parent.ReturnType__OperationSignature == item))
                {
                    this._parent.ReturnType__OperationSignature = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Interface__OperationSignature).Concat(this._parent.Parameters__OperationSignature).Concat(this._parent.ReturnType__OperationSignature).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the interface__OperationSignature property
        /// </summary>
        private sealed class Interface__OperationSignatureProxy : ModelPropertyChange<IOperationSignature, IOperationInterface>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Interface__OperationSignatureProxy(IOperationSignature modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperationInterface Value
            {
                get
                {
                    return this.ModelElement.Interface__OperationSignature;
                }
                set
                {
                    this.ModelElement.Interface__OperationSignature = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Interface__OperationSignatureChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Interface__OperationSignatureChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the returnType__OperationSignature property
        /// </summary>
        private sealed class ReturnType__OperationSignatureProxy : ModelPropertyChange<IOperationSignature, IDataType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ReturnType__OperationSignatureProxy(IOperationSignature modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IDataType Value
            {
                get
                {
                    return this.ModelElement.ReturnType__OperationSignature;
                }
                set
                {
                    this.ModelElement.ReturnType__OperationSignature = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReturnType__OperationSignatureChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ReturnType__OperationSignatureChanged -= handler;
            }
        }
    }
}
