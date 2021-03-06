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
using DeepPCM.Deeppcm.Core.Entity;
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

namespace DeepPCM.Deeppcm.Resourceenvironment
{
    
    
    public class ResourceContainerNestedResourceContainers__ResourceContainerCollection : ObservableOppositeList<IResourceContainer, IResourceContainer>
    {
        
        public ResourceContainerNestedResourceContainers__ResourceContainerCollection(IResourceContainer parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IResourceContainer)(sender)));
        }
        
        protected override void SetOpposite(IResourceContainer item, IResourceContainer parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.ParentResourceContainer__ResourceContainer = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.ParentResourceContainer__ResourceContainer == this.Parent))
                {
                    item.ParentResourceContainer__ResourceContainer = parent;
                }
            }
        }
    }
}

