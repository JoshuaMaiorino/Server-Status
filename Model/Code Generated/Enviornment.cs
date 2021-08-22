using System;
using System.Collections.Generic;
using System.Text;

namespace Server_Status.Model
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    [System.Xml.Serialization.XmlRootAttribute( Namespace = "", IsNullable = false )]
    public partial class environment
    {

        private decimal dayTimeField;

        private int currentDayField;

        private int realHourTimerField;

        private environmentWeather weatherField;

        /// <remarks/>
        public decimal dayTime
        {
            get
            {
                return this.dayTimeField;
            }
            set
            {
                this.dayTimeField = value;
            }
        }

        /// <remarks/>
        public int currentDay
        {
            get
            {
                return this.currentDayField;
            }
            set
            {
                this.currentDayField = value;
            }
        }

        /// <remarks/>
        public int realHourTimer
        {
            get
            {
                return this.realHourTimerField;
            }
            set
            {
                this.realHourTimerField = value;
            }
        }

        /// <remarks/>
        public environmentWeather weather
        {
            get
            {
                return this.weatherField;
            }
            set
            {
                this.weatherField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class environmentWeather
    {

        private environmentWeatherInstance[] forecastField;

        private environmentWeatherFog fogField;

        private ushort timeSinceLastRainField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "instance", IsNullable = false )]
        public environmentWeatherInstance[] forecast
        {
            get
            {
                return this.forecastField;
            }
            set
            {
                this.forecastField = value;
            }
        }

        /// <remarks/>
        public environmentWeatherFog fog
        {
            get
            {
                return this.fogField;
            }
            set
            {
                this.fogField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort timeSinceLastRain
        {
            get
            {
                return this.timeSinceLastRainField;
            }
            set
            {
                this.timeSinceLastRainField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class environmentWeatherInstance
    {

        private decimal durationLeftField;

        private bool durationLeftFieldSpecified;

        private string typeNameField;

        private byte variationIndexField;

        private decimal durationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal durationLeft
        {
            get
            {
                return this.durationLeftField;
            }
            set
            {
                this.durationLeftField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool durationLeftSpecified
        {
            get
            {
                return this.durationLeftFieldSpecified;
            }
            set
            {
                this.durationLeftFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeName
        {
            get
            {
                return this.typeNameField;
            }
            set
            {
                this.typeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte variationIndex
        {
            get
            {
                return this.variationIndexField;
            }
            set
            {
                this.variationIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class environmentWeatherFog
    {

        private decimal currentMieScaleField;

        private decimal lastMieScaleField;

        private decimal targetMieScaleField;

        private decimal alphaField;

        private decimal durationField;

        private decimal nightFactorField;

        private decimal dayFactorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal currentMieScale
        {
            get
            {
                return this.currentMieScaleField;
            }
            set
            {
                this.currentMieScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lastMieScale
        {
            get
            {
                return this.lastMieScaleField;
            }
            set
            {
                this.lastMieScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal targetMieScale
        {
            get
            {
                return this.targetMieScaleField;
            }
            set
            {
                this.targetMieScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal alpha
        {
            get
            {
                return this.alphaField;
            }
            set
            {
                this.alphaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nightFactor
        {
            get
            {
                return this.nightFactorField;
            }
            set
            {
                this.nightFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dayFactor
        {
            get
            {
                return this.dayFactorField;
            }
            set
            {
                this.dayFactorField = value;
            }
        }
    }


}
