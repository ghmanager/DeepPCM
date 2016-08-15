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
    
    
    public class ComposedStructureResourceRequiredDelegationConnectors_ComposedStructureCollection : ObservableOppositeList<IComposedStructure, IResourceRequiredDelegationConnector>
    {
        
        public ComposedStructureResourceRequiredDelegationConnectors_ComposedStructureCollection(IComposedStructure parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IResourceRequiredDelegationConnector)(sender)));
        }
        
        protected override void SetOpposite(IResourceRequiredDelegationConnector item, IComposedStructure parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.ParentStructure_ResourceRequiredDelegationConnector = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.ParentStructure_ResourceRequiredDelegationConnector == this.Parent))
                {
                    item.ParentStructure_ResourceRequiredDelegationConnector = parent;
                }
            }
        }
    }
}
