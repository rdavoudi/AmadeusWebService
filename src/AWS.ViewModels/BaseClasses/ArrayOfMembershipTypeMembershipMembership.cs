namespace AWS.ViewModels.BaseClasses
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://epowerv5.amadeus.com.tr/WS")]
    public partial class ArrayOfMembershipTypeMembershipMembership
    {

        private string programCodeField;

        private string bonusCodeField;

        private string accountIDField;

        private string pointsEarnedField;

        private string travelSectorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramCode
        {
            get
            {
                return this.programCodeField;
            }
            set
            {
                this.programCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string BonusCode
        {
            get
            {
                return this.bonusCodeField;
            }
            set
            {
                this.bonusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string PointsEarned
        {
            get
            {
                return this.pointsEarnedField;
            }
            set
            {
                this.pointsEarnedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TravelSector
        {
            get
            {
                return this.travelSectorField;
            }
            set
            {
                this.travelSectorField = value;
            }
        }
    }
}