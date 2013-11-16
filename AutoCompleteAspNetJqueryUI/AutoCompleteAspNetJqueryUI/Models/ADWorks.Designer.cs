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
namespace AutoCompleteAspNetJqueryUI.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AdventureWorks2012Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AdventureWorks2012Entities object using the connection string found in the 'AdventureWorks2012Entities' section of the application configuration file.
        /// </summary>
        public AdventureWorks2012Entities() : base("name=AdventureWorks2012Entities", "AdventureWorks2012Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorks2012Entities object.
        /// </summary>
        public AdventureWorks2012Entities(string connectionString) : base(connectionString, "AdventureWorks2012Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AdventureWorks2012Entities object.
        /// </summary>
        public AdventureWorks2012Entities(EntityConnection connection) : base(connection, "AdventureWorks2012Entities")
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
        public ObjectSet<Person> People
        {
            get
            {
                if ((_People == null))
                {
                    _People = base.CreateObjectSet<Person>("People");
                }
                return _People;
            }
        }
        private ObjectSet<Person> _People;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the People EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorks2012Model", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="businessEntityID">Initial value of the BusinessEntityID property.</param>
        /// <param name="personType">Initial value of the PersonType property.</param>
        /// <param name="nameStyle">Initial value of the NameStyle property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="lastName">Initial value of the LastName property.</param>
        /// <param name="emailPromotion">Initial value of the EmailPromotion property.</param>
        /// <param name="rowguid">Initial value of the rowguid property.</param>
        /// <param name="modifiedDate">Initial value of the ModifiedDate property.</param>
        public static Person CreatePerson(global::System.Int32 businessEntityID, global::System.String personType, global::System.Boolean nameStyle, global::System.String firstName, global::System.String lastName, global::System.Int32 emailPromotion, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Person person = new Person();
            person.BusinessEntityID = businessEntityID;
            person.PersonType = personType;
            person.NameStyle = nameStyle;
            person.FirstName = firstName;
            person.LastName = lastName;
            person.EmailPromotion = emailPromotion;
            person.rowguid = rowguid;
            person.ModifiedDate = modifiedDate;
            return person;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BusinessEntityID
        {
            get
            {
                return _BusinessEntityID;
            }
            set
            {
                if (_BusinessEntityID != value)
                {
                    OnBusinessEntityIDChanging(value);
                    ReportPropertyChanging("BusinessEntityID");
                    _BusinessEntityID = StructuralObject.SetValidValue(value, "BusinessEntityID");
                    ReportPropertyChanged("BusinessEntityID");
                    OnBusinessEntityIDChanged();
                }
            }
        }
        private global::System.Int32 _BusinessEntityID;
        partial void OnBusinessEntityIDChanging(global::System.Int32 value);
        partial void OnBusinessEntityIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PersonType
        {
            get
            {
                return _PersonType;
            }
            set
            {
                OnPersonTypeChanging(value);
                ReportPropertyChanging("PersonType");
                _PersonType = StructuralObject.SetValidValue(value, false, "PersonType");
                ReportPropertyChanged("PersonType");
                OnPersonTypeChanged();
            }
        }
        private global::System.String _PersonType;
        partial void OnPersonTypeChanging(global::System.String value);
        partial void OnPersonTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean NameStyle
        {
            get
            {
                return _NameStyle;
            }
            set
            {
                OnNameStyleChanging(value);
                ReportPropertyChanging("NameStyle");
                _NameStyle = StructuralObject.SetValidValue(value, "NameStyle");
                ReportPropertyChanged("NameStyle");
                OnNameStyleChanged();
            }
        }
        private global::System.Boolean _NameStyle;
        partial void OnNameStyleChanging(global::System.Boolean value);
        partial void OnNameStyleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true, "MiddleName");
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Suffix
        {
            get
            {
                return _Suffix;
            }
            set
            {
                OnSuffixChanging(value);
                ReportPropertyChanging("Suffix");
                _Suffix = StructuralObject.SetValidValue(value, true, "Suffix");
                ReportPropertyChanged("Suffix");
                OnSuffixChanged();
            }
        }
        private global::System.String _Suffix;
        partial void OnSuffixChanging(global::System.String value);
        partial void OnSuffixChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmailPromotion
        {
            get
            {
                return _EmailPromotion;
            }
            set
            {
                OnEmailPromotionChanging(value);
                ReportPropertyChanging("EmailPromotion");
                _EmailPromotion = StructuralObject.SetValidValue(value, "EmailPromotion");
                ReportPropertyChanged("EmailPromotion");
                OnEmailPromotionChanged();
            }
        }
        private global::System.Int32 _EmailPromotion;
        partial void OnEmailPromotionChanging(global::System.Int32 value);
        partial void OnEmailPromotionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AdditionalContactInfo
        {
            get
            {
                return _AdditionalContactInfo;
            }
            set
            {
                OnAdditionalContactInfoChanging(value);
                ReportPropertyChanging("AdditionalContactInfo");
                _AdditionalContactInfo = StructuralObject.SetValidValue(value, true, "AdditionalContactInfo");
                ReportPropertyChanged("AdditionalContactInfo");
                OnAdditionalContactInfoChanged();
            }
        }
        private global::System.String _AdditionalContactInfo;
        partial void OnAdditionalContactInfoChanging(global::System.String value);
        partial void OnAdditionalContactInfoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Demographics
        {
            get
            {
                return _Demographics;
            }
            set
            {
                OnDemographicsChanging(value);
                ReportPropertyChanging("Demographics");
                _Demographics = StructuralObject.SetValidValue(value, true, "Demographics");
                ReportPropertyChanged("Demographics");
                OnDemographicsChanged();
            }
        }
        private global::System.String _Demographics;
        partial void OnDemographicsChanging(global::System.String value);
        partial void OnDemographicsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value, "rowguid");
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value, "ModifiedDate");
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();

        #endregion

    }

    #endregion

}