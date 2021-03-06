﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace CachingDemo.Web.Models.Data
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class CachingDemoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new CachingDemoEntities object using the connection string found in the 'CachingDemoEntities' section of the application configuration file.
        /// </summary>
        public CachingDemoEntities() : base("name=CachingDemoEntities", "CachingDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CachingDemoEntities object.
        /// </summary>
        public CachingDemoEntities(string connectionString) : base(connectionString, "CachingDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new CachingDemoEntities object.
        /// </summary>
        public CachingDemoEntities(EntityConnection connection) : base(connection, "CachingDemoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Vehicle> Vehicles
        {
            get
            {
                if ((_Vehicles == null))
                {
                    _Vehicles = base.CreateObjectSet<Vehicle>("Vehicles");
                }
                return _Vehicles;
            }
        }
        private ObjectSet<Vehicle> _Vehicles;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Vehicles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToVehicles(Vehicle vehicle)
        {
            base.AddObject("Vehicles", vehicle);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="CachingDemoModel", Name="Vehicle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Vehicle : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Vehicle object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="price">Initial value of the Price property.</param>
        public static Vehicle CreateVehicle(global::System.Guid id, global::System.String name, global::System.Decimal price)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Id = id;
            vehicle.Name = name;
            vehicle.Price = price;
            return vehicle;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.Decimal _Price;
        partial void OnPriceChanging(global::System.Decimal value);
        partial void OnPriceChanged();

        #endregion
    
    }

    #endregion
    
}
