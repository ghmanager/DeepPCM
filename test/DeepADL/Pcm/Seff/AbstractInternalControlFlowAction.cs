//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using GeneratedCode.Identifier;
using GeneratedCode.Pcm.Core;
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Parameter;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Seff.Seff_performance;
using GeneratedCode.Pcm.Seff.Seff_reliability;
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

namespace GeneratedCode.Pcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the AbstractInternalControlFlowAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//AbstractInternalControlF" +
        "lowAction/")]
    [DebuggerDisplayAttribute("AbstractInternalControlFlowAction {Id}")]
    public abstract class AbstractInternalControlFlowAction : AbstractAction, IAbstractInternalControlFlowAction, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceDemand_Action property
        /// </summary>
        private AbstractInternalControlFlowActionResourceDemand_ActionCollection _resourceDemand_Action;
        
        /// <summary>
        /// The backing field for the InfrastructureCall__Action property
        /// </summary>
        private AbstractInternalControlFlowActionInfrastructureCall__ActionCollection _infrastructureCall__Action;
        
        /// <summary>
        /// The backing field for the ResourceCall__Action property
        /// </summary>
        private AbstractInternalControlFlowActionResourceCall__ActionCollection _resourceCall__Action;
        
        public AbstractInternalControlFlowAction()
        {
            this._resourceDemand_Action = new AbstractInternalControlFlowActionResourceDemand_ActionCollection(this);
            this._resourceDemand_Action.CollectionChanged += this.ResourceDemand_ActionCollectionChanged;
            this._infrastructureCall__Action = new AbstractInternalControlFlowActionInfrastructureCall__ActionCollection(this);
            this._infrastructureCall__Action.CollectionChanged += this.InfrastructureCall__ActionCollectionChanged;
            this._resourceCall__Action = new AbstractInternalControlFlowActionResourceCall__ActionCollection(this);
            this._resourceCall__Action.CollectionChanged += this.ResourceCall__ActionCollectionChanged;
        }
        
        /// <summary>
        /// The resourceDemand_Action property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceDemand_Action")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("action_ParametricResourceDemand")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IParametricResourceDemand> ResourceDemand_Action
        {
            get
            {
                return this._resourceDemand_Action;
            }
        }
        
        /// <summary>
        /// The infrastructureCall__Action property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("infrastructureCall__Action")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("action__InfrastructureCall")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IInfrastructureCall> InfrastructureCall__Action
        {
            get
            {
                return this._infrastructureCall__Action;
            }
        }
        
        /// <summary>
        /// The resourceCall__Action property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceCall__Action")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("action__ResourceCall")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceCall> ResourceCall__Action
        {
            get
            {
                return this._resourceCall__Action;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new AbstractInternalControlFlowActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AbstractInternalControlFlowActionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//AbstractInternalControlF" +
                        "lowAction/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the ResourceDemand_Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceDemand_ActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceDemand_Action", e);
        }
        
        /// <summary>
        /// Forwards change notifications for the InfrastructureCall__Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InfrastructureCall__ActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InfrastructureCall__Action", e);
        }
        
        /// <summary>
        /// Forwards change notifications for the ResourceCall__Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceCall__ActionCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceCall__Action", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RESOURCEDEMAND_ACTION"))
            {
                return this._resourceDemand_Action;
            }
            if ((feature == "INFRASTRUCTURECALL__ACTION"))
            {
                return this._infrastructureCall__Action;
            }
            if ((feature == "RESOURCECALL__ACTION"))
            {
                return this._resourceCall__Action;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff//AbstractInternalControlF" +
                    "lowAction/")));
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AbstractInternalControlFlowAction class
        /// </summary>
        public class AbstractInternalControlFlowActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AbstractInternalControlFlowAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AbstractInternalControlFlowActionChildrenCollection(AbstractInternalControlFlowAction parent)
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
                    count = (count + this._parent.ResourceDemand_Action.Count);
                    count = (count + this._parent.InfrastructureCall__Action.Count);
                    count = (count + this._parent.ResourceCall__Action.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IParametricResourceDemand resourceDemand_ActionCasted = item.As<IParametricResourceDemand>();
                if ((resourceDemand_ActionCasted != null))
                {
                    this._parent.ResourceDemand_Action.Add(resourceDemand_ActionCasted);
                }
                IInfrastructureCall infrastructureCall__ActionCasted = item.As<IInfrastructureCall>();
                if ((infrastructureCall__ActionCasted != null))
                {
                    this._parent.InfrastructureCall__Action.Add(infrastructureCall__ActionCasted);
                }
                IResourceCall resourceCall__ActionCasted = item.As<IResourceCall>();
                if ((resourceCall__ActionCasted != null))
                {
                    this._parent.ResourceCall__Action.Add(resourceCall__ActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceDemand_Action.Clear();
                this._parent.InfrastructureCall__Action.Clear();
                this._parent.ResourceCall__Action.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceDemand_Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.InfrastructureCall__Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceCall__Action.Contains(item))
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
                IEnumerator<IModelElement> resourceDemand_ActionEnumerator = this._parent.ResourceDemand_Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceDemand_ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceDemand_ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceDemand_ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> infrastructureCall__ActionEnumerator = this._parent.InfrastructureCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; infrastructureCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = infrastructureCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    infrastructureCall__ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceCall__ActionEnumerator = this._parent.ResourceCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceCall__ActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IParametricResourceDemand parametricResourceDemandItem = item.As<IParametricResourceDemand>();
                if (((parametricResourceDemandItem != null) 
                            && this._parent.ResourceDemand_Action.Remove(parametricResourceDemandItem)))
                {
                    return true;
                }
                IInfrastructureCall infrastructureCallItem = item.As<IInfrastructureCall>();
                if (((infrastructureCallItem != null) 
                            && this._parent.InfrastructureCall__Action.Remove(infrastructureCallItem)))
                {
                    return true;
                }
                IResourceCall resourceCallItem = item.As<IResourceCall>();
                if (((resourceCallItem != null) 
                            && this._parent.ResourceCall__Action.Remove(resourceCallItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceDemand_Action).Concat(this._parent.InfrastructureCall__Action).Concat(this._parent.ResourceCall__Action).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AbstractInternalControlFlowAction class
        /// </summary>
        public class AbstractInternalControlFlowActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AbstractInternalControlFlowAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AbstractInternalControlFlowActionReferencedElementsCollection(AbstractInternalControlFlowAction parent)
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
                    count = (count + this._parent.ResourceDemand_Action.Count);
                    count = (count + this._parent.InfrastructureCall__Action.Count);
                    count = (count + this._parent.ResourceCall__Action.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IParametricResourceDemand resourceDemand_ActionCasted = item.As<IParametricResourceDemand>();
                if ((resourceDemand_ActionCasted != null))
                {
                    this._parent.ResourceDemand_Action.Add(resourceDemand_ActionCasted);
                }
                IInfrastructureCall infrastructureCall__ActionCasted = item.As<IInfrastructureCall>();
                if ((infrastructureCall__ActionCasted != null))
                {
                    this._parent.InfrastructureCall__Action.Add(infrastructureCall__ActionCasted);
                }
                IResourceCall resourceCall__ActionCasted = item.As<IResourceCall>();
                if ((resourceCall__ActionCasted != null))
                {
                    this._parent.ResourceCall__Action.Add(resourceCall__ActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceDemand_Action.Clear();
                this._parent.InfrastructureCall__Action.Clear();
                this._parent.ResourceCall__Action.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceDemand_Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.InfrastructureCall__Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceCall__Action.Contains(item))
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
                IEnumerator<IModelElement> resourceDemand_ActionEnumerator = this._parent.ResourceDemand_Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceDemand_ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceDemand_ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceDemand_ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> infrastructureCall__ActionEnumerator = this._parent.InfrastructureCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; infrastructureCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = infrastructureCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    infrastructureCall__ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceCall__ActionEnumerator = this._parent.ResourceCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceCall__ActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IParametricResourceDemand parametricResourceDemandItem = item.As<IParametricResourceDemand>();
                if (((parametricResourceDemandItem != null) 
                            && this._parent.ResourceDemand_Action.Remove(parametricResourceDemandItem)))
                {
                    return true;
                }
                IInfrastructureCall infrastructureCallItem = item.As<IInfrastructureCall>();
                if (((infrastructureCallItem != null) 
                            && this._parent.InfrastructureCall__Action.Remove(infrastructureCallItem)))
                {
                    return true;
                }
                IResourceCall resourceCallItem = item.As<IResourceCall>();
                if (((resourceCallItem != null) 
                            && this._parent.ResourceCall__Action.Remove(resourceCallItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceDemand_Action).Concat(this._parent.InfrastructureCall__Action).Concat(this._parent.ResourceCall__Action).GetEnumerator();
            }
        }
    }
}

