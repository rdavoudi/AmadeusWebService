namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class MiniRule
    {

        private string rPHField;

        private string passengerTypeField;

        private string brandCodeField;

        private CarryOnBaggageAllowance carryOnBaggageAllowanceField;

        private CheckedBaggageAllowance checkedBaggageAllowanceField;

        private PenaltyMiniRule penaltyMiniRuleField;

        private string brandKeyField;

        private string mealSubCodeField;

        private string mealCommercialNameField;

        private string businessLoungeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 0)]
        public string RPH
        {
            get
            {
                return this.rPHField;
            }
            set
            {
                this.rPHField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 1)]
        public string PassengerType
        {
            get
            {
                return this.passengerTypeField;
            }
            set
            {
                this.passengerTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 2)]
        public string BrandCode
        {
            get
            {
                return this.brandCodeField;
            }
            set
            {
                this.brandCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 3)]
        public CarryOnBaggageAllowance CarryOnBaggageAllowance
        {
            get
            {
                return this.carryOnBaggageAllowanceField;
            }
            set
            {
                this.carryOnBaggageAllowanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 4)]
        public CheckedBaggageAllowance CheckedBaggageAllowance
        {
            get
            {
                return this.checkedBaggageAllowanceField;
            }
            set
            {
                this.checkedBaggageAllowanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 5)]
        public PenaltyMiniRule PenaltyMiniRule
        {
            get
            {
                return this.penaltyMiniRuleField;
            }
            set
            {
                this.penaltyMiniRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 6)]
        public string BrandKey
        {
            get
            {
                return this.brandKeyField;
            }
            set
            {
                this.brandKeyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 7)]
        public string MealSubCode
        {
            get
            {
                return this.mealSubCodeField;
            }
            set
            {
                this.mealSubCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 8)]
        public string MealCommercialName
        {
            get
            {
                return this.mealCommercialNameField;
            }
            set
            {
                this.mealCommercialNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true, Order = 9)]
        public string BusinessLounge
        {
            get
            {
                return this.businessLoungeField;
            }
            set
            {
                this.businessLoungeField = value;
            }
        }
    }
}