namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfViewershipsTypeViewershipViewership
    {

        private ArrayOfViewershipsTypeViewershipViewershipViewershipCodes viewershipCodesField;

        private ArrayOfViewershipsTypeViewershipViewershipSystemCodes systemCodesField;

        private ArrayOfViewershipsTypeViewershipProfileTypeProfileType[] profileTypesField;

        private UniqueID_Type[] profileRefsField;

        private ProfileType[] profilesField;

        private ArrayOfViewershipsTypeViewershipViewershipLocationCodes locationCodesField;

        private ArrayOfViewershipsTypeViewershipViewershipBookingChannelCodes bookingChannelCodesField;

        private ArrayOfViewershipsTypeViewershipDistributorTypeDistributorType[] distributorTypesField;

        private sbyte viewershipRPHField;

        private bool viewershipRPHFieldSpecified;

        private bool viewOnlyField;

        private bool viewOnlyFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public ArrayOfViewershipsTypeViewershipViewershipViewershipCodes ViewershipCodes
        {
            get
            {
                return this.viewershipCodesField;
            }
            set
            {
                this.viewershipCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public ArrayOfViewershipsTypeViewershipViewershipSystemCodes SystemCodes
        {
            get
            {
                return this.systemCodesField;
            }
            set
            {
                this.systemCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileType", IsNullable = false)]
        public ArrayOfViewershipsTypeViewershipProfileTypeProfileType[] ProfileTypes
        {
            get
            {
                return this.profileTypesField;
            }
            set
            {
                this.profileTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ProfileRef", IsNullable = false)]
        public UniqueID_Type[] ProfileRefs
        {
            get
            {
                return this.profileRefsField;
            }
            set
            {
                this.profileRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Profile", IsNullable = false)]
        public ProfileType[] Profiles
        {
            get
            {
                return this.profilesField;
            }
            set
            {
                this.profilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 5)]
        public ArrayOfViewershipsTypeViewershipViewershipLocationCodes LocationCodes
        {
            get
            {
                return this.locationCodesField;
            }
            set
            {
                this.locationCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 6)]
        public ArrayOfViewershipsTypeViewershipViewershipBookingChannelCodes BookingChannelCodes
        {
            get
            {
                return this.bookingChannelCodesField;
            }
            set
            {
                this.bookingChannelCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("DistributorType", IsNullable = false)]
        public ArrayOfViewershipsTypeViewershipDistributorTypeDistributorType[] DistributorTypes
        {
            get
            {
                return this.distributorTypesField;
            }
            set
            {
                this.distributorTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte ViewershipRPH
        {
            get
            {
                return this.viewershipRPHField;
            }
            set
            {
                this.viewershipRPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ViewershipRPHSpecified
        {
            get
            {
                return this.viewershipRPHFieldSpecified;
            }
            set
            {
                this.viewershipRPHFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ViewOnly
        {
            get
            {
                return this.viewOnlyField;
            }
            set
            {
                this.viewOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ViewOnlySpecified
        {
            get
            {
                return this.viewOnlyFieldSpecified;
            }
            set
            {
                this.viewOnlyFieldSpecified = value;
            }
        }
    }
}