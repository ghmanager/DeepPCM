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
    
    
    public class QoSAnnotationsSpecifiedOutputParameterAbstractions_QoSAnnotationsCollection : ObservableOppositeList<IQoSAnnotations, ISpecifiedOutputParameterAbstraction>
    {
        
        public QoSAnnotationsSpecifiedOutputParameterAbstractions_QoSAnnotationsCollection(IQoSAnnotations parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((ISpecifiedOutputParameterAbstraction)(sender)));
        }
        
        protected override void SetOpposite(ISpecifiedOutputParameterAbstraction item, IQoSAnnotations parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.QosAnnotations_SpecifiedOutputParameterAbstraction = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.QosAnnotations_SpecifiedOutputParameterAbstraction == this.Parent))
                {
                    item.QosAnnotations_SpecifiedOutputParameterAbstraction = parent;
                }
            }
        }
    }
}

