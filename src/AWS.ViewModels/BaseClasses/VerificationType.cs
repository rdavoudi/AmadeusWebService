namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class VerificationType
    {

        private VerificationTypePersonName personNameField;

        private EmailType emailField;

        private VerificationTypeTelephoneInfo telephoneInfoField;

        private PaymentCardType paymentCardField;

        private AddressInfoType addressInfoField;

        private VerificationTypeCustLoyalty[] custLoyaltyField;

        private CompanyNameType[] vendorField;

        private VerificationTypeReservationTimeSpan reservationTimeSpanField;

        private VerificationTypeAssociatedQuantity[] associatedQuantityField;

        private VerificationTypeStartLocation startLocationField;

        private VerificationTypeEndLocation endLocationField;

        private TPA_ExtensionsType tPA_ExtensionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public VerificationTypePersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public EmailType Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 2)]
        public VerificationTypeTelephoneInfo TelephoneInfo
        {
            get
            {
                return this.telephoneInfoField;
            }
            set
            {
                this.telephoneInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 3)]
        public PaymentCardType PaymentCard
        {
            get
            {
                return this.paymentCardField;
            }
            set
            {
                this.paymentCardField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public AddressInfoType AddressInfo
        {
            get
            {
                return this.addressInfoField;
            }
            set
            {
                this.addressInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CustLoyalty", Order = 5)]
        public VerificationTypeCustLoyalty[] CustLoyalty
        {
            get
            {
                return this.custLoyaltyField;
            }
            set
            {
                this.custLoyaltyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Vendor", Order = 6)]
        public CompanyNameType[] Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 7)]
        public VerificationTypeReservationTimeSpan ReservationTimeSpan
        {
            get
            {
                return this.reservationTimeSpanField;
            }
            set
            {
                this.reservationTimeSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedQuantity", Order = 8)]
        public VerificationTypeAssociatedQuantity[] AssociatedQuantity
        {
            get
            {
                return this.associatedQuantityField;
            }
            set
            {
                this.associatedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 9)]
        public VerificationTypeStartLocation StartLocation
        {
            get
            {
                return this.startLocationField;
            }
            set
            {
                this.startLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 10)]
        public VerificationTypeEndLocation EndLocation
        {
            get
            {
                return this.endLocationField;
            }
            set
            {
                this.endLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 11)]
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }
}