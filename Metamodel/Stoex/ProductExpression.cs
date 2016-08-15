//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Probfunction;
using DeepPCM.Units;
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

namespace DeepPCM.Stoex
{
    
    
    /// <summary>
    /// The default implementation of the ProductExpression class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0")]
    [XmlNamespacePrefixAttribute("stoex")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//ProductExpression/")]
    public class ProductExpression : Product, IProductExpression, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Operation property
        /// </summary>
        private ProductOperations _operation;
        
        /// <summary>
        /// The backing field for the Left property
        /// </summary>
        private IProduct _left;
        
        /// <summary>
        /// The backing field for the Right property
        /// </summary>
        private IPower _right;
        
        /// <summary>
        /// The operation property
        /// </summary>
        [XmlElementNameAttribute("operation")]
        [XmlAttributeAttribute(true)]
        public virtual ProductOperations Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                if ((this._operation != value))
                {
                    ProductOperations old = this._operation;
                    this._operation = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOperationChanged(e);
                    this.OnPropertyChanged("Operation", e);
                }
            }
        }
        
        /// <summary>
        /// The left property
        /// </summary>
        [XmlElementNameAttribute("left")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public virtual IProduct Left
        {
            get
            {
                return this._left;
            }
            set
            {
                if ((this._left != value))
                {
                    IProduct old = this._left;
                    this._left = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.Deleted -= this.OnResetLeft;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.Deleted += this.OnResetLeft;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLeftChanged(e);
                    this.OnPropertyChanged("Left", e);
                }
            }
        }
        
        /// <summary>
        /// The right property
        /// </summary>
        [XmlElementNameAttribute("right")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public virtual IPower Right
        {
            get
            {
                return this._right;
            }
            set
            {
                if ((this._right != value))
                {
                    IPower old = this._right;
                    this._right = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.Deleted -= this.OnResetRight;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.Deleted += this.OnResetRight;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRightChanged(e);
                    this.OnPropertyChanged("Right", e);
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
                return base.Children.Concat(new ProductExpressionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ProductExpressionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//ProductExpression/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Operation property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> OperationChanged;
        
        /// <summary>
        /// Gets fired when the Left property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> LeftChanged;
        
        /// <summary>
        /// Gets fired when the Right property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> RightChanged;
        
        /// <summary>
        /// Raises the OperationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOperationChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.OperationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LeftChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLeftChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.LeftChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Left property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetLeft(object sender, EventArgs eventArgs)
        {
            this.Left = null;
        }
        
        /// <summary>
        /// Raises the RightChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRightChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.RightChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Right property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRight(object sender, EventArgs eventArgs)
        {
            this.Right = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Left))
            {
                return ModelHelper.CreatePath("Left");
            }
            if ((element == this.Right))
            {
                return ModelHelper.CreatePath("Right");
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
            if ((reference == "LEFT"))
            {
                return this.Left;
            }
            if ((reference == "RIGHT"))
            {
                return this.Right;
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
            if ((attribute == "OPERATION"))
            {
                return this.Operation;
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
            if ((feature == "LEFT"))
            {
                this.Left = ((IProduct)(value));
                return;
            }
            if ((feature == "RIGHT"))
            {
                this.Right = ((IPower)(value));
                return;
            }
            if ((feature == "OPERATION"))
            {
                this.Operation = ((ProductOperations)(value));
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
            if ((attribute == "LEFT"))
            {
                return new LeftProxy(this);
            }
            if ((attribute == "RIGHT"))
            {
                return new RightProxy(this);
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
            if ((reference == "LEFT"))
            {
                return new LeftProxy(this);
            }
            if ((reference == "RIGHT"))
            {
                return new RightProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//ProductExpression/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProductExpression class
        /// </summary>
        public class ProductExpressionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProductExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProductExpressionChildrenCollection(ProductExpression parent)
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
                    if ((this._parent.Left != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Right != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LeftChanged += this.PropagateValueChanges;
                this._parent.RightChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LeftChanged -= this.PropagateValueChanges;
                this._parent.RightChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Left == null))
                {
                    IProduct leftCasted = item.As<IProduct>();
                    if ((leftCasted != null))
                    {
                        this._parent.Left = leftCasted;
                        return;
                    }
                }
                if ((this._parent.Right == null))
                {
                    IPower rightCasted = item.As<IPower>();
                    if ((rightCasted != null))
                    {
                        this._parent.Right = rightCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Left = null;
                this._parent.Right = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Left))
                {
                    return true;
                }
                if ((item == this._parent.Right))
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
                if ((this._parent.Left != null))
                {
                    array[arrayIndex] = this._parent.Left;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Right != null))
                {
                    array[arrayIndex] = this._parent.Right;
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
                if ((this._parent.Left == item))
                {
                    this._parent.Left = null;
                    return true;
                }
                if ((this._parent.Right == item))
                {
                    this._parent.Right = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Left).Concat(this._parent.Right).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProductExpression class
        /// </summary>
        public class ProductExpressionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProductExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProductExpressionReferencedElementsCollection(ProductExpression parent)
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
                    if ((this._parent.Left != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Right != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.LeftChanged += this.PropagateValueChanges;
                this._parent.RightChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.LeftChanged -= this.PropagateValueChanges;
                this._parent.RightChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Left == null))
                {
                    IProduct leftCasted = item.As<IProduct>();
                    if ((leftCasted != null))
                    {
                        this._parent.Left = leftCasted;
                        return;
                    }
                }
                if ((this._parent.Right == null))
                {
                    IPower rightCasted = item.As<IPower>();
                    if ((rightCasted != null))
                    {
                        this._parent.Right = rightCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Left = null;
                this._parent.Right = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Left))
                {
                    return true;
                }
                if ((item == this._parent.Right))
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
                if ((this._parent.Left != null))
                {
                    array[arrayIndex] = this._parent.Left;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Right != null))
                {
                    array[arrayIndex] = this._parent.Right;
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
                if ((this._parent.Left == item))
                {
                    this._parent.Left = null;
                    return true;
                }
                if ((this._parent.Right == item))
                {
                    this._parent.Right = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Left).Concat(this._parent.Right).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the operation property
        /// </summary>
        private sealed class OperationProxy : ModelPropertyChange<IProductExpression, ProductOperations>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OperationProxy(IProductExpression modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ProductOperations Value
            {
                get
                {
                    return this.ModelElement.Operation;
                }
                set
                {
                    this.ModelElement.Operation = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OperationChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.OperationChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the left property
        /// </summary>
        private sealed class LeftProxy : ModelPropertyChange<IProductExpression, IProduct>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LeftProxy(IProductExpression modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IProduct Value
            {
                get
                {
                    return this.ModelElement.Left;
                }
                set
                {
                    this.ModelElement.Left = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeftChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.LeftChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the right property
        /// </summary>
        private sealed class RightProxy : ModelPropertyChange<IProductExpression, IPower>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RightProxy(IProductExpression modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPower Value
            {
                get
                {
                    return this.ModelElement.Right;
                }
                set
                {
                    this.ModelElement.Right = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RightChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RightChanged -= handler;
            }
        }
    }
}

