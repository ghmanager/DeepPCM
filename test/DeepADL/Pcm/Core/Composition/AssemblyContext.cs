//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Repository;
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

namespace GeneratedCode.Pcm.Core.Composition
{
    
    
    /// <summary>
    /// The default implementation of the AssemblyContext class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//AssemblyCon" +
        "text/")]
    [DebuggerDisplayAttribute("AssemblyContext {Id}")]
    public class AssemblyContext : GeneratedCode.Pcm.Core.Entity.Entity, IAssemblyContext, IModelElement
    {
        
        /// <summary>
        /// The backing field for the EncapsulatedComponent__AssemblyContext property
        /// </summary>
        private IRepositoryComponent _encapsulatedComponent__AssemblyContext;
        
        /// <summary>
        /// The backing field for the ConfigParameterUsages__AssemblyContext property
        /// </summary>
        private AssemblyContextConfigParameterUsages__AssemblyContextCollection _configParameterUsages__AssemblyContext;
        
        public AssemblyContext()
        {
            this._configParameterUsages__AssemblyContext = new AssemblyContextConfigParameterUsages__AssemblyContextCollection(this);
            this._configParameterUsages__AssemblyContext.CollectionChanged += this.ConfigParameterUsages__AssemblyContextCollectionChanged;
        }
        
        /// <summary>
        /// The parentStructure__AssemblyContext property
        /// </summary>
        [XmlElementNameAttribute("parentStructure__AssemblyContext")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("assemblyContexts__ComposedStructure")]
        public virtual IComposedStructure ParentStructure__AssemblyContext
        {
            get
            {
                return ModelHelper.CastAs<IComposedStructure>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The encapsulatedComponent__AssemblyContext property
        /// </summary>
        [XmlElementNameAttribute("encapsulatedComponent__AssemblyContext")]
        [XmlAttributeAttribute(true)]
        public virtual IRepositoryComponent EncapsulatedComponent__AssemblyContext
        {
            get
            {
                return this._encapsulatedComponent__AssemblyContext;
            }
            set
            {
                if ((this._encapsulatedComponent__AssemblyContext != value))
                {
                    IRepositoryComponent old = this._encapsulatedComponent__AssemblyContext;
                    this._encapsulatedComponent__AssemblyContext = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetEncapsulatedComponent__AssemblyContext;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetEncapsulatedComponent__AssemblyContext;
                    }
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnEncapsulatedComponent__AssemblyContextChanged(e);
                    this.OnPropertyChanged("EncapsulatedComponent__AssemblyContext", e);
                }
            }
        }
        
        /// <summary>
        /// The configParameterUsages__AssemblyContext property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("configParameterUsages__AssemblyContext")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("assemblyContext__VariableUsage")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IVariableUsage> ConfigParameterUsages__AssemblyContext
        {
            get
            {
                return this._configParameterUsages__AssemblyContext;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new AssemblyContextChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AssemblyContextReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//AssemblyCon" +
                        "text/");
            }
        }
        
        /// <summary>
        /// Gets fired when the ParentStructure__AssemblyContext property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ParentStructure__AssemblyContextChanged;
        
        /// <summary>
        /// Gets fired when the EncapsulatedComponent__AssemblyContext property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> EncapsulatedComponent__AssemblyContextChanged;
        
        /// <summary>
        /// Raises the ParentStructure__AssemblyContextChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure__AssemblyContextChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ParentStructure__AssemblyContextChanged;
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
            IComposedStructure oldParentStructure__AssemblyContext = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure__AssemblyContext = ModelHelper.CastAs<IComposedStructure>(newParent);
            if ((oldParentStructure__AssemblyContext != null))
            {
                oldParentStructure__AssemblyContext.AssemblyContexts__ComposedStructure.Remove(this);
            }
            if ((newParentStructure__AssemblyContext != null))
            {
                newParentStructure__AssemblyContext.AssemblyContexts__ComposedStructure.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure__AssemblyContext, newParentStructure__AssemblyContext);
            this.OnParentStructure__AssemblyContextChanged(e);
            this.OnPropertyChanged("ParentStructure__AssemblyContext", e);
        }
        
        /// <summary>
        /// Raises the EncapsulatedComponent__AssemblyContextChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnEncapsulatedComponent__AssemblyContextChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.EncapsulatedComponent__AssemblyContextChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the EncapsulatedComponent__AssemblyContext property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetEncapsulatedComponent__AssemblyContext(object sender, EventArgs eventArgs)
        {
            this.EncapsulatedComponent__AssemblyContext = null;
        }
        
        /// <summary>
        /// Forwards change notifications for the ConfigParameterUsages__AssemblyContext property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ConfigParameterUsages__AssemblyContextCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ConfigParameterUsages__AssemblyContext", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "CONFIGPARAMETERUSAGES__ASSEMBLYCONTEXT"))
            {
                return this._configParameterUsages__AssemblyContext;
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
            if ((feature == "PARENTSTRUCTURE__ASSEMBLYCONTEXT"))
            {
                this.ParentStructure__AssemblyContext = ((IComposedStructure)(value));
                return;
            }
            if ((feature == "ENCAPSULATEDCOMPONENT__ASSEMBLYCONTEXT"))
            {
                this.EncapsulatedComponent__AssemblyContext = ((IRepositoryComponent)(value));
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
            if ((attribute == "PARENTSTRUCTURE__ASSEMBLYCONTEXT"))
            {
                return new ParentStructure__AssemblyContextProxy(this);
            }
            if ((attribute == "ENCAPSULATEDCOMPONENT__ASSEMBLYCONTEXT"))
            {
                return new EncapsulatedComponent__AssemblyContextProxy(this);
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
            if ((reference == "PARENTSTRUCTURE__ASSEMBLYCONTEXT"))
            {
                return new ParentStructure__AssemblyContextProxy(this);
            }
            if ((reference == "ENCAPSULATEDCOMPONENT__ASSEMBLYCONTEXT"))
            {
                return new EncapsulatedComponent__AssemblyContextProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//composition//AssemblyCon" +
                    "text/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssemblyContext class
        /// </summary>
        public class AssemblyContextChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AssemblyContext _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssemblyContextChildrenCollection(AssemblyContext parent)
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
                    count = (count + this._parent.ConfigParameterUsages__AssemblyContext.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ConfigParameterUsages__AssemblyContext.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ConfigParameterUsages__AssemblyContext.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage configParameterUsages__AssemblyContextCasted = item.As<IVariableUsage>();
                if ((configParameterUsages__AssemblyContextCasted != null))
                {
                    this._parent.ConfigParameterUsages__AssemblyContext.Add(configParameterUsages__AssemblyContextCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ConfigParameterUsages__AssemblyContext.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ConfigParameterUsages__AssemblyContext.Contains(item))
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
                IEnumerator<IModelElement> configParameterUsages__AssemblyContextEnumerator = this._parent.ConfigParameterUsages__AssemblyContext.GetEnumerator();
                try
                {
                    for (
                    ; configParameterUsages__AssemblyContextEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = configParameterUsages__AssemblyContextEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    configParameterUsages__AssemblyContextEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ConfigParameterUsages__AssemblyContext.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ConfigParameterUsages__AssemblyContext).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AssemblyContext class
        /// </summary>
        public class AssemblyContextReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AssemblyContext _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AssemblyContextReferencedElementsCollection(AssemblyContext parent)
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
                    if ((this._parent.ParentStructure__AssemblyContext != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.EncapsulatedComponent__AssemblyContext != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.ConfigParameterUsages__AssemblyContext.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParentStructure__AssemblyContextChanged += this.PropagateValueChanges;
                this._parent.EncapsulatedComponent__AssemblyContextChanged += this.PropagateValueChanges;
                this._parent.ConfigParameterUsages__AssemblyContext.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParentStructure__AssemblyContextChanged -= this.PropagateValueChanges;
                this._parent.EncapsulatedComponent__AssemblyContextChanged -= this.PropagateValueChanges;
                this._parent.ConfigParameterUsages__AssemblyContext.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ParentStructure__AssemblyContext == null))
                {
                    IComposedStructure parentStructure__AssemblyContextCasted = item.As<IComposedStructure>();
                    if ((parentStructure__AssemblyContextCasted != null))
                    {
                        this._parent.ParentStructure__AssemblyContext = parentStructure__AssemblyContextCasted;
                        return;
                    }
                }
                if ((this._parent.EncapsulatedComponent__AssemblyContext == null))
                {
                    IRepositoryComponent encapsulatedComponent__AssemblyContextCasted = item.As<IRepositoryComponent>();
                    if ((encapsulatedComponent__AssemblyContextCasted != null))
                    {
                        this._parent.EncapsulatedComponent__AssemblyContext = encapsulatedComponent__AssemblyContextCasted;
                        return;
                    }
                }
                IVariableUsage configParameterUsages__AssemblyContextCasted = item.As<IVariableUsage>();
                if ((configParameterUsages__AssemblyContextCasted != null))
                {
                    this._parent.ConfigParameterUsages__AssemblyContext.Add(configParameterUsages__AssemblyContextCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ParentStructure__AssemblyContext = null;
                this._parent.EncapsulatedComponent__AssemblyContext = null;
                this._parent.ConfigParameterUsages__AssemblyContext.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ParentStructure__AssemblyContext))
                {
                    return true;
                }
                if ((item == this._parent.EncapsulatedComponent__AssemblyContext))
                {
                    return true;
                }
                if (this._parent.ConfigParameterUsages__AssemblyContext.Contains(item))
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
                if ((this._parent.ParentStructure__AssemblyContext != null))
                {
                    array[arrayIndex] = this._parent.ParentStructure__AssemblyContext;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.EncapsulatedComponent__AssemblyContext != null))
                {
                    array[arrayIndex] = this._parent.EncapsulatedComponent__AssemblyContext;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> configParameterUsages__AssemblyContextEnumerator = this._parent.ConfigParameterUsages__AssemblyContext.GetEnumerator();
                try
                {
                    for (
                    ; configParameterUsages__AssemblyContextEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = configParameterUsages__AssemblyContextEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    configParameterUsages__AssemblyContextEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.ParentStructure__AssemblyContext == item))
                {
                    this._parent.ParentStructure__AssemblyContext = null;
                    return true;
                }
                if ((this._parent.EncapsulatedComponent__AssemblyContext == item))
                {
                    this._parent.EncapsulatedComponent__AssemblyContext = null;
                    return true;
                }
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ConfigParameterUsages__AssemblyContext.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ParentStructure__AssemblyContext).Concat(this._parent.EncapsulatedComponent__AssemblyContext).Concat(this._parent.ConfigParameterUsages__AssemblyContext).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parentStructure__AssemblyContext property
        /// </summary>
        private sealed class ParentStructure__AssemblyContextProxy : ModelPropertyChange<IAssemblyContext, IComposedStructure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentStructure__AssemblyContextProxy(IAssemblyContext modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IComposedStructure Value
            {
                get
                {
                    return this.ModelElement.ParentStructure__AssemblyContext;
                }
                set
                {
                    this.ModelElement.ParentStructure__AssemblyContext = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure__AssemblyContextChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ParentStructure__AssemblyContextChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the encapsulatedComponent__AssemblyContext property
        /// </summary>
        private sealed class EncapsulatedComponent__AssemblyContextProxy : ModelPropertyChange<IAssemblyContext, IRepositoryComponent>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public EncapsulatedComponent__AssemblyContextProxy(IAssemblyContext modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRepositoryComponent Value
            {
                get
                {
                    return this.ModelElement.EncapsulatedComponent__AssemblyContext;
                }
                set
                {
                    this.ModelElement.EncapsulatedComponent__AssemblyContext = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EncapsulatedComponent__AssemblyContextChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.EncapsulatedComponent__AssemblyContextChanged -= handler;
            }
        }
    }
}
