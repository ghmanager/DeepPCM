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
using GeneratedCode.Pcm.Core.Composition;
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

namespace GeneratedCode.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The public interface for OpenWorkload
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(OpenWorkload))]
    [XmlDefaultImplementationTypeAttribute(typeof(OpenWorkload))]
    public interface IOpenWorkload : IModelElement, IWorkload
    {
        
        /// <summary>
        /// The interArrivalTime_OpenWorkload property
        /// </summary>
        IPCMRandomVariable InterArrivalTime_OpenWorkload
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the InterArrivalTime_OpenWorkload property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> InterArrivalTime_OpenWorkloadChanged;
    }
}
