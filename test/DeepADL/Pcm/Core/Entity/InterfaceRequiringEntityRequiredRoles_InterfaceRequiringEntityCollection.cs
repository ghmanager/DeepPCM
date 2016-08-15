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
using GeneratedCode.Pcm.Core.Composition;
using GeneratedCode.Pcm.Repository;
using GeneratedCode.Pcm.Resourcetype;
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

namespace GeneratedCode.Pcm.Core.Entity
{
    
    
    public class InterfaceRequiringEntityRequiredRoles_InterfaceRequiringEntityCollection : ObservableOppositeList<IInterfaceRequiringEntity, IRequiredRole>
    {
        
        public InterfaceRequiringEntityRequiredRoles_InterfaceRequiringEntityCollection(IInterfaceRequiringEntity parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IRequiredRole)(sender)));
        }
        
        protected override void SetOpposite(IRequiredRole item, IInterfaceRequiringEntity parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.RequiringEntity_RequiredRole = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.RequiringEntity_RequiredRole == this.Parent))
                {
                    item.RequiringEntity_RequiredRole = parent;
                }
            }
        }
    }
}

