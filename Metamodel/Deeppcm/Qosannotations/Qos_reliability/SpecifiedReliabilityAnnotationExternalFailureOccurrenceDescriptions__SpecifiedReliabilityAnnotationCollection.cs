//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Qosannotations;
using DeepPCM.Deeppcm.Reliability;
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

namespace DeepPCM.Deeppcm.Qosannotations.Qos_reliability
{
    
    
    public class SpecifiedReliabilityAnnotationExternalFailureOccurrenceDescriptions__SpecifiedReliabilityAnnotationCollection : ObservableOppositeList<ISpecifiedReliabilityAnnotation, IExternalFailureOccurrenceDescription>
    {
        
        public SpecifiedReliabilityAnnotationExternalFailureOccurrenceDescriptions__SpecifiedReliabilityAnnotationCollection(ISpecifiedReliabilityAnnotation parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, EventArgs e)
        {
            this.Remove(((IExternalFailureOccurrenceDescription)(sender)));
        }
        
        protected override void SetOpposite(IExternalFailureOccurrenceDescription item, ISpecifiedReliabilityAnnotation parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.SpecifiedReliabilityAnnotation__ExternalFailureOccurrenceDescription = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.SpecifiedReliabilityAnnotation__ExternalFailureOccurrenceDescription == this.Parent))
                {
                    item.SpecifiedReliabilityAnnotation__ExternalFailureOccurrenceDescription = parent;
                }
            }
        }
    }
}

