namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfPTCFareBreakdownTypeTicketDesignatorTicketDesignator
    {

        private string flightRefRPHField;

        private string ticketDesignatorCodeField;

        private string ticketDesignatorExtensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FlightRefRPH
        {
            get
            {
                return this.flightRefRPHField;
            }
            set
            {
                this.flightRefRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorCode
        {
            get
            {
                return this.ticketDesignatorCodeField;
            }
            set
            {
                this.ticketDesignatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TicketDesignatorExtension
        {
            get
            {
                return this.ticketDesignatorExtensionField;
            }
            set
            {
                this.ticketDesignatorExtensionField = value;
            }
        }
    }
}