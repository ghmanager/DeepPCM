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
    /// The default implementation of the ResourceInterfaceProvidingRequiringEntity class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Entity/5.0")]
    [XmlNamespacePrefixAttribute("entity")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceInterfac" +
        "eProvidingRequiringEntity/")]
    [DebuggerDisplayAttribute("ResourceInterfaceProvidingRequiringEntity {Id}")]
    public class ResourceInterfaceProvidingRequiringEntity : ResourceInterfaceRequiringEntity, IResourceInterfaceProvidingRequiringEntity, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ResourceProvidedRoles__ResourceInterfaceProvidingEntity property
        /// </summary>
        private DeepPCM.Deeppcm.Core.Entity.ResourceInterfaceProvidingEntityResourceProvidedRoles__ResourceInterfaceProvidingEntityCollection _resourceProvidedRoles__ResourceInterfaceProvidingEntity;
        
        public ResourceInterfaceProvidingRequiringEntity()
        {
            this._resourceProvidedRoles__ResourceInterfaceProvidingEntity = new ResourceInterfaceProvidingEntityResourceProvidedRoles__ResourceInterfaceProvidingEntityCollection(this);
            this._resourceProvidedRoles__ResourceInterfaceProvidingEntity.CollectionChanged += this.ResourceProvidedRoles__ResourceInterfaceProvidingEntityCollectionChanged;
        }
        
        /// <summary>
        /// The resourceProvidedRoles__ResourceInterfaceProvidingEntity property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceProvidedRoles__ResourceInterfaceProvidingEntity")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("resourceInterfaceProvidingEntity__ResourceProvidedRole")]
        [ConstantAttribute()]
        public virtual ICollectionExpression<IResourceProvidedRole> ResourceProvidedRoles__ResourceInterfaceProvidingEntity
        {
            get
            {
                return this._resourceProvidedRoles__ResourceInterfaceProvidingEntity;
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceInterfac" +
                        "eProvidingRequiringEntity/");
            }
        }
        
        /// <summary>
        /// Forwards change notifications for the ResourceProvidedRoles__ResourceInterfaceProvidingEntity property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceProvidedRoles__ResourceInterfaceProvidingEntityCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceProvidedRoles__ResourceInterfaceProvidingEntity", e);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "RESOURCEPROVIDEDROLES__RESOURCEINTERFACEPROVIDINGENTITY"))
            {
                return this._resourceProvidedRoles__ResourceInterfaceProvidingEntity;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            return ((IClass)(NMF.Models.Repository.MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core//entity//ResourceInterfac" +
                    "eProvidingRequiringEntity/")));
        }
    }
}

