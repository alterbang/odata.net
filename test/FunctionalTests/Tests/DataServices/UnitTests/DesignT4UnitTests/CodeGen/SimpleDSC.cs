//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/10/2015 2:53:42 PM
namespace Simple.DSC
{
    /// <summary>
    /// There are no comments for TestTypeSingle in the schema.
    /// </summary>
    public partial class TestTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TestType>
    {
        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TestType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TestType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// KeyProp
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("KeyProp")]
    public partial class TestType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TestType object.
        /// </summary>
        /// <param name="keyProp">Initial value of KeyProp.</param>
        /// <param name="valueProp">Initial value of ValueProp.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public static TestType CreateTestType(int keyProp, string valueProp)
        {
            TestType testType = new TestType();
            testType.KeyProp = keyProp;
            testType.ValueProp = valueProp;
            return testType;
        }
        /// <summary>
        /// There are no comments for Property KeyProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public int KeyProp
        {
            get
            {
                return this._KeyProp;
            }
            set
            {
                this.OnKeyPropChanging(value);
                this._KeyProp = value;
                this.OnKeyPropChanged();
                this.OnPropertyChanged("KeyProp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private int _KeyProp;
        partial void OnKeyPropChanging(int value);
        partial void OnKeyPropChanged();
        /// <summary>
        /// There are no comments for Property ValueProp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public string ValueProp
        {
            get
            {
                return this._ValueProp;
            }
            set
            {
                this.OnValuePropChanging(value);
                this._ValueProp = value;
                this.OnValuePropChanged();
                this.OnPropertyChanged("ValueProp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        private string _ValueProp;
        partial void OnValuePropChanging(string value);
        partial void OnValuePropChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "2.2.0")]
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
        /// Get an entity of type global::Simple.DSC.TestType as global::Simple.DSC.TestTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::Simple.DSC.TestTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Simple.DSC.TestType> source, global::System.Collections.Generic.Dictionary<string, object> keys)
        {
            return new global::Simple.DSC.TestTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::Simple.DSC.TestType as global::Simple.DSC.TestTypeSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keyProp">The value of keyProp</param>
        public static global::Simple.DSC.TestTypeSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Simple.DSC.TestType> source,
            int keyProp)
        {
            global::System.Collections.Generic.Dictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "KeyProp", keyProp }
            };
            return new global::Simple.DSC.TestTypeSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}