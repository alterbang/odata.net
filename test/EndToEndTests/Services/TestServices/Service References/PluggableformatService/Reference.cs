//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 3/20/2015 3:16:05 PM
namespace Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference
{
    /// <summary>
    /// There are no comments for PluggableFormatService in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PluggableFormatService")]
    public partial class PluggableFormatService : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new PluggableFormatService object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public PluggableFormatService(global::System.Uri serviceRoot) :
            base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "Microsoft.Test.OData.Services.PluggableFormat", "Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Microsoft.Test.OData.Services.PluggableFormat.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Microsoft.Test.OData.Services.PluggableFormat.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for People in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("People")]
        public global::Microsoft.OData.Client.DataServiceQuery<Person> People
        {
            get
            {
                if ((this._People == null))
                {
                    this._People = base.CreateQuery<Person>("People");
                }
                return this._People;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Person> _People;
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Products")]
        public global::Microsoft.OData.Client.DataServiceQuery<Product> Products
        {
            get
            {
                if ((this._Products == null))
                {
                    this._Products = base.CreateQuery<Product>("Products");
                }
                return this._Products;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private global::Microsoft.OData.Client.DataServiceQuery<Product> _Products;
        /// <summary>
        /// There are no comments for People in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public void AddToPeople(Person person)
        {
            base.AddObject("People", person);
        }
        /// <summary>
        /// There are no comments for Products in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public void AddToProducts(Product product)
        {
            base.AddObject("Products", product);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
            private const string Edmx = @"<edmx:Edmx Version=""4.0"" xmlns:edmx=""http://docs.oasis-open.org/odata/ns/edmx"">
  <edmx:DataServices>
    <Schema Namespace=""Microsoft.Test.OData.Services.PluggableFormat"" Alias=""Self"" xmlns=""http://docs.oasis-open.org/odata/ns/edm"">
      <EntityType Name=""Person"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Numbers"" Type=""Collection(Edm.Int32)"" />
        <Property Name=""Picture"" Type=""Edm.Binary"" />
        <Property Name=""BusinessCard"" Type=""Self.ContactInfo"" />
      </EntityType>
      <ComplexType Name=""ContactInfo"" OpenType=""true"">
        <Property Name=""N"" Type=""Edm.String"" />
      </ComplexType>
      <EntityType Name=""Product"">
        <Key>
          <PropertyRef Name=""Id"" />
        </Key>
        <Property Name=""Id"" Type=""Edm.Int32"" Nullable=""false"" />
        <Property Name=""Name"" Type=""Edm.String"" />
        <Property Name=""Info"" Type=""Self.ProductInfo"" />
      </EntityType>
      <ComplexType Name=""ProductInfo"">
        <Property Name=""Site"" Type=""Edm.String"" />
        <Property Name=""Serial"" Type=""Edm.Int64"" Nullable=""false"" />
      </ComplexType>
      <Action Name=""ResetDataSource"" />
      <Action Name=""AddProduct"" IsBound=""true"">
        <Parameter Name=""Set"" Type=""Collection(Self.Product)"" Nullable=""false"" />
        <Parameter Name=""Value"" Type=""Self.Product"" Nullable=""false"" />
        <Parameter Name=""Override"" Type=""Edm.Boolean"" Nullable=""false"" />
      </Action>
      <EntityContainer Name=""PluggableFormatService"">
        <EntitySet Name=""People"" EntityType=""Microsoft.Test.OData.Services.PluggableFormat.Person"" />
        <EntitySet Name=""Products"" EntityType=""Microsoft.Test.OData.Services.PluggableFormat.Product"" />
        <ActionImport Name=""ResetDataSource"" Action=""Microsoft.Test.OData.Services.PluggableFormat.ResetDataSource"" />
      </EntityContainer>
    </Schema>
  </edmx:DataServices>
</edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader(Edmx);
                try
                {
                    return global::Microsoft.OData.Edm.Csdl.CsdlReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
        /// <summary>
        /// There are no comments for ResetDataSource in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("ResetDataSource")]
        public global::Microsoft.OData.Client.DataServiceActionQuery ResetDataSource()
        {
            return new global::Microsoft.OData.Client.DataServiceActionQuery(this, this.BaseUri.OriginalString.Trim('/') + "/ResetDataSource");
        }
    }
    /// <summary>
    /// There are no comments for PersonSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PersonSingle")]
    public partial class PersonSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Person>
    {
        /// <summary>
        /// Initialize a new PersonSingle object.
        /// </summary>
        public PersonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new PersonSingle object.
        /// </summary>
        public PersonSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        /// <summary>
        /// Initialize a new PersonSingle object.
        /// </summary>
        public PersonSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Person> query)
            : base(query) { }

    }
    /// <summary>
    /// There are no comments for Person in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("People")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Person")]
    public partial class Person : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public static Person CreatePerson(int ID)
        {
            Person person = new Person();
            person.Id = ID;
            return person;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Numbers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Numbers")]
        public global::System.Collections.ObjectModel.ObservableCollection<int> Numbers
        {
            get
            {
                return this._Numbers;
            }
            set
            {
                this.OnNumbersChanging(value);
                this._Numbers = value;
                this.OnNumbersChanged();
                this.OnPropertyChanged("Numbers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private global::System.Collections.ObjectModel.ObservableCollection<int> _Numbers = new global::System.Collections.ObjectModel.ObservableCollection<int>();
        partial void OnNumbersChanging(global::System.Collections.ObjectModel.ObservableCollection<int> value);
        partial void OnNumbersChanged();
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Picture")]
        public byte[] Picture
        {
            get
            {
                return this._Picture;
            }
            set
            {
                this.OnPictureChanging(value);
                this._Picture = value;
                this.OnPictureChanged();
                this.OnPropertyChanged("Picture");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private byte[] _Picture;
        partial void OnPictureChanging(byte[] value);
        partial void OnPictureChanged();
        /// <summary>
        /// There are no comments for Property BusinessCard in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessCard")]
        public global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ContactInfo BusinessCard
        {
            get
            {
                return this._BusinessCard;
            }
            set
            {
                this.OnBusinessCardChanging(value);
                this._BusinessCard = value;
                this.OnBusinessCardChanged();
                this.OnPropertyChanged("BusinessCard");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ContactInfo _BusinessCard;
        partial void OnBusinessCardChanging(global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ContactInfo value);
        partial void OnBusinessCardChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ContactInfo in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ContactInfo")]
    public partial class ContactInfo : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property N in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("N")]
        public string N
        {
            get
            {
                return this._N;
            }
            set
            {
                this.OnNChanging(value);
                this._N = value;
                this.OnNChanged();
                this.OnPropertyChanged("N");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private string _N;
        partial void OnNChanging(string value);
        partial void OnNChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ProductSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductSingle")]
    public partial class ProductSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Product>
    {
        /// <summary>
        /// Initialize a new ProductSingle object.
        /// </summary>
        public ProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) { }

        /// <summary>
        /// Initialize a new ProductSingle object.
        /// </summary>
        public ProductSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) { }

        /// <summary>
        /// Initialize a new ProductSingle object.
        /// </summary>
        public ProductSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Product> query)
            : base(query) { }

    }
    /// <summary>
    /// There are no comments for Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("Products")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Product")]
    public partial class Product : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public static Product CreateProduct(int ID)
        {
            Product product = new Product();
            product.Id = ID;
            return product;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Info in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Info")]
        public global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductInfo Info
        {
            get
            {
                return this._Info;
            }
            set
            {
                this.OnInfoChanging(value);
                this._Info = value;
                this.OnInfoChanged();
                this.OnPropertyChanged("Info");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductInfo _Info;
        partial void OnInfoChanging(global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductInfo value);
        partial void OnInfoChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ProductInfo in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductInfo")]
    public partial class ProductInfo : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ProductInfo object.
        /// </summary>
        /// <param name="serial">Initial value of Serial.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public static ProductInfo CreateProductInfo(long serial)
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.Serial = serial;
            return productInfo;
        }
        /// <summary>
        /// There are no comments for Property Site in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Site")]
        public string Site
        {
            get
            {
                return this._Site;
            }
            set
            {
                this.OnSiteChanging(value);
                this._Site = value;
                this.OnSiteChanged();
                this.OnPropertyChanged("Site");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private string _Site;
        partial void OnSiteChanging(string value);
        partial void OnSiteChanged();
        /// <summary>
        /// There are no comments for Property Serial in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Serial")]
        public long Serial
        {
            get
            {
                return this._Serial;
            }
            set
            {
                this.OnSerialChanging(value);
                this._Serial = value;
                this.OnSerialChanged();
                this.OnPropertyChanged("Serial");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        private long _Serial;
        partial void OnSerialChanging(long value);
        partial void OnSerialChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.3.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Person as global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Person> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Person as global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.PersonSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.PersonSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Person> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.PersonSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Product as global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Product> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Product as global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Product> source,
            int id)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.ProductSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// There are no comments for AddProduct in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("AddProduct")]
        public static global::Microsoft.OData.Client.DataServiceActionQuery AddProduct(this global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Product> source, global::Microsoft.Test.OData.Services.TestServices.PluggableFormatServiceReference.Product Value, bool Override)
        {
            if (!source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(source.Context, source.AppendRequestUri("Microsoft.Test.OData.Services.PluggableFormat.AddProduct"), new global::Microsoft.OData.Client.BodyOperationParameter("Value", Value),
                    new global::Microsoft.OData.Client.BodyOperationParameter("Override", Override));
        }
    }
}
