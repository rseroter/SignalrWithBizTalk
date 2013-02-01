namespace IntegrationDays.SignalRDemo.BT {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"IntegrationDays.SignalRDemo.BT.InventoryLookupRequest_XML", typeof(global::IntegrationDays.SignalRDemo.BT.InventoryLookupRequest_XML))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"IntegrationDays.SignalRDemo.BT.InventoryResponseService_tempuri_org+PublishResults", typeof(global::IntegrationDays.SignalRDemo.BT.InventoryResponseService_tempuri_org.PublishResults))]
    public sealed class InventoryLookupRequest_To_InventoryResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://IntegrationDays.SignalRDemo.BT.InventoryLookupRequest_XML"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:InventoryLookupRequest"" />
  </xsl:template>
  <xsl:template match=""/s0:InventoryLookupRequest"">
    <ns0:PublishResults>
      <ns0:clientId>
        <xsl:value-of select=""ClientId/text()"" />
      </ns0:clientId>
      <ns0:providerId>
        <xsl:text />
      </ns0:providerId>
      <ns0:itemId>
        <xsl:value-of select=""ItemId/text()"" />
      </ns0:itemId>
      <ns0:stockAmount>
        <xsl:text>0</xsl:text>
      </ns0:stockAmount>
    </ns0:PublishResults>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"IntegrationDays.SignalRDemo.BT.InventoryLookupRequest_XML";
        
        private const global::IntegrationDays.SignalRDemo.BT.InventoryLookupRequest_XML _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"IntegrationDays.SignalRDemo.BT.InventoryResponseService_tempuri_org+PublishResults";
        
        private const global::IntegrationDays.SignalRDemo.BT.InventoryResponseService_tempuri_org.PublishResults _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"IntegrationDays.SignalRDemo.BT.InventoryLookupRequest_XML";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"IntegrationDays.SignalRDemo.BT.InventoryResponseService_tempuri_org+PublishResults";
                return _TrgSchemas;
            }
        }
    }
}
