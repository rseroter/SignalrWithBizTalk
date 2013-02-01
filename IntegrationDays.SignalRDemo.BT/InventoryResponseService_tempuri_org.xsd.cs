namespace IntegrationDays.SignalRDemo.BT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "providerId", XPath = @"/*[local-name()='PublishResults' and namespace-uri()='http://tempuri.org/']/*[local-name()='providerId' and namespace-uri()='http://tempuri.org/']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "stockAmount", XPath = @"/*[local-name()='PublishResults' and namespace-uri()='http://tempuri.org/']/*[local-name()='stockAmount' and namespace-uri()='http://tempuri.org/']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PublishResults", @"PublishResultsResponse"})]
    public sealed class InventoryResponseService_tempuri_org : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PublishResults"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PublishResults' and namespace-uri()='http://tempuri.org/']/*[local-name()='providerId' and namespace-uri()='http://tempuri.org/']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='PublishResults' and namespace-uri()='http://tempuri.org/']/*[local-name()='stockAmount' and namespace-uri()='http://tempuri.org/']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""clientId"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""providerId"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""itemId"" nillable=""true"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""stockAmount"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PublishResultsResponse"">
    <xs:complexType>
      <xs:sequence />
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InventoryResponseService_tempuri_org() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "PublishResults";
                _RootElements[1] = "PublishResultsResponse";
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
        
        [Schema(@"http://tempuri.org/",@"PublishResults")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "providerId", XPath = @"/*[local-name()='PublishResults' and namespace-uri()='http://tempuri.org/']/*[local-name()='providerId' and namespace-uri()='http://tempuri.org/']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.Int32), "stockAmount", XPath = @"/*[local-name()='PublishResults' and namespace-uri()='http://tempuri.org/']/*[local-name()='stockAmount' and namespace-uri()='http://tempuri.org/']", XsdType = @"int")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PublishResults"})]
        public sealed class PublishResults : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PublishResults() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PublishResults";
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
        
        [Schema(@"http://tempuri.org/",@"PublishResultsResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PublishResultsResponse"})]
        public sealed class PublishResultsResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PublishResultsResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PublishResultsResponse";
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
}
