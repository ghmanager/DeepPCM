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
using Metamodel.DeepPCM.Qosannotations;
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

namespace Metamodel.DeepPCM.Qosannotations.Qos_performance
{
    
    
    /// <summary>
    /// The default implementation of the ComponentSpecifiedExecutionTime class
    /// </summary>
    [XmlNamespaceAttribute("http://github.com/ghmanager/DeepPCM/QoSAnnotations/QoS_Performance/1.0")]
    [XmlNamespacePrefixAttribute("")]
    [ModelRepresentationClassAttribute("http://github.com/ghmanager/DeepPCM/1.0#//qosannotations//qos_performance//Compon" +
        "entSpecifiedExecutionTime/")]
    public class ComponentSpecifiedExecutionTime : SpecifiedExecutionTime, IComponentSpecifiedExecutionTime, IModelElement
    {
        
        /// <summary>
        /// The backing field for the AssemblyContext_ComponentSpecifiedExecutionTime property
        /// </summary>
        private IAssemblyContext _assemblyContext_ComponentSpecifiedExecutionTime;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The assemblyContext_ComponentSpecifiedExecutionTime property
        /// </summary>
        [XmlElementNameAttribute("assemblyContext_ComponentSpecifiedExecutionTime")]
        [XmlAttributeAttribute(true)]
        public virtual IAssemblyContext AssemblyContext_ComponentSpecifiedExecutionTime
        {
            get
            {
                return this._assemblyContext_ComponentSpecifiedExecutionTime;
            }
            set
            {
                if ((this._assemblyContext_ComponentSpecifiedExecutionTime != value))
                {
                    IAssemblyContext old = this._assemblyContext_ComponentSpecifiedExecutionTime;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAssemblyContext_ComponentSpecifiedExecutionTimeChanging(e);
                    this.OnPropertyChanging("AssemblyContext_ComponentSpecifiedExecutionTime", e);
                    this._assemblyContext_ComponentSpecifiedExecutionTime = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAssemblyContext_ComponentSpecifiedExecutionTime;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAssemblyContext_ComponentSpecifiedExecutionTime;
                    }
                    this.OnAssemblyContext_ComponentSpecifiedExecutionTimeChanged(e);
                    this.OnPropertyChanged("AssemblyContext_ComponentSpecifiedExecutionTime", e);
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
                return base.ReferencedElements.Concat(new ComponentSpecifiedExecutionTimeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//qosannotations//qos_performance//Compon" +
                            "entSpecifiedExecutionTime/")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the AssemblyContext_ComponentSpecifiedExecutionTime property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AssemblyContext_ComponentSpecifiedExecutionTimeChanging;
        
        /// <summary>
        /// Gets fired when the AssemblyContext_ComponentSpecifiedExecutionTime property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> AssemblyContext_ComponentSpecifiedExecutionTimeChanged;
        
        /// <summary>
        /// Raises the AssemblyContext_ComponentSpecifiedExecutionTimeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext_ComponentSpecifiedExecutionTimeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext_ComponentSpecifiedExecutionTimeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AssemblyContext_ComponentSpecifiedExecutionTimeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext_ComponentSpecifiedExecutionTimeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext_ComponentSpecifiedExecutionTimeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AssemblyContext_ComponentSpecifiedExecutionTime property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAssemblyContext_ComponentSpecifiedExecutionTime(object sender, System.EventArgs eventArgs)
        {
            this.AssemblyContext_ComponentSpecifiedExecutionTime = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "ASSEMBLYCONTEXT_COMPONENTSPECIFIEDEXECUTIONTIME"))
            {
                this.AssemblyContext_ComponentSpecifiedExecutionTime = ((IAssemblyContext)(value));
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
            if ((attribute == "ASSEMBLYCONTEXT_COMPONENTSPECIFIEDEXECUTIONTIME"))
            {
                return new AssemblyContext_ComponentSpecifiedExecutionTimeProxy(this);
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
            if ((reference == "ASSEMBLYCONTEXT_COMPONENTSPECIFIEDEXECUTIONTIME"))
            {
                return new AssemblyContext_ComponentSpecifiedExecutionTimeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://github.com/ghmanager/DeepPCM/1.0#//qosannotations//qos_performance//Compon" +
                        "entSpecifiedExecutionTime/")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ComponentSpecifiedExecutionTime class
        /// </summary>
        public class ComponentSpecifiedExecutionTimeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ComponentSpecifiedExecutionTime _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ComponentSpecifiedExecutionTimeReferencedElementsCollection(ComponentSpecifiedExecutionTime parent)
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
                    if ((this._parent.AssemblyContext_ComponentSpecifiedExecutionTime != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AssemblyContext_ComponentSpecifiedExecutionTimeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AssemblyContext_ComponentSpecifiedExecutionTimeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.AssemblyContext_ComponentSpecifiedExecutionTime == null))
                {
                    IAssemblyContext assemblyContext_ComponentSpecifiedExecutionTimeCasted = item.As<IAssemblyContext>();
                    if ((assemblyContext_ComponentSpecifiedExecutionTimeCasted != null))
                    {
                        this._parent.AssemblyContext_ComponentSpecifiedExecutionTime = assemblyContext_ComponentSpecifiedExecutionTimeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AssemblyContext_ComponentSpecifiedExecutionTime = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.AssemblyContext_ComponentSpecifiedExecutionTime))
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
                if ((this._parent.AssemblyContext_ComponentSpecifiedExecutionTime != null))
                {
                    array[arrayIndex] = this._parent.AssemblyContext_ComponentSpecifiedExecutionTime;
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
                if ((this._parent.AssemblyContext_ComponentSpecifiedExecutionTime == item))
                {
                    this._parent.AssemblyContext_ComponentSpecifiedExecutionTime = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AssemblyContext_ComponentSpecifiedExecutionTime).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the assemblyContext_ComponentSpecifiedExecutionTime property
        /// </summary>
        private sealed class AssemblyContext_ComponentSpecifiedExecutionTimeProxy : ModelPropertyChange<IComponentSpecifiedExecutionTime, IAssemblyContext>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AssemblyContext_ComponentSpecifiedExecutionTimeProxy(IComponentSpecifiedExecutionTime modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAssemblyContext Value
            {
                get
                {
                    return this.ModelElement.AssemblyContext_ComponentSpecifiedExecutionTime;
                }
                set
                {
                    this.ModelElement.AssemblyContext_ComponentSpecifiedExecutionTime = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AssemblyContext_ComponentSpecifiedExecutionTimeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.AssemblyContext_ComponentSpecifiedExecutionTimeChanged -= handler;
            }
        }
    }
}
