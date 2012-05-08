﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loopc.Repository.Entity
{
    using System;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data.Linq.Mapping;


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name = "PlatformDB")]
    public partial class LoopcDataContext : System.Data.Linq.DataContext
    {

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();

        #region Extensibility Method Definitions
        partial void OnCreated();
        partial void InsertConfiguration(Configuration instance);
        partial void UpdateConfiguration(Configuration instance);
        partial void DeleteConfiguration(Configuration instance);
        #endregion

        public LoopcDataContext() :
            base(ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString, mappingSource)
        {
            OnCreated();
        }

        public LoopcDataContext(string connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public LoopcDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public LoopcDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public LoopcDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) :
            base(connection, mappingSource)
        {
            OnCreated();
        }

        public System.Data.Linq.Table<Configuration> Configurations
        {
            get
            {
                return this.GetTable<Configuration>();
            }
        }
    }

    [global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Configuration")]
    public partial class Configuration : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);

        private int _Id;

        private string _Name;

        private string _Value;

        #region Extensibility Method Definitions
        partial void OnLoaded();
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        partial void OnCreated();
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
        #endregion

        public Configuration()
        {
            OnCreated();
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "Int NOT NULL", IsPrimaryKey = true)]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this.OnIdChanging(value);
                    this.SendPropertyChanging();
                    this._Id = value;
                    this.SendPropertyChanged("Id");
                    this.OnIdChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "VarChar(50) NOT NULL", CanBeNull = false)]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this.OnNameChanging(value);
                    this.SendPropertyChanging();
                    this._Name = value;
                    this.SendPropertyChanged("Name");
                    this.OnNameChanged();
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Value", DbType = "NVarChar(500)")]
        public string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                if ((this._Value != value))
                {
                    this.OnValueChanging(value);
                    this.SendPropertyChanging();
                    this._Value = value;
                    this.SendPropertyChanged("Value");
                    this.OnValueChanged();
                }
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        protected virtual void SendPropertyChanged(String propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
#pragma warning restore 1591
