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

namespace SiteMaster
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="PIM4DB")]
	public partial class PIM4LINQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public PIM4LINQDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PIM4DBConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PIM4LINQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PIM4LINQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PIM4LINQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PIM4LINQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdUser;
		
		private string _Username;
		
		private string _Email;
		
		private string _Password;
		
		private string _Birthday;
		
		private string _Document;
		
		private decimal _btcValue;
		
		private decimal _ethValue;
		
		private decimal _dogeValue;
		
		private decimal _usdtValue;
		
		private decimal _xrpValue;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdUserChanging(int value);
    partial void OnIdUserChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBirthdayChanging(string value);
    partial void OnBirthdayChanged();
    partial void OnDocumentChanging(string value);
    partial void OnDocumentChanged();
    partial void OnbtcValueChanging(decimal value);
    partial void OnbtcValueChanged();
    partial void OnethValueChanging(decimal value);
    partial void OnethValueChanged();
    partial void OndogeValueChanging(decimal value);
    partial void OndogeValueChanged();
    partial void OnusdtValueChanging(decimal value);
    partial void OnusdtValueChanged();
    partial void OnxrpValueChanging(decimal value);
    partial void OnxrpValueChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdUser", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdUser
		{
			get
			{
				return this._IdUser;
			}
			set
			{
				if ((this._IdUser != value))
				{
					this.OnIdUserChanging(value);
					this.SendPropertyChanging();
					this._IdUser = value;
					this.SendPropertyChanged("IdUser");
					this.OnIdUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthday", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Birthday
		{
			get
			{
				return this._Birthday;
			}
			set
			{
				if ((this._Birthday != value))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._Birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Document", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string Document
		{
			get
			{
				return this._Document;
			}
			set
			{
				if ((this._Document != value))
				{
					this.OnDocumentChanging(value);
					this.SendPropertyChanging();
					this._Document = value;
					this.SendPropertyChanged("Document");
					this.OnDocumentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_btcValue", DbType="Decimal(16,8) NOT NULL")]
		public decimal btcValue
		{
			get
			{
				return this._btcValue;
			}
			set
			{
				if ((this._btcValue != value))
				{
					this.OnbtcValueChanging(value);
					this.SendPropertyChanging();
					this._btcValue = value;
					this.SendPropertyChanged("btcValue");
					this.OnbtcValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ethValue", DbType="Decimal(16,8) NOT NULL")]
		public decimal ethValue
		{
			get
			{
				return this._ethValue;
			}
			set
			{
				if ((this._ethValue != value))
				{
					this.OnethValueChanging(value);
					this.SendPropertyChanging();
					this._ethValue = value;
					this.SendPropertyChanged("ethValue");
					this.OnethValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dogeValue", DbType="Decimal(16,8) NOT NULL")]
		public decimal dogeValue
		{
			get
			{
				return this._dogeValue;
			}
			set
			{
				if ((this._dogeValue != value))
				{
					this.OndogeValueChanging(value);
					this.SendPropertyChanging();
					this._dogeValue = value;
					this.SendPropertyChanged("dogeValue");
					this.OndogeValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usdtValue", DbType="Decimal(16,8) NOT NULL")]
		public decimal usdtValue
		{
			get
			{
				return this._usdtValue;
			}
			set
			{
				if ((this._usdtValue != value))
				{
					this.OnusdtValueChanging(value);
					this.SendPropertyChanging();
					this._usdtValue = value;
					this.SendPropertyChanged("usdtValue");
					this.OnusdtValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_xrpValue", DbType="Decimal(16,8) NOT NULL")]
		public decimal xrpValue
		{
			get
			{
				return this._xrpValue;
			}
			set
			{
				if ((this._xrpValue != value))
				{
					this.OnxrpValueChanging(value);
					this.SendPropertyChanging();
					this._xrpValue = value;
					this.SendPropertyChanged("xrpValue");
					this.OnxrpValueChanged();
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
