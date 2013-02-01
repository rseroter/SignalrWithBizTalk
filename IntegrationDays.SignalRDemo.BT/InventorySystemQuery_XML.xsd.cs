namespace IntegrationDays.SignalRDemo.BT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://IntegrationDays.SignalRDemo.BT.InventorySystemQuery_XML",@"InventorySystemQuery")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InventorySystemQuery"})]
    public sealed class InventorySystemQuery_XML : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://IntegrationDays.SignalRDemo.BT.InventorySystemQuery_XML"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://IntegrationDays.SignalRDemo.BT.InventorySystemQuery_XML"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""InventorySystemQuery"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ClientId"" type=""xs:string"" />
        <xs:element name=""ItemId"" type=""xs:string"" />
        <xs:element name=""ProviderName"" type=""xs:string"" />
        <xs:element name=""StockAmount"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InventorySystemQuery_XML() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InventorySystemQuery";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
