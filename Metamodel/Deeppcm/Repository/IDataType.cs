//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using DeepPCM.Deeppcm.Core;
using DeepPCM.Deeppcm.Core.Composition;
using DeepPCM.Deeppcm.Core.Entity;
using DeepPCM.Deeppcm.Parameter;
using DeepPCM.Deeppcm.Protocol;
using DeepPCM.Deeppcm.Reliability;
using DeepPCM.Deeppcm.Resourcetype;
using DeepPCM.Deeppcm.Seff;
using DeepPCM.Identifier;
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

namespace DeepPCM.Deeppcm.Repository
{
    
    
    /// <summary>
    /// The public interface for DataType
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(DataType))]
    [XmlDefaultImplementationTypeAttribute(typeof(DataType))]
    public interface IDataType : IModelElement
    {
        
        /// <summary>
        /// The repository__DataType property
        /// </summary>
        IRepository Repository__DataType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Repository__DataType property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> Repository__DataTypeChanged;
    }
}

