//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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

namespace DeepPCM.Units
{
    
    
    /// <summary>
    /// The default implementation of the UnitCarryingElement class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/Units/1.0")]
    [XmlNamespacePrefixAttribute("units")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/Units/1.0#//UnitCarryingElement/")]
    public abstract class UnitCarryingElement : ModelElement, IUnitCarryingElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the UnitSpecification property
        /// </summary>
        private string _unitSpecification;
        
        /// <summary>
        /// The backing field for the Unit property
        /// </summary>
        private IUnit _unit;
        
        /// <summary>
        /// The unitSpecification property
        /// </summary>
        [XmlElementNameAttribute("unitSpecification")]
        [XmlAttributeAttribute(true)]
        public virtual string UnitSpecification
        {
            get
            {
                return this._unitSpecification;
            }
            set
            {
                if ((this._unitSpecification != value))
                {
                    string old = this._unitSpecification;
                    this._unitSpecification = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUnitSpecificationChanged(e);
                    this.OnPropertyChanged("UnitSpecification", e);
                }
            }
        }
        
        /// <summary>
        /// The unit property
        /// </summary>
        [XmlElementNameAttribute("unit")]
        [XmlAttributeAttribute(true)]
        public virtual IUnit Unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                if ((this._unit != value))
                {
                    IUnit old = this._unit;
                    this._unit = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetUnit;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetUnit;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnUnitChanged(e);
                    this.OnPropertyChanged("Unit", e);
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
                return base.ReferencedElements.Concat(new UnitCarryingElementReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/Units/1.0#//UnitCarryingElement/");
            }
        }
        
        /// <summary>
        /// Gets fired when the UnitSpecification property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> UnitSpecificationChanged;
        
        /// <summary>
        /// Gets fired when the Unit property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> UnitChanged;
        
        /// <summary>
        /// Raises the UnitSpecificationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUnitSpecificationChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.UnitSpecificationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the UnitChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnUnitChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.UnitChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Unit property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetUnit(object sender, EventArgs eventArgs)
        {
            this.Unit = null;
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "UNITSPECIFICATION"))
            {
                return this.UnitSpecification;
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
            if ((feature == "UNIT"))
            {
                this.Unit = ((IUnit)(value));
                return;
            }
            if ((feature == "UNITSPECIFICATION"))
            {
                this.UnitSpecification = ((string)(value));
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
            if ((attribute == "UNIT"))
            {
                return new UnitProxy(this);
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
            if ((reference == "UNIT"))
            {
                return new UnitProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/Units/1.0#//UnitCarryingElement/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the UnitCarryingElement class
        /// </summary>
        public class UnitCarryingElementReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private UnitCarryingElement _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public UnitCarryingElementReferencedElementsCollection(UnitCarryingElement parent)
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
                    if ((this._parent.Unit != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.UnitChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.UnitChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Unit == null))
                {
                    IUnit unitCasted = item.As<IUnit>();
                    if ((unitCasted != null))
                    {
                        this._parent.Unit = unitCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Unit = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Unit))
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
                if ((this._parent.Unit != null))
                {
                    array[arrayIndex] = this._parent.Unit;
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
                if ((this._parent.Unit == item))
                {
                    this._parent.Unit = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Unit).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the unitSpecification property
        /// </summary>
        private sealed class UnitSpecificationProxy : ModelPropertyChange<IUnitCarryingElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UnitSpecificationProxy(IUnitCarryingElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.UnitSpecification;
                }
                set
                {
                    this.ModelElement.UnitSpecification = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UnitSpecificationChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UnitSpecificationChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the unit property
        /// </summary>
        private sealed class UnitProxy : ModelPropertyChange<IUnitCarryingElement, IUnit>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public UnitProxy(IUnitCarryingElement modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IUnit Value
            {
                get
                {
                    return this.ModelElement.Unit;
                }
                set
                {
                    this.ModelElement.Unit = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UnitChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.UnitChanged -= handler;
            }
        }
    }
}

