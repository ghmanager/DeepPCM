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
    /// The public interface for ClosedWorkload
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ClosedWorkload))]
    [XmlDefaultImplementationTypeAttribute(typeof(ClosedWorkload))]
    public interface IClosedWorkload : IModelElement, IWorkload
    {
        
        /// <summary>
        /// The population property
        /// </summary>
        int Population
        {
            get;
            set;
        }
        
        /// <summary>
        /// The thinkTime_ClosedWorkload property
        /// </summary>
        IPCMRandomVariable ThinkTime_ClosedWorkload
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Population property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> PopulationChanged;
        
        /// <summary>
        /// Gets fired when the ThinkTime_ClosedWorkload property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ThinkTime_ClosedWorkloadChanged;
    }
}
