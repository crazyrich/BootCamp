﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace OneToMany
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class onetomanyContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new onetomanyContainer object using the connection string found in the 'onetomanyContainer' section of the application configuration file.
        /// </summary>
        public onetomanyContainer() : base("name=onetomanyContainer", "onetomanyContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new onetomanyContainer object.
        /// </summary>
        public onetomanyContainer(string connectionString) : base(connectionString, "onetomanyContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new onetomanyContainer object.
        /// </summary>
        public onetomanyContainer(EntityConnection connection) : base(connection, "onetomanyContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
