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
    public partial class seasons
    {

        private seasonsEnvironment environmentField;

        private seasonsWeather weatherField;

        private seasonsGrowth growthField;

        private seasonsEconomy economyField;

        private seasonsVehicle vehicleField;

        private byte versionField;

        /// <remarks/>
        public seasonsEnvironment environment
        {
            get
            {
                return this.environmentField;
            }
            set
            {
                this.environmentField = value;
            }
        }

        /// <remarks/>
        public seasonsWeather weather
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

        /// <remarks/>
        public seasonsGrowth growth
        {
            get
            {
                return this.growthField;
            }
            set
            {
                this.growthField = value;
            }
        }

        /// <remarks/>
        public seasonsEconomy economy
        {
            get
            {
                return this.economyField;
            }
            set
            {
                this.economyField = value;
            }
        }

        /// <remarks/>
        public seasonsVehicle vehicle
        {
            get
            {
                return this.vehicleField;
            }
            set
            {
                this.vehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsEnvironment
    {

        private byte currentDayOffsetField;

        private byte daysPerSeasonField;

        private seasonsEnvironmentSnow snowField;

        /// <remarks/>
        public byte currentDayOffset
        {
            get
            {
                return this.currentDayOffsetField;
            }
            set
            {
                this.currentDayOffsetField = value;
            }
        }

        /// <remarks/>
        public byte daysPerSeason
        {
            get
            {
                return this.daysPerSeasonField;
            }
            set
            {
                this.daysPerSeasonField = value;
            }
        }

        /// <remarks/>
        public seasonsEnvironmentSnow snow
        {
            get
            {
                return this.snowField;
            }
            set
            {
                this.snowField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsEnvironmentSnow
    {

        private decimal heightField;

        private byte modeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal height
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeather
    {

        private decimal soilTempField;

        private decimal soilTempMaxField;

        private decimal highTempPrevField;

        private decimal cropMoistureContentField;

        private decimal soilWaterContentField;

        private decimal lowAirTempField;

        private decimal snowDepthField;

        private decimal rotDryFactorField;

        private decimal averageSoilWaterContentField;

        private bool moistureEnabledField;

        private seasonsWeatherEvent[] eventsField;

        private seasonsWeatherFog fogField;

        private decimal prevHighTempField;

        private seasonsWeatherItem[] forecastField;

        private ushort timeSinceLastRainField;

        /// <remarks/>
        public decimal soilTemp
        {
            get
            {
                return this.soilTempField;
            }
            set
            {
                this.soilTempField = value;
            }
        }

        /// <remarks/>
        public decimal soilTempMax
        {
            get
            {
                return this.soilTempMaxField;
            }
            set
            {
                this.soilTempMaxField = value;
            }
        }

        /// <remarks/>
        public decimal highTempPrev
        {
            get
            {
                return this.highTempPrevField;
            }
            set
            {
                this.highTempPrevField = value;
            }
        }

        /// <remarks/>
        public decimal cropMoistureContent
        {
            get
            {
                return this.cropMoistureContentField;
            }
            set
            {
                this.cropMoistureContentField = value;
            }
        }

        /// <remarks/>
        public decimal soilWaterContent
        {
            get
            {
                return this.soilWaterContentField;
            }
            set
            {
                this.soilWaterContentField = value;
            }
        }

        /// <remarks/>
        public decimal lowAirTemp
        {
            get
            {
                return this.lowAirTempField;
            }
            set
            {
                this.lowAirTempField = value;
            }
        }

        /// <remarks/>
        public decimal snowDepth
        {
            get
            {
                return this.snowDepthField;
            }
            set
            {
                this.snowDepthField = value;
            }
        }

        /// <remarks/>
        public decimal rotDryFactor
        {
            get
            {
                return this.rotDryFactorField;
            }
            set
            {
                this.rotDryFactorField = value;
            }
        }

        /// <remarks/>
        public decimal averageSoilWaterContent
        {
            get
            {
                return this.averageSoilWaterContentField;
            }
            set
            {
                this.averageSoilWaterContentField = value;
            }
        }

        /// <remarks/>
        public bool moistureEnabled
        {
            get
            {
                return this.moistureEnabledField;
            }
            set
            {
                this.moistureEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "event", IsNullable = false )]
        public seasonsWeatherEvent[] events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }

        /// <remarks/>
        public seasonsWeatherFog fog
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
        public decimal prevHighTemp
        {
            get
            {
                return this.prevHighTempField;
            }
            set
            {
                this.prevHighTempField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "item", IsNullable = false )]
        public seasonsWeatherItem[] forecast
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
    public partial class seasonsWeatherEvent
    {

        private seasonsWeatherEventFog fogField;

        private seasonsWeatherEventClouds cloudsField;

        private seasonsWeatherEventWind windField;

        private seasonsWeatherEventPrecipitation precipitationField;

        private seasonsWeatherEventTemperature temperatureField;

        private decimal nField;

        private byte startDayField;

        private byte endDayField;

        private decimal startTimeField;

        private decimal endTimeField;

        private byte weatherTypeField;

        /// <remarks/>
        public seasonsWeatherEventFog fog
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
        public seasonsWeatherEventClouds clouds
        {
            get
            {
                return this.cloudsField;
            }
            set
            {
                this.cloudsField = value;
            }
        }

        /// <remarks/>
        public seasonsWeatherEventWind wind
        {
            get
            {
                return this.windField;
            }
            set
            {
                this.windField = value;
            }
        }

        /// <remarks/>
        public seasonsWeatherEventPrecipitation precipitation
        {
            get
            {
                return this.precipitationField;
            }
            set
            {
                this.precipitationField = value;
            }
        }

        /// <remarks/>
        public seasonsWeatherEventTemperature temperature
        {
            get
            {
                return this.temperatureField;
            }
            set
            {
                this.temperatureField = value;
            }
        }

        /// <remarks/>
        public decimal n
        {
            get
            {
                return this.nField;
            }
            set
            {
                this.nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte startDay
        {
            get
            {
                return this.startDayField;
            }
            set
            {
                this.startDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte endDay
        {
            get
            {
                return this.endDayField;
            }
            set
            {
                this.endDayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal startTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal endTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte weatherType
        {
            get
            {
                return this.weatherTypeField;
            }
            set
            {
                this.weatherTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherEventFog
    {

        private decimal scaleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherEventClouds
    {

        private decimal typeFromField;

        private decimal typeToField;

        private decimal coverageField;

        private decimal cirrusDensityScaleField;

        private decimal cirrusSpeedFactorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal typeFrom
        {
            get
            {
                return this.typeFromField;
            }
            set
            {
                this.typeFromField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal typeTo
        {
            get
            {
                return this.typeToField;
            }
            set
            {
                this.typeToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal coverage
        {
            get
            {
                return this.coverageField;
            }
            set
            {
                this.coverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cirrusDensityScale
        {
            get
            {
                return this.cirrusDensityScaleField;
            }
            set
            {
                this.cirrusDensityScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cirrusSpeedFactor
        {
            get
            {
                return this.cirrusSpeedFactorField;
            }
            set
            {
                this.cirrusSpeedFactorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherEventWind
    {

        private decimal dirXField;

        private decimal dirZField;

        private decimal velocityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dirX
        {
            get
            {
                return this.dirXField;
            }
            set
            {
                this.dirXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal dirZ
        {
            get
            {
                return this.dirZField;
            }
            set
            {
                this.dirZField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal velocity
        {
            get
            {
                return this.velocityField;
            }
            set
            {
                this.velocityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherEventPrecipitation
    {

        private decimal intensityField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal intensity
        {
            get
            {
                return this.intensityField;
            }
            set
            {
                this.intensityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherEventTemperature
    {

        private decimal indicationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal indication
        {
            get
            {
                return this.indicationField;
            }
            set
            {
                this.indicationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherFog
    {

        private decimal currentMieScaleField;

        private decimal lastMieScaleField;

        private decimal targetMieScaleField;

        private decimal alphaField;

        private decimal durationField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsWeatherItem
    {

        private byte dayField;

        private byte seasonField;

        private decimal averagePeriodTempField;

        private decimal pField;

        private decimal startTimeIndicationField;

        private decimal windSpeedField;

        private byte windTypeField;

        private byte forecastTypeField;

        private decimal cloudCoverField;

        private decimal lowTempField;

        private decimal highTempField;

        private decimal tempUncertaintyField;

        private decimal windUncertaintyField;

        private decimal precipitationUncertaintyField;

        private decimal weatherTypeUncertaintyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte day
        {
            get
            {
                return this.dayField;
            }
            set
            {
                this.dayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte season
        {
            get
            {
                return this.seasonField;
            }
            set
            {
                this.seasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal averagePeriodTemp
        {
            get
            {
                return this.averagePeriodTempField;
            }
            set
            {
                this.averagePeriodTempField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal startTimeIndication
        {
            get
            {
                return this.startTimeIndicationField;
            }
            set
            {
                this.startTimeIndicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal windSpeed
        {
            get
            {
                return this.windSpeedField;
            }
            set
            {
                this.windSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte windType
        {
            get
            {
                return this.windTypeField;
            }
            set
            {
                this.windTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte forecastType
        {
            get
            {
                return this.forecastTypeField;
            }
            set
            {
                this.forecastTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cloudCover
        {
            get
            {
                return this.cloudCoverField;
            }
            set
            {
                this.cloudCoverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lowTemp
        {
            get
            {
                return this.lowTempField;
            }
            set
            {
                this.lowTempField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal highTemp
        {
            get
            {
                return this.highTempField;
            }
            set
            {
                this.highTempField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tempUncertainty
        {
            get
            {
                return this.tempUncertaintyField;
            }
            set
            {
                this.tempUncertaintyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal windUncertainty
        {
            get
            {
                return this.windUncertaintyField;
            }
            set
            {
                this.windUncertaintyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal precipitationUncertainty
        {
            get
            {
                return this.precipitationUncertaintyField;
            }
            set
            {
                this.precipitationUncertaintyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal weatherTypeUncertainty
        {
            get
            {
                return this.weatherTypeUncertaintyField;
            }
            set
            {
                this.weatherTypeUncertaintyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsGrowth
    {

        private seasonsGrowthField[] fieldsField;

        private seasonsGrowthCpf cpfField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "field", IsNullable = false )]
        public seasonsGrowthField[] fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }

        /// <remarks/>
        public seasonsGrowthCpf cpf
        {
            get
            {
                return this.cpfField;
            }
            set
            {
                this.cpfField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsGrowthField
    {

        private byte idField;

        private byte fruitIndexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fruitIndex
        {
            get
            {
                return this.fruitIndexField;
            }
            set
            {
                this.fruitIndexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsGrowthCpf
    {

        private byte weedsScaleField;

        private byte damageScaleField;

        private byte numberOfFruitsField;

        private byte fruitToProcessIndexField;

        private decimal timerIntervalField;

        private seasonsGrowthCpfFruitIndex[] fruitIndexField;

        /// <remarks/>
        public byte weedsScale
        {
            get
            {
                return this.weedsScaleField;
            }
            set
            {
                this.weedsScaleField = value;
            }
        }

        /// <remarks/>
        public byte damageScale
        {
            get
            {
                return this.damageScaleField;
            }
            set
            {
                this.damageScaleField = value;
            }
        }

        /// <remarks/>
        public byte numberOfFruits
        {
            get
            {
                return this.numberOfFruitsField;
            }
            set
            {
                this.numberOfFruitsField = value;
            }
        }

        /// <remarks/>
        public byte fruitToProcessIndex
        {
            get
            {
                return this.fruitToProcessIndexField;
            }
            set
            {
                this.fruitToProcessIndexField = value;
            }
        }

        /// <remarks/>
        public decimal timerInterval
        {
            get
            {
                return this.timerIntervalField;
            }
            set
            {
                this.timerIntervalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "fruitIndex" )]
        public seasonsGrowthCpfFruitIndex[] fruitIndex
        {
            get
            {
                return this.fruitIndexField;
            }
            set
            {
                this.fruitIndexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsGrowthCpfFruitIndex
    {

        private byte indexField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte index
        {
            get
            {
                return this.indexField;
            }
            set
            {
                this.indexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsEconomy
    {

        private seasonsEconomyFill[] historyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "fill", IsNullable = false )]
        public seasonsEconomyFill[] history
        {
            get
            {
                return this.historyField;
            }
            set
            {
                this.historyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsEconomyFill
    {

        private string valuesField;

        private string fillTypeField;

        /// <remarks/>
        public string values
        {
            get
            {
                return this.valuesField;
            }
            set
            {
                this.valuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fillType
        {
            get
            {
                return this.fillTypeField;
            }
            set
            {
                this.fillTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class seasonsVehicle
    {

        private bool snowTracksEnabledField;

        /// <remarks/>
        public bool snowTracksEnabled
        {
            get
            {
                return this.snowTracksEnabledField;
            }
            set
            {
                this.snowTracksEnabledField = value;
            }
        }
    }


}
