﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace Atmosphere
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace Atmosphere.Atmosphere_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[15];
            _typeNameTable[0] = "Atmosphere.WeatherConverter";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "Atmosphere.MainPage";
            _typeNameTable[3] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[4] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[5] = "System.Collections.ObjectModel.ObservableCollection`1<Atmosphere.WeekDay>";
            _typeNameTable[6] = "System.Collections.ObjectModel.Collection`1<Atmosphere.WeekDay>";
            _typeNameTable[7] = "Atmosphere.WeekDay";
            _typeNameTable[8] = "String";
            _typeNameTable[9] = "Int32";
            _typeNameTable[10] = "System.DateTime";
            _typeNameTable[11] = "System.ValueType";
            _typeNameTable[12] = "System.Collections.ObjectModel.ObservableCollection`1<Atmosphere.Today>";
            _typeNameTable[13] = "System.Collections.ObjectModel.Collection`1<Atmosphere.Today>";
            _typeNameTable[14] = "Atmosphere.Today";

            _typeTable = new global::System.Type[15];
            _typeTable[0] = typeof(global::Atmosphere.WeatherConverter);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::Atmosphere.MainPage);
            _typeTable[3] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[4] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[5] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Atmosphere.WeekDay>);
            _typeTable[6] = typeof(global::System.Collections.ObjectModel.Collection<global::Atmosphere.WeekDay>);
            _typeTable[7] = typeof(global::Atmosphere.WeekDay);
            _typeTable[8] = typeof(global::System.String);
            _typeTable[9] = typeof(global::System.Int32);
            _typeTable[10] = typeof(global::System.DateTime);
            _typeTable[11] = typeof(global::System.ValueType);
            _typeTable[12] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Atmosphere.Today>);
            _typeTable[13] = typeof(global::System.Collections.ObjectModel.Collection<global::Atmosphere.Today>);
            _typeTable[14] = typeof(global::Atmosphere.Today);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_WeatherConverter() { return new global::Atmosphere.WeatherConverter(); }
        private object Activate_2_MainPage() { return new global::Atmosphere.MainPage(); }
        private object Activate_5_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::Atmosphere.WeekDay>(); }
        private object Activate_6_Collection() { return new global::System.Collections.ObjectModel.Collection<global::Atmosphere.WeekDay>(); }
        private object Activate_7_WeekDay() { return new global::Atmosphere.WeekDay(); }
        private object Activate_12_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::Atmosphere.Today>(); }
        private object Activate_13_Collection() { return new global::System.Collections.ObjectModel.Collection<global::Atmosphere.Today>(); }
        private object Activate_14_Today() { return new global::Atmosphere.Today(); }
        private void VectorAdd_5_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Atmosphere.WeekDay>)instance;
            var newItem = (global::Atmosphere.WeekDay)item;
            collection.Add(newItem);
        }
        private void VectorAdd_6_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Atmosphere.WeekDay>)instance;
            var newItem = (global::Atmosphere.WeekDay)item;
            collection.Add(newItem);
        }
        private void VectorAdd_12_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Atmosphere.Today>)instance;
            var newItem = (global::Atmosphere.Today)item;
            collection.Add(newItem);
        }
        private void VectorAdd_13_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::Atmosphere.Today>)instance;
            var newItem = (global::Atmosphere.Today)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  Atmosphere.WeatherConverter
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_WeatherConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Atmosphere.MainPage
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_2_MainPage;
                userType.AddMemberName("WeekDays");
                userType.AddMemberName("Now");
                userType.AddMemberName("TodaysWeather");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  System.Collections.ObjectModel.ObservableCollection`1<Atmosphere.WeekDay>
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Atmosphere.WeekDay>"));
                userType.CollectionAdd = VectorAdd_5_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 6:   //  System.Collections.ObjectModel.Collection`1<Atmosphere.WeekDay>
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_6_Collection;
                userType.CollectionAdd = VectorAdd_6_Collection;
                xamlType = userType;
                break;

            case 7:   //  Atmosphere.WeekDay
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_7_WeekDay;
                userType.AddMemberName("Day");
                userType.AddMemberName("Temperature");
                userType.AddMemberName("Weather");
                userType.AddMemberName("Low");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  String
                xamlType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  Int32
                xamlType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  System.DateTime
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 11:   //  System.ValueType
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 12:   //  System.Collections.ObjectModel.ObservableCollection`1<Atmosphere.Today>
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<Atmosphere.Today>"));
                userType.CollectionAdd = VectorAdd_12_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 13:   //  System.Collections.ObjectModel.Collection`1<Atmosphere.Today>
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_13_Collection;
                userType.CollectionAdd = VectorAdd_13_Collection;
                xamlType = userType;
                break;

            case 14:   //  Atmosphere.Today
                userType = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_14_Today;
                userType.AddMemberName("TimeOfDay");
                userType.AddMemberName("Temperature");
                userType.AddMemberName("Weather");
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage_WeekDays(object instance)
        {
            var that = (global::Atmosphere.MainPage)instance;
            return that.WeekDays;
        }
        private void set_0_MainPage_WeekDays(object instance, object Value)
        {
            var that = (global::Atmosphere.MainPage)instance;
            that.WeekDays = (global::System.Collections.ObjectModel.ObservableCollection<global::Atmosphere.WeekDay>)Value;
        }
        private object get_1_WeekDay_Day(object instance)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            return that.Day;
        }
        private void set_1_WeekDay_Day(object instance, object Value)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            that.Day = (global::System.String)Value;
        }
        private object get_2_WeekDay_Temperature(object instance)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            return that.Temperature;
        }
        private void set_2_WeekDay_Temperature(object instance, object Value)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            that.Temperature = (global::System.Int32)Value;
        }
        private object get_3_WeekDay_Weather(object instance)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            return that.Weather;
        }
        private void set_3_WeekDay_Weather(object instance, object Value)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            that.Weather = (global::System.String)Value;
        }
        private object get_4_WeekDay_Low(object instance)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            return that.Low;
        }
        private void set_4_WeekDay_Low(object instance, object Value)
        {
            var that = (global::Atmosphere.WeekDay)instance;
            that.Low = (global::System.Int32)Value;
        }
        private object get_5_MainPage_Now(object instance)
        {
            var that = (global::Atmosphere.MainPage)instance;
            return that.Now;
        }
        private void set_5_MainPage_Now(object instance, object Value)
        {
            var that = (global::Atmosphere.MainPage)instance;
            that.Now = (global::System.DateTime)Value;
        }
        private object get_6_MainPage_TodaysWeather(object instance)
        {
            var that = (global::Atmosphere.MainPage)instance;
            return that.TodaysWeather;
        }
        private void set_6_MainPage_TodaysWeather(object instance, object Value)
        {
            var that = (global::Atmosphere.MainPage)instance;
            that.TodaysWeather = (global::System.Collections.ObjectModel.ObservableCollection<global::Atmosphere.Today>)Value;
        }
        private object get_7_Today_TimeOfDay(object instance)
        {
            var that = (global::Atmosphere.Today)instance;
            return that.TimeOfDay;
        }
        private void set_7_Today_TimeOfDay(object instance, object Value)
        {
            var that = (global::Atmosphere.Today)instance;
            that.TimeOfDay = (global::System.String)Value;
        }
        private object get_8_Today_Temperature(object instance)
        {
            var that = (global::Atmosphere.Today)instance;
            return that.Temperature;
        }
        private void set_8_Today_Temperature(object instance, object Value)
        {
            var that = (global::Atmosphere.Today)instance;
            that.Temperature = (global::System.Int32)Value;
        }
        private object get_9_Today_Weather(object instance)
        {
            var that = (global::Atmosphere.Today)instance;
            return that.Weather;
        }
        private void set_9_Today_Weather(object instance, object Value)
        {
            var that = (global::Atmosphere.Today)instance;
            that.Weather = (global::System.String)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember xamlMember = null;
            global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Atmosphere.MainPage.WeekDays":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.MainPage");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "WeekDays", "System.Collections.ObjectModel.ObservableCollection`1<Atmosphere.WeekDay>");
                xamlMember.Getter = get_0_MainPage_WeekDays;
                xamlMember.Setter = set_0_MainPage_WeekDays;
                break;
            case "Atmosphere.WeekDay.Day":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.WeekDay");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Day", "String");
                xamlMember.Getter = get_1_WeekDay_Day;
                xamlMember.Setter = set_1_WeekDay_Day;
                break;
            case "Atmosphere.WeekDay.Temperature":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.WeekDay");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Temperature", "Int32");
                xamlMember.Getter = get_2_WeekDay_Temperature;
                xamlMember.Setter = set_2_WeekDay_Temperature;
                break;
            case "Atmosphere.WeekDay.Weather":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.WeekDay");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Weather", "String");
                xamlMember.Getter = get_3_WeekDay_Weather;
                xamlMember.Setter = set_3_WeekDay_Weather;
                break;
            case "Atmosphere.WeekDay.Low":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.WeekDay");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Low", "Int32");
                xamlMember.Getter = get_4_WeekDay_Low;
                xamlMember.Setter = set_4_WeekDay_Low;
                break;
            case "Atmosphere.MainPage.Now":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.MainPage");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Now", "System.DateTime");
                xamlMember.Getter = get_5_MainPage_Now;
                xamlMember.Setter = set_5_MainPage_Now;
                break;
            case "Atmosphere.MainPage.TodaysWeather":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.MainPage");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "TodaysWeather", "System.Collections.ObjectModel.ObservableCollection`1<Atmosphere.Today>");
                xamlMember.Getter = get_6_MainPage_TodaysWeather;
                xamlMember.Setter = set_6_MainPage_TodaysWeather;
                break;
            case "Atmosphere.Today.TimeOfDay":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.Today");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "TimeOfDay", "String");
                xamlMember.Getter = get_7_Today_TimeOfDay;
                xamlMember.Setter = set_7_Today_TimeOfDay;
                break;
            case "Atmosphere.Today.Temperature":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.Today");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Temperature", "Int32");
                xamlMember.Getter = get_8_Today_Temperature;
                xamlMember.Setter = set_8_Today_Temperature;
                break;
            case "Atmosphere.Today.Weather":
                userType = (global::Atmosphere.Atmosphere_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Atmosphere.Today");
                xamlMember = new global::Atmosphere.Atmosphere_XamlTypeInfo.XamlMember(this, "Weather", "String");
                xamlMember.Getter = get_9_Today_Weather;
                xamlMember.Setter = set_9_Today_Weather;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::Atmosphere.Atmosphere_XamlTypeInfo.XamlSystemBaseType
    {
        global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::Atmosphere.Atmosphere_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

