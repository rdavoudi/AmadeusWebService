namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "CurrencyConversionResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class CurrencyConversionResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public OTA_CurrencyConversionRS OTA_CurrencyConversionRS;

        public CurrencyConversionResponse()
        {
        }

        public CurrencyConversionResponse(OTA_CurrencyConversionRS OTA_CurrencyConversionRS)
        {
            this.OTA_CurrencyConversionRS = OTA_CurrencyConversionRS;
        }
    }
}