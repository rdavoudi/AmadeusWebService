namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "GetCompatibleLowestFaresForSunExpress", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class GetCompatibleLowestFaresForSunExpressRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
        public AuthenticationSoapHeader AuthenticationSoapHeader;

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
        public GenericSoapHeader GenericSoapHeader;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public FlightOptionRQ FlightOptionRQ;

        public GetCompatibleLowestFaresForSunExpressRequest()
        {
        }

        public GetCompatibleLowestFaresForSunExpressRequest(AuthenticationSoapHeader AuthenticationSoapHeader, GenericSoapHeader GenericSoapHeader, FlightOptionRQ FlightOptionRQ)
        {
            this.AuthenticationSoapHeader = AuthenticationSoapHeader;
            this.GenericSoapHeader = GenericSoapHeader;
            this.FlightOptionRQ = FlightOptionRQ;
        }
    }
}