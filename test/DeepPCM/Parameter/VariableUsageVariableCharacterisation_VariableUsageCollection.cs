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
using Metamodel.DeepPCM.Seff;
using Metamodel.DeepPCM.Usagemodel;
using Metamodel.Stoex;
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

namespace Metamodel.DeepPCM.Parameter
{
    
    
    public class VariableUsageVariableCharacterisation_VariableUsageCollection : ObservableOppositeList<IVariableUsage, IVariableCharacterisation>
    {
        
        public VariableUsageVariableCharacterisation_VariableUsageCollection(IVariableUsage parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IVariableCharacterisation)(sender)));
        }
        
        protected override void SetOpposite(IVariableCharacterisation item, IVariableUsage parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.VariableUsage_VariableCharacterisation = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.VariableUsage_VariableCharacterisation == this.Parent))
                {
                    item.VariableUsage_VariableCharacterisation = parent;
                }
            }
        }
    }
}

