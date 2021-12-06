namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfSpecialReqDetailsTypeSpecialServiceRequestSpecialServiceRequest : SpecialServiceRequestType
    {

        private string animalBoxTypeField;

        private FlightLegType flightLegField;

        private SSRRequiredParameterRQ[] requiredParametersField;

        private int heightField;

        private bool heightFieldSpecified;

        private int widthField;

        private bool widthFieldSpecified;

        private int lengthField;

        private bool lengthFieldSpecified;

        private int weightField;

        private bool weightFieldSpecified;

        private string otherEquipmentField;

        private string baggageNameField;

        private string disabledPassengerField;

        private string otherAnimalTypeField;

        private ArrayOfSpecialReqDetailsTypeSpecialServiceRequestSpecialServiceRequestSSRType sSRTypeField;

        private string[] travelerRefNumberRPHListField;

        private string[] flightRefNumberRPHListField;

        private string notesField;

        private bool withDogField;

        private bool withDogFieldSpecified;

        private bool withDogSpecified1Field;

        private string airlineCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public string AnimalBoxType
        {
            get
            {
                return this.animalBoxTypeField;
            }
            set
            {
                this.animalBoxTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public FlightLegType FlightLeg
        {
            get
            {
                return this.flightLegField;
            }
            set
            {
                this.flightLegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order = 2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("RequiredParameter")]
        public SSRRequiredParameterRQ[] RequiredParameters
        {
            get
            {
                return this.requiredParametersField;
            }
            set
            {
                this.requiredParametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeightSpecified
        {
            get
            {
                return this.heightFieldSpecified;
            }
            set
            {
                this.heightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WidthSpecified
        {
            get
            {
                return this.widthFieldSpecified;
            }
            set
            {
                this.widthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LengthSpecified
        {
            get
            {
                return this.lengthFieldSpecified;
            }
            set
            {
                this.lengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeightSpecified
        {
            get
            {
                return this.weightFieldSpecified;
            }
            set
            {
                this.weightFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherEquipment
        {
            get
            {
                return this.otherEquipmentField;
            }
            set
            {
                this.otherEquipmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BaggageName
        {
            get
            {
                return this.baggageNameField;
            }
            set
            {
                this.baggageNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string DisabledPassenger
        {
            get
            {
                return this.disabledPassengerField;
            }
            set
            {
                this.disabledPassengerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherAnimalType
        {
            get
            {
                return this.otherAnimalTypeField;
            }
            set
            {
                this.otherAnimalTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ArrayOfSpecialReqDetailsTypeSpecialServiceRequestSpecialServiceRequestSSRType SSRType
        {
            get
            {
                return this.sSRTypeField;
            }
            set
            {
                this.sSRTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] TravelerRefNumberRPHList
        {
            get
            {
                return this.travelerRefNumberRPHListField;
            }
            set
            {
                this.travelerRefNumberRPHListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] FlightRefNumberRPHList
        {
            get
            {
                return this.flightRefNumberRPHListField;
            }
            set
            {
                this.flightRefNumberRPHListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool WithDog
        {
            get
            {
                return this.withDogField;
            }
            set
            {
                this.withDogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WithDogSpecified
        {
            get
            {
                return this.withDogFieldSpecified;
            }
            set
            {
                this.withDogFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("WithDogSpecified")]
        public bool WithDogSpecified1
        {
            get
            {
                return this.withDogSpecified1Field;
            }
            set
            {
                this.withDogSpecified1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AirlineCode
        {
            get
            {
                return this.airlineCodeField;
            }
            set
            {
                this.airlineCodeField = value;
            }
        }
    }
}