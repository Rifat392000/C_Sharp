﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanySolution
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CompanyDB")]
	public partial class CompanyDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertemployee(employee instance);
    partial void Updateemployee(employee instance);
    partial void Deleteemployee(employee instance);
    #endregion
		
		public CompanyDBDataContext() : 
				base(global::CompanySolution.Properties.Settings.Default.CompanyDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CompanyDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<employee> employees
		{
			get
			{
				return this.GetTable<employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.employee")]
	public partial class employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _eno;
		
		private string _ename;
		
		private string _job;
		
		private decimal _salary;
		
		private string _dname;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnenoChanging(int value);
    partial void OnenoChanged();
    partial void OnenameChanging(string value);
    partial void OnenameChanged();
    partial void OnjobChanging(string value);
    partial void OnjobChanged();
    partial void OnsalaryChanging(decimal value);
    partial void OnsalaryChanged();
    partial void OndnameChanging(string value);
    partial void OndnameChanged();
    #endregion
		
		public employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eno", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int eno
		{
			get
			{
				return this._eno;
			}
			set
			{
				if ((this._eno != value))
				{
					this.OnenoChanging(value);
					this.SendPropertyChanging();
					this._eno = value;
					this.SendPropertyChanged("eno");
					this.OnenoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ename", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ename
		{
			get
			{
				return this._ename;
			}
			set
			{
				if ((this._ename != value))
				{
					this.OnenameChanging(value);
					this.SendPropertyChanging();
					this._ename = value;
					this.SendPropertyChanged("ename");
					this.OnenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_job", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string job
		{
			get
			{
				return this._job;
			}
			set
			{
				if ((this._job != value))
				{
					this.OnjobChanging(value);
					this.SendPropertyChanging();
					this._job = value;
					this.SendPropertyChanged("job");
					this.OnjobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="Decimal(10,2) NOT NULL")]
		public decimal salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string dname
		{
			get
			{
				return this._dname;
			}
			set
			{
				if ((this._dname != value))
				{
					this.OndnameChanging(value);
					this.SendPropertyChanging();
					this._dname = value;
					this.SendPropertyChanged("dname");
					this.OndnameChanged();
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
