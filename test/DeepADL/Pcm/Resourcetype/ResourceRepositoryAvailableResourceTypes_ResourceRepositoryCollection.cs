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
using GeneratedCode.Pcm.Core.Entity;
using GeneratedCode.Pcm.Reliability;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Units;
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

namespace GeneratedCode.Pcm.Resourcetype
{
    
    
    public class ResourceRepositoryAvailableResourceTypes_ResourceRepositoryCollection : ObservableOppositeList<IResourceRepository, IResourceType>
    {
        
        public ResourceRepositoryAvailableResourceTypes_ResourceRepositoryCollection(IResourceRepository parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IResourceType)(sender)));
        }
        
        protected override void SetOpposite(IResourceType item, IResourceRepository parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.ResourceRepository_ResourceType = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.ResourceRepository_ResourceType == this.Parent))
                {
                    item.ResourceRepository_ResourceType = parent;
                }
            }
        }
    }
}

