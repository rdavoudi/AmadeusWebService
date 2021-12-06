namespace AWS.ViewModels.BaseClasses
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "SearchHotelRoomsResponse", WrapperNamespace = "http://epowerv5.amadeus.com.tr/WS", IsWrapped = true)]
    public partial class SearchHotelRoomsResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS", Order = 0)]
        public SearchHotelRoomsResponseOTA_HotelAvailRS OTA_HotelAvailRS;

        public SearchHotelRoomsResponse()
        {
        }

        public SearchHotelRoomsResponse(SearchHotelRoomsResponseOTA_HotelAvailRS OTA_HotelAvailRS)
        {
            this.OTA_HotelAvailRS = OTA_HotelAvailRS;
        }
    }
}