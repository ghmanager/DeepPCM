//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Repository;
using DeepPCM.Deeppcm.System0;
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

namespace DeepPCM.Deeppcm.Qosannotations
{
    
    
    public class SpecifiedOutputParameterAbstractionExpectedExternalOutputs_SpecifiedOutputParameterAbstractionCollection : ObservableOppositeList<ISpecifiedOutputParameterAbstraction, IVariableUsage>
    {
        
        public SpecifiedOutputParameterAbstractionExpectedExternalOutputs_SpecifiedOutputParameterAbstractionCollection(ISpecifiedOutputParameterAbstraction parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IVariableUsage)(sender)));
        }
        
        protected override void SetOpposite(IVariableUsage item, ISpecifiedOutputParameterAbstraction parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.SpecifiedOutputParameterAbstraction_expectedExternalOutputs_VariableUsage = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.SpecifiedOutputParameterAbstraction_expectedExternalOutputs_VariableUsage == this.Parent))
                {
                    item.SpecifiedOutputParameterAbstraction_expectedExternalOutputs_VariableUsage = parent;
                }
            }
        }
    }
}

