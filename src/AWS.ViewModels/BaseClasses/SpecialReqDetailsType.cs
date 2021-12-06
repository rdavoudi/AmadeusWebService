namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class SpecialReqDetailsType
    {

        private ArrayOfSpecialReqDetailsTypeSeatRequestSeatRequest[] seatRequestsField;

        private ArrayOfSpecialReqDetailsTypeSpecialServiceRequestSpecialServiceRequest[] specialServiceRequestsField;

        private ArrayOfSpecialReqDetailsTypeOtherServiceInformationOtherServiceInformation[] otherServiceInformationsField;

        private ArrayOfSpecialReqDetailsTypeRemarkRemark[] remarksField;

        private ArrayOfSpecialReqDetailsTypeSpecialRemarkSpecialRemark[] specialRemarksField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SeatRequest", IsNullable = false)]
        public ArrayOfSpecialReqDetailsTypeSeatRequestSeatRequest[] SeatRequests
        {
            get
            {
                return this.seatRequestsField;
            }
            set
            {
                this.seatRequestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialServiceRequest", IsNullable = false)]
        public ArrayOfSpecialReqDetailsTypeSpecialServiceRequestSpecialServiceRequest[] SpecialServiceRequests
        {
            get
            {
                return this.specialServiceRequestsField;
            }
            set
            {
                this.specialServiceRequestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherServiceInformation", IsNullable = false)]
        public ArrayOfSpecialReqDetailsTypeOtherServiceInformationOtherServiceInformation[] OtherServiceInformations
        {
            get
            {
                return this.otherServiceInformationsField;
            }
            set
            {
                this.otherServiceInformationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Remark", IsNullable = false)]
        public ArrayOfSpecialReqDetailsTypeRemarkRemark[] Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialRemark", IsNullable = false)]
        public ArrayOfSpecialReqDetailsTypeSpecialRemarkSpecialRemark[] SpecialRemarks
        {
            get
            {
                return this.specialRemarksField;
            }
            set
            {
                this.specialRemarksField = value;
            }
        }
    }
}