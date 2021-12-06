namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class AirTravelerTypeLCCParameters
    {

        private bool isSpeedyBoardingField;

        private bool isSpeedyBoardingFieldSpecified;

        private bool isOnlineCheckInField;

        private bool isOnlineCheckInFieldSpecified;

        private string checkInOptionField;

        private string checkInOption1Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsSpeedyBoarding
        {
            get
            {
                return this.isSpeedyBoardingField;
            }
            set
            {
                this.isSpeedyBoardingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSpeedyBoardingSpecified
        {
            get
            {
                return this.isSpeedyBoardingFieldSpecified;
            }
            set
            {
                this.isSpeedyBoardingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsOnlineCheckIn
        {
            get
            {
                return this.isOnlineCheckInField;
            }
            set
            {
                this.isOnlineCheckInField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsOnlineCheckInSpecified
        {
            get
            {
                return this.isOnlineCheckInFieldSpecified;
            }
            set
            {
                this.isOnlineCheckInFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckInOption
        {
            get
            {
                return this.checkInOptionField;
            }
            set
            {
                this.checkInOptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CheckInOption1
        {
            get
            {
                return this.checkInOption1Field;
            }
            set
            {
                this.checkInOption1Field = value;
            }
        }
    }
}