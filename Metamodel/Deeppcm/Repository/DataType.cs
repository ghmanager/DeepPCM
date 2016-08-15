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
using DeepPCM.Deeppcm.Protocol;
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Resourcetype;
using DeepPCM.Deeppcm.Seff;
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

namespace DeepPCM.Deeppcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the DataType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//DataType/")]
    public abstract class DataType : ModelElement, IDataType, IModelElement
    {
        
        /// <summary>
        /// The repository__DataType property
        /// </summary>
        [XmlElementNameAttribute("repository__DataType")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("dataTypes__Repository")]
        public virtual IRepository Repository__DataType
        {
            get
            {
                return ModelHelper.CastAs<IRepository>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DataTypeReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//DataType/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Repository__DataType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Repository__DataTypeChanged;
        
        /// <summary>
        /// Raises the Repository__DataTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__DataTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Repository__DataTypeChanged;
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
            IRepository oldRepository__DataType = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__DataType = ModelHelper.CastAs<IRepository>(newParent);
            if ((oldRepository__DataType != null))
            {
                oldRepository__DataType.DataTypes__Repository.Remove(this);
            }
            if ((newRepository__DataType != null))
            {
                newRepository__DataType.DataTypes__Repository.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__DataType, newRepository__DataType);
            this.OnRepository__DataTypeChanged(e);
            this.OnPropertyChanged("Repository__DataType", e);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REPOSITORY__DATATYPE"))
            {
                this.Repository__DataType = ((IRepository)(value));
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
            if ((attribute == "REPOSITORY__DATATYPE"))
            {
                return new Repository__DataTypeProxy(this);
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
            if ((reference == "REPOSITORY__DATATYPE"))
            {
                return new Repository__DataTypeProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//DataType/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the DataType class
        /// </summary>
        public class DataTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private DataType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DataTypeReferencedElementsCollection(DataType parent)
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
                    if ((this._parent.Repository__DataType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Repository__DataTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Repository__DataTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Repository__DataType == null))
                {
                    IRepository repository__DataTypeCasted = item.As<IRepository>();
                    if ((repository__DataTypeCasted != null))
                    {
                        this._parent.Repository__DataType = repository__DataTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Repository__DataType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Repository__DataType))
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
                if ((this._parent.Repository__DataType != null))
                {
                    array[arrayIndex] = this._parent.Repository__DataType;
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
                if ((this._parent.Repository__DataType == item))
                {
                    this._parent.Repository__DataType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Repository__DataType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the repository__DataType property
        /// </summary>
        private sealed class Repository__DataTypeProxy : ModelPropertyChange<IDataType, IRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Repository__DataTypeProxy(IDataType modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRepository Value
            {
                get
                {
                    return this.ModelElement.Repository__DataType;
                }
                set
                {
                    this.ModelElement.Repository__DataType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Repository__DataTypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Repository__DataTypeChanged -= handler;
            }
        }
    }
}

