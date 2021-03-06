//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core.Composition;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.Resourcetype;
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

namespace DeepPCM.Deeppcm.Core.Entity
{
    
    
    /// <summary>
    /// The default implementation of the ResourceRequiredRole class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Entity/5.0")]
    [XmlNamespacePrefixAttribute("entity")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceRequired" +
        "Role/")]
    [DebuggerDisplayAttribute("ResourceRequiredRole {Id}")]
    public class ResourceRequiredRole : Role, IResourceRequiredRole, IModelElement
    {
        
        /// <summary>
        /// The backing field for the RequiredResourceInterface__ResourceRequiredRole property
        /// </summary>
        private IResourceInterface _requiredResourceInterface__ResourceRequiredRole;
        
        /// <summary>
        /// The requiredResourceInterface__ResourceRequiredRole property
        /// </summary>
        [XmlElementNameAttribute("requiredResourceInterface__ResourceRequiredRole")]
        [XmlAttributeAttribute(true)]
        public virtual IResourceInterface RequiredResourceInterface__ResourceRequiredRole
        {
            get
            {
                return this._requiredResourceInterface__ResourceRequiredRole;
            }
            set
            {
                if ((this._requiredResourceInterface__ResourceRequiredRole != value))
                {
                    IResourceInterface old = this._requiredResourceInterface__ResourceRequiredRole;
                    this._requiredResourceInterface__ResourceRequiredRole = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetRequiredResourceInterface__ResourceRequiredRole;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetRequiredResourceInterface__ResourceRequiredRole;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRequiredResourceInterface__ResourceRequiredRoleChanged(e);
                    this.OnPropertyChanged("RequiredResourceInterface__ResourceRequiredRole", e);
                }
            }
        }
        
        /// <summary>
        /// The resourceInterfaceRequiringEntity__ResourceRequiredRole property
        /// </summary>
        [XmlElementNameAttribute("resourceInterfaceRequiringEntity__ResourceRequiredRole")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("resourceRequiredRoles__ResourceInterfaceRequiringEntity")]
        public virtual IResourceInterfaceRequiringEntity ResourceInterfaceRequiringEntity__ResourceRequiredRole
        {
            get
            {
                return ModelHelper.CastAs<IResourceInterfaceRequiringEntity>(this.Parent);
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
                return base.ReferencedElements.Concat(new ResourceRequiredRoleReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceRequired" +
                        "Role/");
            }
        }
        
        /// <summary>
        /// Gets fired when the RequiredResourceInterface__ResourceRequiredRole property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> RequiredResourceInterface__ResourceRequiredRoleChanged;
        
        /// <summary>
        /// Gets fired when the ResourceInterfaceRequiringEntity__ResourceRequiredRole property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged;
        
        /// <summary>
        /// Raises the RequiredResourceInterface__ResourceRequiredRoleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRequiredResourceInterface__ResourceRequiredRoleChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.RequiredResourceInterface__ResourceRequiredRoleChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the RequiredResourceInterface__ResourceRequiredRole property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRequiredResourceInterface__ResourceRequiredRole(object sender, EventArgs eventArgs)
        {
            this.RequiredResourceInterface__ResourceRequiredRole = null;
        }
        
        /// <summary>
        /// Raises the ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged;
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
            IResourceInterfaceRequiringEntity oldResourceInterfaceRequiringEntity__ResourceRequiredRole = ModelHelper.CastAs<IResourceInterfaceRequiringEntity>(oldParent);
            IResourceInterfaceRequiringEntity newResourceInterfaceRequiringEntity__ResourceRequiredRole = ModelHelper.CastAs<IResourceInterfaceRequiringEntity>(newParent);
            if ((oldResourceInterfaceRequiringEntity__ResourceRequiredRole != null))
            {
                oldResourceInterfaceRequiringEntity__ResourceRequiredRole.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Remove(this);
            }
            if ((newResourceInterfaceRequiringEntity__ResourceRequiredRole != null))
            {
                newResourceInterfaceRequiringEntity__ResourceRequiredRole.ResourceRequiredRoles__ResourceInterfaceRequiringEntity.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceInterfaceRequiringEntity__ResourceRequiredRole, newResourceInterfaceRequiringEntity__ResourceRequiredRole);
            this.OnResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged(e);
            this.OnPropertyChanged("ResourceInterfaceRequiringEntity__ResourceRequiredRole", e);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "REQUIREDRESOURCEINTERFACE__RESOURCEREQUIREDROLE"))
            {
                this.RequiredResourceInterface__ResourceRequiredRole = ((IResourceInterface)(value));
                return;
            }
            if ((feature == "RESOURCEINTERFACEREQUIRINGENTITY__RESOURCEREQUIREDROLE"))
            {
                this.ResourceInterfaceRequiringEntity__ResourceRequiredRole = ((IResourceInterfaceRequiringEntity)(value));
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
            if ((attribute == "REQUIREDRESOURCEINTERFACE__RESOURCEREQUIREDROLE"))
            {
                return new RequiredResourceInterface__ResourceRequiredRoleProxy(this);
            }
            if ((attribute == "RESOURCEINTERFACEREQUIRINGENTITY__RESOURCEREQUIREDROLE"))
            {
                return new ResourceInterfaceRequiringEntity__ResourceRequiredRoleProxy(this);
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
            if ((reference == "REQUIREDRESOURCEINTERFACE__RESOURCEREQUIREDROLE"))
            {
                return new RequiredResourceInterface__ResourceRequiredRoleProxy(this);
            }
            if ((reference == "RESOURCEINTERFACEREQUIRINGENTITY__RESOURCEREQUIREDROLE"))
            {
                return new ResourceInterfaceRequiringEntity__ResourceRequiredRoleProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceRequired" +
                    "Role/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceRequiredRole class
        /// </summary>
        public class ResourceRequiredRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceRequiredRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceRequiredRoleReferencedElementsCollection(ResourceRequiredRole parent)
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
                    if ((this._parent.RequiredResourceInterface__ResourceRequiredRole != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RequiredResourceInterface__ResourceRequiredRoleChanged += this.PropagateValueChanges;
                this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RequiredResourceInterface__ResourceRequiredRoleChanged -= this.PropagateValueChanges;
                this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.RequiredResourceInterface__ResourceRequiredRole == null))
                {
                    IResourceInterface requiredResourceInterface__ResourceRequiredRoleCasted = item.As<IResourceInterface>();
                    if ((requiredResourceInterface__ResourceRequiredRoleCasted != null))
                    {
                        this._parent.RequiredResourceInterface__ResourceRequiredRole = requiredResourceInterface__ResourceRequiredRoleCasted;
                        return;
                    }
                }
                if ((this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole == null))
                {
                    IResourceInterfaceRequiringEntity resourceInterfaceRequiringEntity__ResourceRequiredRoleCasted = item.As<IResourceInterfaceRequiringEntity>();
                    if ((resourceInterfaceRequiringEntity__ResourceRequiredRoleCasted != null))
                    {
                        this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole = resourceInterfaceRequiringEntity__ResourceRequiredRoleCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RequiredResourceInterface__ResourceRequiredRole = null;
                this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.RequiredResourceInterface__ResourceRequiredRole))
                {
                    return true;
                }
                if ((item == this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole))
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
                if ((this._parent.RequiredResourceInterface__ResourceRequiredRole != null))
                {
                    array[arrayIndex] = this._parent.RequiredResourceInterface__ResourceRequiredRole;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole != null))
                {
                    array[arrayIndex] = this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole;
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
                if ((this._parent.RequiredResourceInterface__ResourceRequiredRole == item))
                {
                    this._parent.RequiredResourceInterface__ResourceRequiredRole = null;
                    return true;
                }
                if ((this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole == item))
                {
                    this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RequiredResourceInterface__ResourceRequiredRole).Concat(this._parent.ResourceInterfaceRequiringEntity__ResourceRequiredRole).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the requiredResourceInterface__ResourceRequiredRole property
        /// </summary>
        private sealed class RequiredResourceInterface__ResourceRequiredRoleProxy : ModelPropertyChange<IResourceRequiredRole, IResourceInterface>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public RequiredResourceInterface__ResourceRequiredRoleProxy(IResourceRequiredRole modelElement) : 
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
                    return this.ModelElement.RequiredResourceInterface__ResourceRequiredRole;
                }
                set
                {
                    this.ModelElement.RequiredResourceInterface__ResourceRequiredRole = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RequiredResourceInterface__ResourceRequiredRoleChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.RequiredResourceInterface__ResourceRequiredRoleChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the resourceInterfaceRequiringEntity__ResourceRequiredRole property
        /// </summary>
        private sealed class ResourceInterfaceRequiringEntity__ResourceRequiredRoleProxy : ModelPropertyChange<IResourceRequiredRole, IResourceInterfaceRequiringEntity>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceInterfaceRequiringEntity__ResourceRequiredRoleProxy(IResourceRequiredRole modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceInterfaceRequiringEntity Value
            {
                get
                {
                    return this.ModelElement.ResourceInterfaceRequiringEntity__ResourceRequiredRole;
                }
                set
                {
                    this.ModelElement.ResourceInterfaceRequiringEntity__ResourceRequiredRole = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ResourceInterfaceRequiringEntity__ResourceRequiredRoleChanged -= handler;
            }
        }
    }
}

