//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Composition;
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.Identifier;
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

namespace Metamodel.DeepPCM.Resourcetype
{
    
    
    /// <summary>
    /// The default implementation of the ResourceSignature class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/ResourceType/1.0")]
    [XmlNamespacePrefixAttribute("resourcetype")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//resourcetype//ResourceSignature/")]
    [DebuggerDisplayAttribute("ResourceSignature {Id}")]
    public class ResourceSignature : Metamodel.DeepPCM.Core.Entity.Entity, IResourceSignature, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceServiceId property
        /// </summary>
        private int _resourceServiceId;
        
        /// <summary>
        /// The backing field for the Parameter__ResourceSignature property
        /// </summary>
        private Metamodel.DeepPCM.Repository.IParameter _parameter__ResourceSignature;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The resourceServiceId property
        /// </summary>
        [XmlElementNameAttribute("resourceServiceId")]
        [XmlAttributeAttribute(true)]
        public virtual int ResourceServiceId
        {
            get
            {
                return this._resourceServiceId;
            }
            set
            {
                if ((this._resourceServiceId != value))
                {
                    int old = this._resourceServiceId;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnResourceServiceIdChanging(e);
                    this.OnPropertyChanging("ResourceServiceId", e);
                    this._resourceServiceId = value;
                    this.OnResourceServiceIdChanged(e);
                    this.OnPropertyChanged("ResourceServiceId", e);
                }
            }
        }
        
        /// <summary>
        /// The parameter__ResourceSignature property
        /// </summary>
        [XmlElementNameAttribute("parameter__ResourceSignature")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceSignature__Parameter")]
        public virtual Metamodel.DeepPCM.Repository.IParameter Parameter__ResourceSignature
        {
            get
            {
                return this._parameter__ResourceSignature;
            }
            set
            {
                if ((this._parameter__ResourceSignature != value))
                {
                    Metamodel.DeepPCM.Repository.IParameter old = this._parameter__ResourceSignature;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnParameter__ResourceSignatureChanging(e);
                    this.OnPropertyChanging("Parameter__ResourceSignature", e);
                    this._parameter__ResourceSignature = value;
                    if ((old != null))
                    {
                        old.ResourceSignature__Parameter = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetParameter__ResourceSignature;
                    }
                    if ((value != null))
                    {
                        value.ResourceSignature__Parameter = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetParameter__ResourceSignature;
                    }
                    this.OnParameter__ResourceSignatureChanged(e);
                    this.OnPropertyChanged("Parameter__ResourceSignature", e);
                }
            }
        }
        
        /// <summary>
        /// The resourceInterface__ResourceSignature property
        /// </summary>
        [XmlElementNameAttribute("resourceInterface__ResourceSignature")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("resourceSignatures__ResourceInterface")]
        public virtual IResourceInterface ResourceInterface__ResourceSignature
        {
            get
            {
                return ModelHelper.CastAs<IResourceInterface>(this.Parent);
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
                return base.Children.Concat(new ResourceSignatureChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ResourceSignatureReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//resourcetype//ResourceSignature/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ResourceServiceId property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ResourceServiceIdChanging;
        
        /// <summary>
        /// Gets fired when the ResourceServiceId property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ResourceServiceIdChanged;
        
        /// <summary>
        /// Gets fired before the Parameter__ResourceSignature property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Parameter__ResourceSignatureChanging;
        
        /// <summary>
        /// Gets fired when the Parameter__ResourceSignature property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> Parameter__ResourceSignatureChanged;
        
        /// <summary>
        /// Gets fired before the ResourceInterface__ResourceSignature property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ResourceInterface__ResourceSignatureChanging;
        
        /// <summary>
        /// Gets fired when the ResourceInterface__ResourceSignature property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> ResourceInterface__ResourceSignatureChanged;
        
        /// <summary>
        /// Raises the ResourceServiceIdChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceServiceIdChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ResourceServiceIdChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ResourceServiceIdChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceServiceIdChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ResourceServiceIdChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Parameter__ResourceSignatureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParameter__ResourceSignatureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Parameter__ResourceSignatureChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Parameter__ResourceSignatureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParameter__ResourceSignatureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.Parameter__ResourceSignatureChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Parameter__ResourceSignature property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetParameter__ResourceSignature(object sender, System.EventArgs eventArgs)
        {
            this.Parameter__ResourceSignature = null;
        }
        
        /// <summary>
        /// Raises the ResourceInterface__ResourceSignatureChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceInterface__ResourceSignatureChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ResourceInterface__ResourceSignatureChanging;
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
            IResourceInterface oldResourceInterface__ResourceSignature = ModelHelper.CastAs<IResourceInterface>(oldParent);
            IResourceInterface newResourceInterface__ResourceSignature = ModelHelper.CastAs<IResourceInterface>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceInterface__ResourceSignature, newResourceInterface__ResourceSignature);
            this.OnResourceInterface__ResourceSignatureChanging(e);
            this.OnPropertyChanging("ResourceInterface__ResourceSignature");
        }
        
        /// <summary>
        /// Raises the ResourceInterface__ResourceSignatureChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceInterface__ResourceSignatureChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.ResourceInterface__ResourceSignatureChanged;
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
            IResourceInterface oldResourceInterface__ResourceSignature = ModelHelper.CastAs<IResourceInterface>(oldParent);
            IResourceInterface newResourceInterface__ResourceSignature = ModelHelper.CastAs<IResourceInterface>(newParent);
            if ((oldResourceInterface__ResourceSignature != null))
            {
                oldResourceInterface__ResourceSignature.ResourceSignatures__ResourceInterface.Remove(this);
            }
            if ((newResourceInterface__ResourceSignature != null))
            {
                newResourceInterface__ResourceSignature.ResourceSignatures__ResourceInterface.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceInterface__ResourceSignature, newResourceInterface__ResourceSignature);
            this.OnResourceInterface__ResourceSignatureChanged(e);
            this.OnPropertyChanged("ResourceInterface__ResourceSignature", e);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.Parameter__ResourceSignature))
            {
                return ModelHelper.CreatePath("Parameter__ResourceSignature");
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
            if ((reference == "PARAMETER__RESOURCESIGNATURE"))
            {
                return this.Parameter__ResourceSignature;
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
            if ((attribute == "RESOURCESERVICEID"))
            {
                return this.ResourceServiceId;
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
            if ((feature == "PARAMETER__RESOURCESIGNATURE"))
            {
                this.Parameter__ResourceSignature = ((Metamodel.DeepPCM.Repository.IParameter)(value));
                return;
            }
            if ((feature == "RESOURCEINTERFACE__RESOURCESIGNATURE"))
            {
                this.ResourceInterface__ResourceSignature = ((IResourceInterface)(value));
                return;
            }
            if ((feature == "RESOURCESERVICEID"))
            {
                this.ResourceServiceId = ((int)(value));
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
            if ((attribute == "PARAMETER__RESOURCESIGNATURE"))
            {
                return new Parameter__ResourceSignatureProxy(this);
            }
            if ((attribute == "RESOURCEINTERFACE__RESOURCESIGNATURE"))
            {
                return new ResourceInterface__ResourceSignatureProxy(this);
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
            if ((reference == "PARAMETER__RESOURCESIGNATURE"))
            {
                return new Parameter__ResourceSignatureProxy(this);
            }
            if ((reference == "RESOURCEINTERFACE__RESOURCESIGNATURE"))
            {
                return new ResourceInterface__ResourceSignatureProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//resourcetype//ResourceSignature/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceSignature class
        /// </summary>
        public class ResourceSignatureChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceSignature _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceSignatureChildrenCollection(ResourceSignature parent)
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
                    if ((this._parent.Parameter__ResourceSignature != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter__ResourceSignatureChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter__ResourceSignatureChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Parameter__ResourceSignature == null))
                {
                    Metamodel.DeepPCM.Repository.IParameter parameter__ResourceSignatureCasted = item.As<Metamodel.DeepPCM.Repository.IParameter>();
                    if ((parameter__ResourceSignatureCasted != null))
                    {
                        this._parent.Parameter__ResourceSignature = parameter__ResourceSignatureCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter__ResourceSignature = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Parameter__ResourceSignature))
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
                if ((this._parent.Parameter__ResourceSignature != null))
                {
                    array[arrayIndex] = this._parent.Parameter__ResourceSignature;
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
                if ((this._parent.Parameter__ResourceSignature == item))
                {
                    this._parent.Parameter__ResourceSignature = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter__ResourceSignature).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceSignature class
        /// </summary>
        public class ResourceSignatureReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceSignature _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceSignatureReferencedElementsCollection(ResourceSignature parent)
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
                    if ((this._parent.Parameter__ResourceSignature != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ResourceInterface__ResourceSignature != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Parameter__ResourceSignatureChanged += this.PropagateValueChanges;
                this._parent.ResourceInterface__ResourceSignatureChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Parameter__ResourceSignatureChanged -= this.PropagateValueChanges;
                this._parent.ResourceInterface__ResourceSignatureChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Parameter__ResourceSignature == null))
                {
                    Metamodel.DeepPCM.Repository.IParameter parameter__ResourceSignatureCasted = item.As<Metamodel.DeepPCM.Repository.IParameter>();
                    if ((parameter__ResourceSignatureCasted != null))
                    {
                        this._parent.Parameter__ResourceSignature = parameter__ResourceSignatureCasted;
                        return;
                    }
                }
                if ((this._parent.ResourceInterface__ResourceSignature == null))
                {
                    IResourceInterface resourceInterface__ResourceSignatureCasted = item.As<IResourceInterface>();
                    if ((resourceInterface__ResourceSignatureCasted != null))
                    {
                        this._parent.ResourceInterface__ResourceSignature = resourceInterface__ResourceSignatureCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Parameter__ResourceSignature = null;
                this._parent.ResourceInterface__ResourceSignature = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Parameter__ResourceSignature))
                {
                    return true;
                }
                if ((item == this._parent.ResourceInterface__ResourceSignature))
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
                if ((this._parent.Parameter__ResourceSignature != null))
                {
                    array[arrayIndex] = this._parent.Parameter__ResourceSignature;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ResourceInterface__ResourceSignature != null))
                {
                    array[arrayIndex] = this._parent.ResourceInterface__ResourceSignature;
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
                if ((this._parent.Parameter__ResourceSignature == item))
                {
                    this._parent.Parameter__ResourceSignature = null;
                    return true;
                }
                if ((this._parent.ResourceInterface__ResourceSignature == item))
                {
                    this._parent.ResourceInterface__ResourceSignature = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Parameter__ResourceSignature).Concat(this._parent.ResourceInterface__ResourceSignature).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the resourceServiceId property
        /// </summary>
        private sealed class ResourceServiceIdProxy : ModelPropertyChange<IResourceSignature, int>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceServiceIdProxy(IResourceSignature modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override int Value
            {
                get
                {
                    return this.ModelElement.ResourceServiceId;
                }
                set
                {
                    this.ModelElement.ResourceServiceId = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceServiceIdChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceServiceIdChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parameter__ResourceSignature property
        /// </summary>
        private sealed class Parameter__ResourceSignatureProxy : ModelPropertyChange<IResourceSignature, Metamodel.DeepPCM.Repository.IParameter>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Parameter__ResourceSignatureProxy(IResourceSignature modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override Metamodel.DeepPCM.Repository.IParameter Value
            {
                get
                {
                    return this.ModelElement.Parameter__ResourceSignature;
                }
                set
                {
                    this.ModelElement.Parameter__ResourceSignature = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Parameter__ResourceSignatureChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.Parameter__ResourceSignatureChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the resourceInterface__ResourceSignature property
        /// </summary>
        private sealed class ResourceInterface__ResourceSignatureProxy : ModelPropertyChange<IResourceSignature, IResourceInterface>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceInterface__ResourceSignatureProxy(IResourceSignature modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceInterface Value
            {
                get
                {
                    return this.ModelElement.ResourceInterface__ResourceSignature;
                }
                set
                {
                    this.ModelElement.ResourceInterface__ResourceSignature = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceInterface__ResourceSignatureChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceInterface__ResourceSignatureChanged -= handler;
            }
        }
    }
}

