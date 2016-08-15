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
    /// The default implementation of the RequiredCharacterisation class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//RequiredCharacteri" +
        "sation/")]
    public class RequiredCharacterisation : ModelElement, IRequiredCharacterisation, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        private VariableCharacterisationType _type;
        
        /// <summary>
        /// The backing field for the Parameter property
        /// </summary>
        private IParameter _parameter;
        
        /// <summary>
        /// The type property
        /// </summary>
        [XmlElementNameAttribute("type")]
        [XmlAttributeAttribute(true)]
        public virtual VariableCharacterisationType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    VariableCharacterisationType old = this._type;
                    this._type = value;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e);
                }
            }
        }
        
        /// <summary>
        /// The parameter property
        /// </summary>
        [XmlElementNameAttribute("parameter")]
        [XmlAttributeAttribute(true)]
        public virtual IParameter Parameter
        {
            get
            {
                return this._parameter;
            }
            set
            {
                if ((this._parameter != value))
                {
                    IParameter old = this._parameter;
                    this._parameter = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetParameter;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetParameter;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnParameterChanged(e);
                    this.OnPropertyChanged("Parameter", e);
                }
            }
        }
        
        /// <summary>
        /// The interface_RequiredCharacterisation property
        /// </summary>
        [XmlElementNameAttribute("interface_RequiredCharacterisation")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("requiredCharacterisations")]
        public virtual IInterface Interface_RequiredCharacterisation
        {
            get
            {
                return ModelHelper.CastAs<IInterface>(this.Parent);
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
                return base.ReferencedElements.Concat(new RequiredCharacterisationReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//RequiredCharacteri" +
                        "sation/");
            }
        }
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired when the Parameter property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ParameterChanged;
        
        /// <summary>
        /// Gets fired when the Interface_RequiredCharacterisation property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> Interface_RequiredCharacterisationChanged;
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ParameterChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParameterChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ParameterChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Parameter property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetParameter(object sender, EventArgs eventArgs)
        {
            this.Parameter = null;
        }
        
        /// <summary>
        /// Raises the Interface_RequiredCharacterisationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInterface_RequiredCharacterisationChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.Interface_RequiredCharacterisationChanged;
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
            IInterface oldInterface_RequiredCharacterisation = ModelHelper.CastAs<IInterface>(oldParent);
            IInterface newInterface_RequiredCharacterisation = ModelHelper.CastAs<IInterface>(newParent);
            if ((oldInterface_RequiredCharacterisation != null))
            {
                oldInterface_RequiredCharacterisation.RequiredCharacterisations.Remove(this);
            }
            if ((newInterface_RequiredCharacterisation != null))
            {
                newInterface_RequiredCharacterisation.RequiredCharacterisations.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldInterface_RequiredCharacterisation, newInterface_RequiredCharacterisation);
            this.OnInterface_RequiredCharacterisationChanged(e);
            this.OnPropertyChanged("Interface_RequiredCharacterisation", e);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "TYPE"))
            {
                return this.Type;
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
            if ((feature == "PARAMETER"))
            {
                this.Parameter = ((IParameter)(value));
                return;
            }
            if ((feature == "INTERFACE_REQUIREDCHARACTERISATION"))
            {
                this.Interface_RequiredCharacterisation = ((IInterface)(value));
                return;
            }
            if ((feature == "TYPE"))
            {
                this.Type = ((VariableCharacterisationType)(value));
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
            if ((attribute == "PARAMETER"))
            {
                return new ParameterProxy(this);
            }
            if ((attribute == "INTERFACE_REQUIREDCHARACTERISATION"))
            {
                return new Interface_RequiredCharacterisationProxy(this);
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
            if ((reference == "PARAMETER"))
            {
                return new ParameterProxy(this);
            }
            if ((reference == "INTERFACE_REQUIREDCHARACTERISATION"))
            {
                return new Interface_RequiredCharacterisationProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository//RequiredCharacteri" +
                    "sation/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the RequiredCharacterisation class
        /// </summary>
        public class RequiredCharacterisationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private RequiredCharacterisation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public RequiredCharacterisationReferencedElementsCollection(RequiredCharacterisation parent)
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
                    if ((this._parent.Parameter != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Interface_RequiredCharacterisation != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParameterChanged += this.PropagateValueChanges;
                this._parent.Interface_RequiredCharacterisationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParameterChanged -= this.PropagateValueChanges;
                this._parent.Interface_RequiredCharacterisationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Parameter == null))
                {
                    IParameter parameterCasted = item.As<IParameter>();
                    if ((parameterCasted != null))
                    {
                        this._parent.Parameter = parameterCasted;
                        return;
                    }
                }
                if ((this._parent.Interface_RequiredCharacterisation == null))
                {
                    IInterface interface_RequiredCharacterisationCasted = item.As<IInterface>();
                    if ((interface_RequiredCharacterisationCasted != null))
                    {
                        this._parent.Interface_RequiredCharacterisation = interface_RequiredCharacterisationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter = null;
                this._parent.Interface_RequiredCharacterisation = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Parameter))
                {
                    return true;
                }
                if ((item == this._parent.Interface_RequiredCharacterisation))
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
                if ((this._parent.Parameter != null))
                {
                    array[arrayIndex] = this._parent.Parameter;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Interface_RequiredCharacterisation != null))
                {
                    array[arrayIndex] = this._parent.Interface_RequiredCharacterisation;
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
                if ((this._parent.Parameter == item))
                {
                    this._parent.Parameter = null;
                    return true;
                }
                if ((this._parent.Interface_RequiredCharacterisation == item))
                {
                    this._parent.Interface_RequiredCharacterisation = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter).Concat(this._parent.Interface_RequiredCharacterisation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<IRequiredCharacterisation, VariableCharacterisationType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(IRequiredCharacterisation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override VariableCharacterisationType Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.TypeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parameter property
        /// </summary>
        private sealed class ParameterProxy : ModelPropertyChange<IRequiredCharacterisation, IParameter>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParameterProxy(IRequiredCharacterisation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IParameter Value
            {
                get
                {
                    return this.ModelElement.Parameter;
                }
                set
                {
                    this.ModelElement.Parameter = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParameterChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParameterChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the interface_RequiredCharacterisation property
        /// </summary>
        private sealed class Interface_RequiredCharacterisationProxy : ModelPropertyChange<IRequiredCharacterisation, IInterface>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Interface_RequiredCharacterisationProxy(IRequiredCharacterisation modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IInterface Value
            {
                get
                {
                    return this.ModelElement.Interface_RequiredCharacterisation;
                }
                set
                {
                    this.ModelElement.Interface_RequiredCharacterisation = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Interface_RequiredCharacterisationChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Interface_RequiredCharacterisationChanged -= handler;
            }
        }
    }
}

