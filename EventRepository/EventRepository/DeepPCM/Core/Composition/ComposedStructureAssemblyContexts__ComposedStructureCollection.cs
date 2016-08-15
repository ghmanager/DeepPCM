//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Metamodel.DeepPCM.Core.Entity;
using Metamodel.DeepPCM.Parameter;
using Metamodel.DeepPCM.Repository;
using Metamodel.DeepPCM.Resourcetype;
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace Metamodel.DeepPCM.Core.Composition
{
    
    
    public class ComposedStructureAssemblyContexts__ComposedStructureCollection : ObservableOppositeList<IComposedStructure, IAssemblyContext>
    {
        
        public ComposedStructureAssemblyContexts__ComposedStructureCollection(IComposedStructure parent) : 
                base(parent)
        {
        }
        
        private void OnItemDeleted(object sender, System.EventArgs e)
        {
            this.Remove(((IAssemblyContext)(sender)));
        }
        
        protected override void SetOpposite(IAssemblyContext item, IComposedStructure parent)
        {
            if ((parent != null))
            {
                item.Deleted += this.OnItemDeleted;
                item.ComposedStructure__AssemblyContext = parent;
            }
            else
            {
                item.Deleted -= this.OnItemDeleted;
                if ((item.ComposedStructure__AssemblyContext == this.Parent))
                {
                    item.ComposedStructure__AssemblyContext = parent;
                }
            }
        }
    }
}

