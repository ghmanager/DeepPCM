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
using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Reliability;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Seff.Seff_performance;
using Metamodel.DeepPCM.Seff.Seff_reliability;
using Metamodel.Identifier;
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

namespace Metamodel.DeepPCM.Seff
{
    
    
    public class InternalActionInternalFailureOccurrenceDescriptions__InternalActionCollection : ObservableOppositeList<IInternalAction, IInternalFailureOccurrenceDescription>
    {
        
        public InternalActionInternalFailureOccurrenceDescriptions__InternalActionCollection(IInternalAction parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IInternalFailureOccurrenceDescription)(sender)));
        }
        
        protected override void SetOpposite(IInternalFailureOccurrenceDescription item, IInternalAction parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.InternalAction__InternalFailureOccurrenceDescription = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.InternalAction__InternalFailureOccurrenceDescription == this.Parent))
                {
                    item.InternalAction__InternalFailureOccurrenceDescription = parent;
                }
            }
        }
    }
}

