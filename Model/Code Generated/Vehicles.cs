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
    public partial class vehicles
    {

        private vehiclesVehicle[] vehicleField;

        private vehiclesAttachments[] attachmentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "vehicle" )]
        public vehiclesVehicle[] vehicle
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
        [System.Xml.Serialization.XmlElementAttribute( "attachments" )]
        public vehiclesAttachments[] attachments
        {
            get
            {
                return this.attachmentsField;
            }
            set
            {
                this.attachmentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicle
    {

        private object[] itemsField;

        private byte idField;

        private string modNameField;

        private string filenameField;

        private bool isAbsoluteField;

        private decimal ageField;

        private decimal priceField;

        private byte farmIdField;

        private byte propertyStateField;

        private decimal operatingTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "AAA_CX_DisplayAddon", typeof( vehiclesVehicleAAA_CX_DisplayAddon ) )]
        [System.Xml.Serialization.XmlElementAttribute( "FS19_AutoDrive", typeof( vehiclesVehicleFS19_AutoDrive ) )]
        [System.Xml.Serialization.XmlElementAttribute( "FS19_RM_Seasons", typeof( vehiclesVehicleFS19_RM_Seasons ) )]
        [System.Xml.Serialization.XmlElementAttribute( "FS19_addon_strawHarvest", typeof( vehiclesVehicleFS19_addon_strawHarvest ) )]
        [System.Xml.Serialization.XmlElementAttribute( "FS19_guidanceSteering", typeof( vehiclesVehicleFS19_guidanceSteering ) )]
        [System.Xml.Serialization.XmlElementAttribute( "FS19_precisionFarming", typeof( vehiclesVehicleFS19_precisionFarming ) )]
        [System.Xml.Serialization.XmlElementAttribute( "ParkVehicle", typeof( vehiclesVehicleParkVehicle ) )]
        [System.Xml.Serialization.XmlElementAttribute( "RealMower", typeof( vehiclesVehicleRealMower ) )]
        [System.Xml.Serialization.XmlElementAttribute( "VehicleStraps", typeof( vehiclesVehicleVehicleStraps ) )]
        [System.Xml.Serialization.XmlElementAttribute( "attachable", typeof( vehiclesVehicleAttachable ) )]
        [System.Xml.Serialization.XmlElementAttribute( "attacherJoints", typeof( vehiclesVehicleAttacherJoints ) )]
        [System.Xml.Serialization.XmlElementAttribute( "baler", typeof( vehiclesVehicleBaler ) )]
        [System.Xml.Serialization.XmlElementAttribute( "boughtConfiguration", typeof( vehiclesVehicleBoughtConfiguration ) )]
        [System.Xml.Serialization.XmlElementAttribute( "combine", typeof( vehiclesVehicleCombine ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component1", typeof( vehiclesVehicleComponent1 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component10", typeof( vehiclesVehicleComponent10 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component11", typeof( vehiclesVehicleComponent11 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component12", typeof( vehiclesVehicleComponent12 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component13", typeof( vehiclesVehicleComponent13 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component2", typeof( vehiclesVehicleComponent2 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component3", typeof( vehiclesVehicleComponent3 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component4", typeof( vehiclesVehicleComponent4 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component5", typeof( vehiclesVehicleComponent5 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component6", typeof( vehiclesVehicleComponent6 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component7", typeof( vehiclesVehicleComponent7 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component8", typeof( vehiclesVehicleComponent8 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "component9", typeof( vehiclesVehicleComponent9 ) )]
        [System.Xml.Serialization.XmlElementAttribute( "configuration", typeof( vehiclesVehicleConfiguration ) )]
        [System.Xml.Serialization.XmlElementAttribute( "courseplay", typeof( vehiclesVehicleCourseplay ) )]
        [System.Xml.Serialization.XmlElementAttribute( "cover", typeof( vehiclesVehicleCover ) )]
        [System.Xml.Serialization.XmlElementAttribute( "cylindered", typeof( vehiclesVehicleCylindered ) )]
        [System.Xml.Serialization.XmlElementAttribute( "drivable", typeof( vehiclesVehicleDrivable ) )]
        [System.Xml.Serialization.XmlElementAttribute( "fillUnit", typeof( vehiclesVehicleFillUnit ) )]
        [System.Xml.Serialization.XmlElementAttribute( "foldable", typeof( vehiclesVehicleFoldable ) )]
        [System.Xml.Serialization.XmlElementAttribute( "followMe", typeof( vehiclesVehicleFollowMe ) )]
        [System.Xml.Serialization.XmlElementAttribute( "pipe", typeof( vehiclesVehiclePipe ) )]
        [System.Xml.Serialization.XmlElementAttribute( "plow", typeof( vehiclesVehiclePlow ) )]
        [System.Xml.Serialization.XmlElementAttribute( "receivingHopper", typeof( vehiclesVehicleReceivingHopper ) )]
        [System.Xml.Serialization.XmlElementAttribute( "sowingMachine", typeof( vehiclesVehicleSowingMachine ) )]
        [System.Xml.Serialization.XmlElementAttribute( "tensionBelts", typeof( vehiclesVehicleTensionBelts ) )]
        [System.Xml.Serialization.XmlElementAttribute( "varBaleCap", typeof( vehiclesVehicleVarBaleCap ) )]
        [System.Xml.Serialization.XmlElementAttribute( "washable", typeof( vehiclesVehicleWashable ) )]
        [System.Xml.Serialization.XmlElementAttribute( "wearable", typeof( vehiclesVehicleWearable ) )]
        [System.Xml.Serialization.XmlElementAttribute( "workMode", typeof( vehiclesVehicleWorkMode ) )]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

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
        public string modName
        {
            get
            {
                return this.modNameField;
            }
            set
            {
                this.modNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isAbsolute
        {
            get
            {
                return this.isAbsoluteField;
            }
            set
            {
                this.isAbsoluteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte farmId
        {
            get
            {
                return this.farmIdField;
            }
            set
            {
                this.farmIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte propertyState
        {
            get
            {
                return this.propertyStateField;
            }
            set
            {
                this.propertyStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal operatingTime
        {
            get
            {
                return this.operatingTimeField;
            }
            set
            {
                this.operatingTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleAAA_CX_DisplayAddon
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "fillTypeUsage", typeof( vehiclesVehicleAAA_CX_DisplayAddonFillTypeUsage ) )]
        [System.Xml.Serialization.XmlElementAttribute( "workArea", typeof( vehiclesVehicleAAA_CX_DisplayAddonWorkArea ) )]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleAAA_CX_DisplayAddonFillTypeUsage
    {

        private vehiclesVehicleAAA_CX_DisplayAddonFillTypeUsageUsage usageField;

        /// <remarks/>
        public vehiclesVehicleAAA_CX_DisplayAddonFillTypeUsageUsage usage
        {
            get
            {
                return this.usageField;
            }
            set
            {
                this.usageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleAAA_CX_DisplayAddonFillTypeUsageUsage
    {

        private string realFillTypeField;

        private string dispFillTypeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string realFillType
        {
            get
            {
                return this.realFillTypeField;
            }
            set
            {
                this.realFillTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dispFillType
        {
            get
            {
                return this.dispFillTypeField;
            }
            set
            {
                this.dispFillTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    public partial class vehiclesVehicleAAA_CX_DisplayAddonWorkArea
    {

        private decimal workedHectaresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal workedHectares
        {
            get
            {
                return this.workedHectaresField;
            }
            set
            {
                this.workedHectaresField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_AutoDrive
    {

        private vehiclesVehicleFS19_AutoDriveAutoDrive autoDriveField;

        /// <remarks/>
        public vehiclesVehicleFS19_AutoDriveAutoDrive AutoDrive
        {
            get
            {
                return this.autoDriveField;
            }
            set
            {
                this.autoDriveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_AutoDriveAutoDrive
    {

        private byte modeField;

        private byte fillTypeField;

        private byte loopCounterField;

        private byte speedLimitField;

        private byte fieldSpeedLimitField;

        private string driverNameField;

        private bool lastActiveField;

        private bool aIVElastActiveField;

        private byte bunkerUnloadTypeField;

        private byte shovelHeightField;

        private byte followDistanceField;

        private byte parkInFieldField;

        private byte pipeOffsetField;

        private byte unloadFillLevelField;

        private byte cornerSpeedField;

        private byte shovelWidthField;

        private byte exitFieldField;

        private byte preCallLevelField;

        private byte autoTrailerCoverField;

        private byte autoTipSideField;

        private byte enableParkAtJobFinishedField;

        private byte autoRefuelField;

        private byte useBeaconLightsField;

        private byte avoidFruitField;

        private byte followOnlyOnFieldField;

        private byte callSecondUnloaderField;

        private byte rotateTargetsField;

        private byte useForwardTurningManoeuvreField;

        private byte restrictToFieldField;

        private string groupsField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fillType
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte loopCounter
        {
            get
            {
                return this.loopCounterField;
            }
            set
            {
                this.loopCounterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte speedLimit
        {
            get
            {
                return this.speedLimitField;
            }
            set
            {
                this.speedLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte fieldSpeedLimit
        {
            get
            {
                return this.fieldSpeedLimitField;
            }
            set
            {
                this.fieldSpeedLimitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string driverName
        {
            get
            {
                return this.driverNameField;
            }
            set
            {
                this.driverNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool lastActive
        {
            get
            {
                return this.lastActiveField;
            }
            set
            {
                this.lastActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool AIVElastActive
        {
            get
            {
                return this.aIVElastActiveField;
            }
            set
            {
                this.aIVElastActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte bunkerUnloadType
        {
            get
            {
                return this.bunkerUnloadTypeField;
            }
            set
            {
                this.bunkerUnloadTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte shovelHeight
        {
            get
            {
                return this.shovelHeightField;
            }
            set
            {
                this.shovelHeightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte followDistance
        {
            get
            {
                return this.followDistanceField;
            }
            set
            {
                this.followDistanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte parkInField
        {
            get
            {
                return this.parkInFieldField;
            }
            set
            {
                this.parkInFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte pipeOffset
        {
            get
            {
                return this.pipeOffsetField;
            }
            set
            {
                this.pipeOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte unloadFillLevel
        {
            get
            {
                return this.unloadFillLevelField;
            }
            set
            {
                this.unloadFillLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte cornerSpeed
        {
            get
            {
                return this.cornerSpeedField;
            }
            set
            {
                this.cornerSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte shovelWidth
        {
            get
            {
                return this.shovelWidthField;
            }
            set
            {
                this.shovelWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte exitField
        {
            get
            {
                return this.exitFieldField;
            }
            set
            {
                this.exitFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte preCallLevel
        {
            get
            {
                return this.preCallLevelField;
            }
            set
            {
                this.preCallLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte autoTrailerCover
        {
            get
            {
                return this.autoTrailerCoverField;
            }
            set
            {
                this.autoTrailerCoverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte autoTipSide
        {
            get
            {
                return this.autoTipSideField;
            }
            set
            {
                this.autoTipSideField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte enableParkAtJobFinished
        {
            get
            {
                return this.enableParkAtJobFinishedField;
            }
            set
            {
                this.enableParkAtJobFinishedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte autoRefuel
        {
            get
            {
                return this.autoRefuelField;
            }
            set
            {
                this.autoRefuelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte useBeaconLights
        {
            get
            {
                return this.useBeaconLightsField;
            }
            set
            {
                this.useBeaconLightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte avoidFruit
        {
            get
            {
                return this.avoidFruitField;
            }
            set
            {
                this.avoidFruitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte followOnlyOnField
        {
            get
            {
                return this.followOnlyOnFieldField;
            }
            set
            {
                this.followOnlyOnFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte callSecondUnloader
        {
            get
            {
                return this.callSecondUnloaderField;
            }
            set
            {
                this.callSecondUnloaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rotateTargets
        {
            get
            {
                return this.rotateTargetsField;
            }
            set
            {
                this.rotateTargetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte useForwardTurningManoeuvre
        {
            get
            {
                return this.useForwardTurningManoeuvreField;
            }
            set
            {
                this.useForwardTurningManoeuvreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte restrictToField
        {
            get
            {
                return this.restrictToFieldField;
            }
            set
            {
                this.restrictToFieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string groups
        {
            get
            {
                return this.groupsField;
            }
            set
            {
                this.groupsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_RM_Seasons
    {

        private vehiclesVehicleFS19_RM_SeasonsSeasonsVehicle seasonsVehicleField;

        private vehiclesVehicleFS19_RM_SeasonsAgeWear ageWearField;

        /// <remarks/>
        public vehiclesVehicleFS19_RM_SeasonsSeasonsVehicle seasonsVehicle
        {
            get
            {
                return this.seasonsVehicleField;
            }
            set
            {
                this.seasonsVehicleField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleFS19_RM_SeasonsAgeWear ageWear
        {
            get
            {
                return this.ageWearField;
            }
            set
            {
                this.ageWearField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_RM_SeasonsSeasonsVehicle
    {

        private decimal yearsField;

        private decimal nextRepairField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal years
        {
            get
            {
                return this.yearsField;
            }
            set
            {
                this.yearsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nextRepair
        {
            get
            {
                return this.nextRepairField;
            }
            set
            {
                this.nextRepairField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_RM_SeasonsAgeWear
    {

        private vehiclesVehicleFS19_RM_SeasonsAgeWearScratchNode scratchNodeField;

        private decimal lastRepaintOperatingTimeField;

        /// <remarks/>
        public vehiclesVehicleFS19_RM_SeasonsAgeWearScratchNode scratchNode
        {
            get
            {
                return this.scratchNodeField;
            }
            set
            {
                this.scratchNodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lastRepaintOperatingTime
        {
            get
            {
                return this.lastRepaintOperatingTimeField;
            }
            set
            {
                this.lastRepaintOperatingTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_RM_SeasonsAgeWearScratchNode
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_addon_strawHarvest
    {

        private vehiclesVehicleFS19_addon_strawHarvestStrawHarvestBaleCounter strawHarvestBaleCounterField;

        private vehiclesVehicleFS19_addon_strawHarvestStrawHarvestRefillSupplies strawHarvestRefillSuppliesField;

        /// <remarks/>
        public vehiclesVehicleFS19_addon_strawHarvestStrawHarvestBaleCounter strawHarvestBaleCounter
        {
            get
            {
                return this.strawHarvestBaleCounterField;
            }
            set
            {
                this.strawHarvestBaleCounterField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleFS19_addon_strawHarvestStrawHarvestRefillSupplies strawHarvestRefillSupplies
        {
            get
            {
                return this.strawHarvestRefillSuppliesField;
            }
            set
            {
                this.strawHarvestRefillSuppliesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_addon_strawHarvestStrawHarvestBaleCounter
    {

        private byte currentCountField;

        private byte lifetimeCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte currentCount
        {
            get
            {
                return this.currentCountField;
            }
            set
            {
                this.currentCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte lifetimeCount
        {
            get
            {
                return this.lifetimeCountField;
            }
            set
            {
                this.lifetimeCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_addon_strawHarvestStrawHarvestRefillSupplies
    {

        private bool isCoverOpenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isCoverOpen
        {
            get
            {
                return this.isCoverOpenField;
            }
            set
            {
                this.isCoverOpenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_guidanceSteering
    {

        private vehiclesVehicleFS19_guidanceSteeringGlobalPositioningSystem globalPositioningSystemField;

        /// <remarks/>
        public vehiclesVehicleFS19_guidanceSteeringGlobalPositioningSystem globalPositioningSystem
        {
            get
            {
                return this.globalPositioningSystemField;
            }
            set
            {
                this.globalPositioningSystemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_guidanceSteeringGlobalPositioningSystem
    {

        private bool guidanceIsActiveField;

        private bool autoInvertOffsetField;

        private decimal lineDistanceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool guidanceIsActive
        {
            get
            {
                return this.guidanceIsActiveField;
            }
            set
            {
                this.guidanceIsActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool autoInvertOffset
        {
            get
            {
                return this.autoInvertOffsetField;
            }
            set
            {
                this.autoInvertOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lineDistance
        {
            get
            {
                return this.lineDistanceField;
            }
            set
            {
                this.lineDistanceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_precisionFarming
    {

        private vehiclesVehicleFS19_precisionFarmingExtendedSprayer extendedSprayerField;

        /// <remarks/>
        public vehiclesVehicleFS19_precisionFarmingExtendedSprayer extendedSprayer
        {
            get
            {
                return this.extendedSprayerField;
            }
            set
            {
                this.extendedSprayerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFS19_precisionFarmingExtendedSprayer
    {

        private bool sprayAmountAutoModeField;

        private byte sprayAmountManualField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool sprayAmountAutoMode
        {
            get
            {
                return this.sprayAmountAutoModeField;
            }
            set
            {
                this.sprayAmountAutoModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte sprayAmountManual
        {
            get
            {
                return this.sprayAmountManualField;
            }
            set
            {
                this.sprayAmountManualField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleParkVehicle
    {

        private vehiclesVehicleParkVehiclePlayer playerField;

        /// <remarks/>
        public vehiclesVehicleParkVehiclePlayer player
        {
            get
            {
                return this.playerField;
            }
            set
            {
                this.playerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleParkVehiclePlayer
    {

        private string idField;

        private bool isParkedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
        public bool isParked
        {
            get
            {
                return this.isParkedField;
            }
            set
            {
                this.isParkedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleRealMower
    {

        private bool modActiveField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool modActive
        {
            get
            {
                return this.modActiveField;
            }
            set
            {
                this.modActiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleVehicleStraps
    {

        private bool fastenedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool fastened
        {
            get
            {
                return this.fastenedField;
            }
            set
            {
                this.fastenedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleAttachable
    {

        private decimal lowerAnimTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lowerAnimTime
        {
            get
            {
                return this.lowerAnimTimeField;
            }
            set
            {
                this.lowerAnimTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleAttacherJoints
    {

        private sbyte comboDirectionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte comboDirection
        {
            get
            {
                return this.comboDirectionField;
            }
            set
            {
                this.comboDirectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleBaler
    {

        private byte numBalesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte numBales
        {
            get
            {
                return this.numBalesField;
            }
            set
            {
                this.numBalesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleBoughtConfiguration
    {

        private string nameField;

        private byte idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCombine
    {

        private bool isSwathActiveField;

        private decimal workedHectarsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isSwathActive
        {
            get
            {
                return this.isSwathActiveField;
            }
            set
            {
                this.isSwathActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal workedHectars
        {
            get
            {
                return this.workedHectarsField;
            }
            set
            {
                this.workedHectarsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent1
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent10
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent11
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent12
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent13
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent2
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent3
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent4
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent5
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent6
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent7
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent8
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleComponent9
    {

        private string positionField;

        private string rotationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleConfiguration
    {

        private string nameField;

        private byte idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplay
    {

        private vehiclesVehicleCourseplayBasics basicsField;

        private vehiclesVehicleCourseplayHUD hUDField;

        private vehiclesVehicleCourseplayCombi combiField;

        private vehiclesVehicleCourseplayDriving drivingField;

        private vehiclesVehicleCourseplayFieldWork fieldWorkField;

        private vehiclesVehicleCourseplayShowVisualWaypoints showVisualWaypointsField;

        private vehiclesVehicleCourseplaySeparateFillTypeLoading separateFillTypeLoadingField;

        private vehiclesVehicleCourseplayEnableOpenHudWithMouseVehicle enableOpenHudWithMouseVehicleField;

        private vehiclesVehicleCourseplayAutomaticCoverHandling automaticCoverHandlingField;

        private vehiclesVehicleCourseplaySymmetricLaneChange symmetricLaneChangeField;

        private vehiclesVehicleCourseplayLevelCompactSearchOnlyAutomatedDriver levelCompactSearchOnlyAutomatedDriverField;

        private vehiclesVehicleCourseplayDriverPriorityUseFillLevel driverPriorityUseFillLevelField;

        private vehiclesVehicleCourseplayConvoyMaxDistance convoyMaxDistanceField;

        private vehiclesVehicleCourseplayPipeAlwaysUnfold pipeAlwaysUnfoldField;

        private vehiclesVehicleCourseplayImplementLowerTime implementLowerTimeField;

        private vehiclesVehicleCourseplaySiloSelectedFillTypeShovelModeDriver siloSelectedFillTypeShovelModeDriverField;

        private vehiclesVehicleCourseplayKeepCurrentSteering keepCurrentSteeringField;

        private vehiclesVehicleCourseplayFollowAtFillLevel followAtFillLevelField;

        private vehiclesVehicleCourseplayStrawSwath strawSwathField;

        private vehiclesVehicleCourseplayShovelStopAndGo shovelStopAndGoField;

        private vehiclesVehicleCourseplayUsePathfindingInTurns usePathfindingInTurnsField;

        private vehiclesVehicleCourseplayAugerPipeToolPositions augerPipeToolPositionsField;

        private vehiclesVehicleCourseplaySaveFuelOption saveFuelOptionField;

        private vehiclesVehicleCourseplayOppositeTurnMode oppositeTurnModeField;

        private vehiclesVehicleCourseplayBunkerSpeed bunkerSpeedField;

        private vehiclesVehicleCourseplayReverseSpeed reverseSpeedField;

        private vehiclesVehicleCourseplayShovelModeAIDriverTriggerHandlerIsActive shovelModeAIDriverTriggerHandlerIsActiveField;

        private vehiclesVehicleCourseplaySiloSelectedFillTypeFieldSupplyDriver siloSelectedFillTypeFieldSupplyDriverField;

        private vehiclesVehicleCourseplayDriveOnAtFillLevel driveOnAtFillLevelField;

        private vehiclesVehicleCourseplayAllowReverseForPathfindingInTurns allowReverseForPathfindingInTurnsField;

        private vehiclesVehicleCourseplayEnableVisualWaypointsTemporary enableVisualWaypointsTemporaryField;

        private vehiclesVehicleCourseplayRidgeMarkersAutomatic ridgeMarkersAutomaticField;

        private vehiclesVehicleCourseplayCombineWantsCourseplayer combineWantsCourseplayerField;

        private vehiclesVehicleCourseplayToolOffsetZ toolOffsetZField;

        private vehiclesVehicleCourseplayStopForUnload stopForUnloadField;

        private vehiclesVehicleCourseplayUseRealisticDriving useRealisticDrivingField;

        private vehiclesVehicleCourseplayStartingPoint startingPointField;

        private vehiclesVehicleCourseplayTurnSpeed turnSpeedField;

        private vehiclesVehicleCourseplayReturnToFirstPoint returnToFirstPointField;

        private vehiclesVehicleCourseplayAutoDriveMode autoDriveModeField;

        private vehiclesVehicleCourseplayStopAtEnd stopAtEndField;

        private vehiclesVehicleCourseplayImplementRaiseTime implementRaiseTimeField;

        private vehiclesVehicleCourseplayLevelCompactShieldHeight levelCompactShieldHeightField;

        private vehiclesVehicleCourseplayFoldImplementAtEnd foldImplementAtEndField;

        private vehiclesVehicleCourseplayAllwaysSearchFuel allwaysSearchFuelField;

        private vehiclesVehicleCourseplayConvoyActive convoyActiveField;

        private vehiclesVehicleCourseplayToolOffsetX toolOffsetXField;

        private vehiclesVehicleCourseplayMoveOnAtFillLevel moveOnAtFillLevelField;

        private vehiclesVehicleCourseplaySelfUnload selfUnloadField;

        private vehiclesVehicleCourseplayFrontloaderToolPositions frontloaderToolPositionsField;

        private vehiclesVehicleCourseplayForcedToStop forcedToStopField;

        private vehiclesVehicleCourseplaySearchCombineOnField searchCombineOnFieldField;

        private vehiclesVehicleCourseplayConvoyMinDistance convoyMinDistanceField;

        private vehiclesVehicleCourseplayLevelCompactMode levelCompactModeField;

        private vehiclesVehicleCourseplayAllowUnloadOnFirstHeadland allowUnloadOnFirstHeadlandField;

        private vehiclesVehicleCourseplayBaleCollectionField baleCollectionFieldField;

        private vehiclesVehicleCourseplaySiloSelectedFillTypeGrainTransportDriver siloSelectedFillTypeGrainTransportDriverField;

        private vehiclesVehicleCourseplaySiloSelectedFillTypeFillableFieldWorkDriver siloSelectedFillTypeFillableFieldWorkDriverField;

        private vehiclesVehicleCourseplayTurnOnField turnOnFieldField;

        private vehiclesVehicleCourseplayLevelCompactSearchRadius levelCompactSearchRadiusField;

        private vehiclesVehicleCourseplayDriveUnloadNow driveUnloadNowField;

        private vehiclesVehicleCourseplayStreetSpeed streetSpeedField;

        private vehiclesVehicleCourseplayRefillUntilPct refillUntilPctField;

        private vehiclesVehicleCourseplayUseAITurns useAITurnsField;

        private vehiclesVehicleCourseplayLevelCompactSiloTyp levelCompactSiloTypField;

        private vehiclesVehicleCourseplayWarningLightsMode warningLightsModeField;

        private vehiclesVehicleCourseplayShowVisualWaypointsCrossPoint showVisualWaypointsCrossPointField;

        private vehiclesVehicleCourseplayUseRecordingSpeed useRecordingSpeedField;

        private vehiclesVehicleCourseplaySelectedCombineToUnload selectedCombineToUnloadField;

        private vehiclesVehicleCourseplayFieldSpeed fieldSpeedField;

        private vehiclesVehicleCourseplaySowingMachineFertilizerEnabled sowingMachineFertilizerEnabledField;

        /// <remarks/>
        public vehiclesVehicleCourseplayBasics basics
        {
            get
            {
                return this.basicsField;
            }
            set
            {
                this.basicsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayHUD HUD
        {
            get
            {
                return this.hUDField;
            }
            set
            {
                this.hUDField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayCombi combi
        {
            get
            {
                return this.combiField;
            }
            set
            {
                this.combiField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayDriving driving
        {
            get
            {
                return this.drivingField;
            }
            set
            {
                this.drivingField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayFieldWork fieldWork
        {
            get
            {
                return this.fieldWorkField;
            }
            set
            {
                this.fieldWorkField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayShowVisualWaypoints showVisualWaypoints
        {
            get
            {
                return this.showVisualWaypointsField;
            }
            set
            {
                this.showVisualWaypointsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySeparateFillTypeLoading separateFillTypeLoading
        {
            get
            {
                return this.separateFillTypeLoadingField;
            }
            set
            {
                this.separateFillTypeLoadingField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayEnableOpenHudWithMouseVehicle enableOpenHudWithMouseVehicle
        {
            get
            {
                return this.enableOpenHudWithMouseVehicleField;
            }
            set
            {
                this.enableOpenHudWithMouseVehicleField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayAutomaticCoverHandling automaticCoverHandling
        {
            get
            {
                return this.automaticCoverHandlingField;
            }
            set
            {
                this.automaticCoverHandlingField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySymmetricLaneChange symmetricLaneChange
        {
            get
            {
                return this.symmetricLaneChangeField;
            }
            set
            {
                this.symmetricLaneChangeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayLevelCompactSearchOnlyAutomatedDriver levelCompactSearchOnlyAutomatedDriver
        {
            get
            {
                return this.levelCompactSearchOnlyAutomatedDriverField;
            }
            set
            {
                this.levelCompactSearchOnlyAutomatedDriverField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayDriverPriorityUseFillLevel driverPriorityUseFillLevel
        {
            get
            {
                return this.driverPriorityUseFillLevelField;
            }
            set
            {
                this.driverPriorityUseFillLevelField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayConvoyMaxDistance convoyMaxDistance
        {
            get
            {
                return this.convoyMaxDistanceField;
            }
            set
            {
                this.convoyMaxDistanceField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayPipeAlwaysUnfold pipeAlwaysUnfold
        {
            get
            {
                return this.pipeAlwaysUnfoldField;
            }
            set
            {
                this.pipeAlwaysUnfoldField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayImplementLowerTime implementLowerTime
        {
            get
            {
                return this.implementLowerTimeField;
            }
            set
            {
                this.implementLowerTimeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySiloSelectedFillTypeShovelModeDriver siloSelectedFillTypeShovelModeDriver
        {
            get
            {
                return this.siloSelectedFillTypeShovelModeDriverField;
            }
            set
            {
                this.siloSelectedFillTypeShovelModeDriverField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayKeepCurrentSteering keepCurrentSteering
        {
            get
            {
                return this.keepCurrentSteeringField;
            }
            set
            {
                this.keepCurrentSteeringField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayFollowAtFillLevel followAtFillLevel
        {
            get
            {
                return this.followAtFillLevelField;
            }
            set
            {
                this.followAtFillLevelField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayStrawSwath strawSwath
        {
            get
            {
                return this.strawSwathField;
            }
            set
            {
                this.strawSwathField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayShovelStopAndGo shovelStopAndGo
        {
            get
            {
                return this.shovelStopAndGoField;
            }
            set
            {
                this.shovelStopAndGoField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayUsePathfindingInTurns usePathfindingInTurns
        {
            get
            {
                return this.usePathfindingInTurnsField;
            }
            set
            {
                this.usePathfindingInTurnsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayAugerPipeToolPositions augerPipeToolPositions
        {
            get
            {
                return this.augerPipeToolPositionsField;
            }
            set
            {
                this.augerPipeToolPositionsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySaveFuelOption saveFuelOption
        {
            get
            {
                return this.saveFuelOptionField;
            }
            set
            {
                this.saveFuelOptionField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayOppositeTurnMode oppositeTurnMode
        {
            get
            {
                return this.oppositeTurnModeField;
            }
            set
            {
                this.oppositeTurnModeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayBunkerSpeed bunkerSpeed
        {
            get
            {
                return this.bunkerSpeedField;
            }
            set
            {
                this.bunkerSpeedField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayReverseSpeed reverseSpeed
        {
            get
            {
                return this.reverseSpeedField;
            }
            set
            {
                this.reverseSpeedField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayShovelModeAIDriverTriggerHandlerIsActive shovelModeAIDriverTriggerHandlerIsActive
        {
            get
            {
                return this.shovelModeAIDriverTriggerHandlerIsActiveField;
            }
            set
            {
                this.shovelModeAIDriverTriggerHandlerIsActiveField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySiloSelectedFillTypeFieldSupplyDriver siloSelectedFillTypeFieldSupplyDriver
        {
            get
            {
                return this.siloSelectedFillTypeFieldSupplyDriverField;
            }
            set
            {
                this.siloSelectedFillTypeFieldSupplyDriverField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayDriveOnAtFillLevel driveOnAtFillLevel
        {
            get
            {
                return this.driveOnAtFillLevelField;
            }
            set
            {
                this.driveOnAtFillLevelField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayAllowReverseForPathfindingInTurns allowReverseForPathfindingInTurns
        {
            get
            {
                return this.allowReverseForPathfindingInTurnsField;
            }
            set
            {
                this.allowReverseForPathfindingInTurnsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayEnableVisualWaypointsTemporary enableVisualWaypointsTemporary
        {
            get
            {
                return this.enableVisualWaypointsTemporaryField;
            }
            set
            {
                this.enableVisualWaypointsTemporaryField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayRidgeMarkersAutomatic ridgeMarkersAutomatic
        {
            get
            {
                return this.ridgeMarkersAutomaticField;
            }
            set
            {
                this.ridgeMarkersAutomaticField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayCombineWantsCourseplayer combineWantsCourseplayer
        {
            get
            {
                return this.combineWantsCourseplayerField;
            }
            set
            {
                this.combineWantsCourseplayerField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayToolOffsetZ toolOffsetZ
        {
            get
            {
                return this.toolOffsetZField;
            }
            set
            {
                this.toolOffsetZField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayStopForUnload stopForUnload
        {
            get
            {
                return this.stopForUnloadField;
            }
            set
            {
                this.stopForUnloadField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayUseRealisticDriving useRealisticDriving
        {
            get
            {
                return this.useRealisticDrivingField;
            }
            set
            {
                this.useRealisticDrivingField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayStartingPoint startingPoint
        {
            get
            {
                return this.startingPointField;
            }
            set
            {
                this.startingPointField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayTurnSpeed turnSpeed
        {
            get
            {
                return this.turnSpeedField;
            }
            set
            {
                this.turnSpeedField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayReturnToFirstPoint returnToFirstPoint
        {
            get
            {
                return this.returnToFirstPointField;
            }
            set
            {
                this.returnToFirstPointField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayAutoDriveMode autoDriveMode
        {
            get
            {
                return this.autoDriveModeField;
            }
            set
            {
                this.autoDriveModeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayStopAtEnd stopAtEnd
        {
            get
            {
                return this.stopAtEndField;
            }
            set
            {
                this.stopAtEndField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayImplementRaiseTime implementRaiseTime
        {
            get
            {
                return this.implementRaiseTimeField;
            }
            set
            {
                this.implementRaiseTimeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayLevelCompactShieldHeight levelCompactShieldHeight
        {
            get
            {
                return this.levelCompactShieldHeightField;
            }
            set
            {
                this.levelCompactShieldHeightField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayFoldImplementAtEnd foldImplementAtEnd
        {
            get
            {
                return this.foldImplementAtEndField;
            }
            set
            {
                this.foldImplementAtEndField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayAllwaysSearchFuel allwaysSearchFuel
        {
            get
            {
                return this.allwaysSearchFuelField;
            }
            set
            {
                this.allwaysSearchFuelField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayConvoyActive convoyActive
        {
            get
            {
                return this.convoyActiveField;
            }
            set
            {
                this.convoyActiveField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayToolOffsetX toolOffsetX
        {
            get
            {
                return this.toolOffsetXField;
            }
            set
            {
                this.toolOffsetXField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayMoveOnAtFillLevel moveOnAtFillLevel
        {
            get
            {
                return this.moveOnAtFillLevelField;
            }
            set
            {
                this.moveOnAtFillLevelField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySelfUnload selfUnload
        {
            get
            {
                return this.selfUnloadField;
            }
            set
            {
                this.selfUnloadField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayFrontloaderToolPositions frontloaderToolPositions
        {
            get
            {
                return this.frontloaderToolPositionsField;
            }
            set
            {
                this.frontloaderToolPositionsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayForcedToStop forcedToStop
        {
            get
            {
                return this.forcedToStopField;
            }
            set
            {
                this.forcedToStopField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySearchCombineOnField searchCombineOnField
        {
            get
            {
                return this.searchCombineOnFieldField;
            }
            set
            {
                this.searchCombineOnFieldField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayConvoyMinDistance convoyMinDistance
        {
            get
            {
                return this.convoyMinDistanceField;
            }
            set
            {
                this.convoyMinDistanceField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayLevelCompactMode levelCompactMode
        {
            get
            {
                return this.levelCompactModeField;
            }
            set
            {
                this.levelCompactModeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayAllowUnloadOnFirstHeadland allowUnloadOnFirstHeadland
        {
            get
            {
                return this.allowUnloadOnFirstHeadlandField;
            }
            set
            {
                this.allowUnloadOnFirstHeadlandField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayBaleCollectionField baleCollectionField
        {
            get
            {
                return this.baleCollectionFieldField;
            }
            set
            {
                this.baleCollectionFieldField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySiloSelectedFillTypeGrainTransportDriver siloSelectedFillTypeGrainTransportDriver
        {
            get
            {
                return this.siloSelectedFillTypeGrainTransportDriverField;
            }
            set
            {
                this.siloSelectedFillTypeGrainTransportDriverField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySiloSelectedFillTypeFillableFieldWorkDriver siloSelectedFillTypeFillableFieldWorkDriver
        {
            get
            {
                return this.siloSelectedFillTypeFillableFieldWorkDriverField;
            }
            set
            {
                this.siloSelectedFillTypeFillableFieldWorkDriverField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayTurnOnField turnOnField
        {
            get
            {
                return this.turnOnFieldField;
            }
            set
            {
                this.turnOnFieldField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayLevelCompactSearchRadius levelCompactSearchRadius
        {
            get
            {
                return this.levelCompactSearchRadiusField;
            }
            set
            {
                this.levelCompactSearchRadiusField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayDriveUnloadNow driveUnloadNow
        {
            get
            {
                return this.driveUnloadNowField;
            }
            set
            {
                this.driveUnloadNowField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayStreetSpeed streetSpeed
        {
            get
            {
                return this.streetSpeedField;
            }
            set
            {
                this.streetSpeedField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayRefillUntilPct refillUntilPct
        {
            get
            {
                return this.refillUntilPctField;
            }
            set
            {
                this.refillUntilPctField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayUseAITurns useAITurns
        {
            get
            {
                return this.useAITurnsField;
            }
            set
            {
                this.useAITurnsField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayLevelCompactSiloTyp levelCompactSiloTyp
        {
            get
            {
                return this.levelCompactSiloTypField;
            }
            set
            {
                this.levelCompactSiloTypField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayWarningLightsMode warningLightsMode
        {
            get
            {
                return this.warningLightsModeField;
            }
            set
            {
                this.warningLightsModeField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayShowVisualWaypointsCrossPoint showVisualWaypointsCrossPoint
        {
            get
            {
                return this.showVisualWaypointsCrossPointField;
            }
            set
            {
                this.showVisualWaypointsCrossPointField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayUseRecordingSpeed useRecordingSpeed
        {
            get
            {
                return this.useRecordingSpeedField;
            }
            set
            {
                this.useRecordingSpeedField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySelectedCombineToUnload selectedCombineToUnload
        {
            get
            {
                return this.selectedCombineToUnloadField;
            }
            set
            {
                this.selectedCombineToUnloadField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplayFieldSpeed fieldSpeed
        {
            get
            {
                return this.fieldSpeedField;
            }
            set
            {
                this.fieldSpeedField = value;
            }
        }

        /// <remarks/>
        public vehiclesVehicleCourseplaySowingMachineFertilizerEnabled sowingMachineFertilizerEnabled
        {
            get
            {
                return this.sowingMachineFertilizerEnabledField;
            }
            set
            {
                this.sowingMachineFertilizerEnabledField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayBasics
    {

        private byte aiModeField;

        private string coursesField;

        private byte waitTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte aiMode
        {
            get
            {
                return this.aiModeField;
            }
            set
            {
                this.aiModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string courses
        {
            get
            {
                return this.coursesField;
            }
            set
            {
                this.coursesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte waitTime
        {
            get
            {
                return this.waitTimeField;
            }
            set
            {
                this.waitTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayHUD
    {

        private bool showHudField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool showHud
        {
            get
            {
                return this.showHudField;
            }
            set
            {
                this.showHudField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayCombi
    {

        private decimal tipperOffsetField;

        private decimal combineOffsetField;

        private bool combineOffsetAutoModeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal tipperOffset
        {
            get
            {
                return this.tipperOffsetField;
            }
            set
            {
                this.tipperOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal combineOffset
        {
            get
            {
                return this.combineOffsetField;
            }
            set
            {
                this.combineOffsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool combineOffsetAutoMode
        {
            get
            {
                return this.combineOffsetAutoModeField;
            }
            set
            {
                this.combineOffsetAutoModeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayDriving
    {

        private byte turnDiameterField;

        private bool turnDiameterAutoModeField;

        private bool alignmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte turnDiameter
        {
            get
            {
                return this.turnDiameterField;
            }
            set
            {
                this.turnDiameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool turnDiameterAutoMode
        {
            get
            {
                return this.turnDiameterAutoModeField;
            }
            set
            {
                this.turnDiameterAutoModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayFieldWork
    {

        private decimal workWidthField;

        private string offsetDataField;

        private byte abortWorkField;

        private decimal manualWorkWidthField;

        private decimal lastValidTipDistanceField;

        private bool hasSavedPositionField;

        private decimal savedPositionXField;

        private decimal savedPositionZField;

        private decimal savedFieldNumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal workWidth
        {
            get
            {
                return this.workWidthField;
            }
            set
            {
                this.workWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string offsetData
        {
            get
            {
                return this.offsetDataField;
            }
            set
            {
                this.offsetDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte abortWork
        {
            get
            {
                return this.abortWorkField;
            }
            set
            {
                this.abortWorkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal manualWorkWidth
        {
            get
            {
                return this.manualWorkWidthField;
            }
            set
            {
                this.manualWorkWidthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal lastValidTipDistance
        {
            get
            {
                return this.lastValidTipDistanceField;
            }
            set
            {
                this.lastValidTipDistanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasSavedPosition
        {
            get
            {
                return this.hasSavedPositionField;
            }
            set
            {
                this.hasSavedPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal savedPositionX
        {
            get
            {
                return this.savedPositionXField;
            }
            set
            {
                this.savedPositionXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal savedPositionZ
        {
            get
            {
                return this.savedPositionZField;
            }
            set
            {
                this.savedPositionZField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal savedFieldNum
        {
            get
            {
                return this.savedFieldNumField;
            }
            set
            {
                this.savedFieldNumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayShowVisualWaypoints
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplaySeparateFillTypeLoading
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayEnableOpenHudWithMouseVehicle
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayAutomaticCoverHandling
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplaySymmetricLaneChange
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayLevelCompactSearchOnlyAutomatedDriver
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayDriverPriorityUseFillLevel
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayConvoyMaxDistance
    {

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort value
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
    public partial class vehiclesVehicleCourseplayPipeAlwaysUnfold
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayImplementLowerTime
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplaySiloSelectedFillTypeShovelModeDriver
    {

        private byte sizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayKeepCurrentSteering
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayFollowAtFillLevel
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayStrawSwath
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayShovelStopAndGo
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayUsePathfindingInTurns
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayAugerPipeToolPositions
    {

        private bool hasPositionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasPositions
        {
            get
            {
                return this.hasPositionsField;
            }
            set
            {
                this.hasPositionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplaySaveFuelOption
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayOppositeTurnMode
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayBunkerSpeed
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayReverseSpeed
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayShovelModeAIDriverTriggerHandlerIsActive
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplaySiloSelectedFillTypeFieldSupplyDriver
    {

        private byte sizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayDriveOnAtFillLevel
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayAllowReverseForPathfindingInTurns
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayEnableVisualWaypointsTemporary
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayRidgeMarkersAutomatic
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayCombineWantsCourseplayer
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayToolOffsetZ
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    public partial class vehiclesVehicleCourseplayStopForUnload
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayUseRealisticDriving
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayStartingPoint
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayTurnSpeed
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayReturnToFirstPoint
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayAutoDriveMode
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayStopAtEnd
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayImplementRaiseTime
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayLevelCompactShieldHeight
    {

        private sbyte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte value
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
    public partial class vehiclesVehicleCourseplayFoldImplementAtEnd
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayAllwaysSearchFuel
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayConvoyActive
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayToolOffsetX
    {

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal value
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
    public partial class vehiclesVehicleCourseplayMoveOnAtFillLevel
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplaySelfUnload
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayFrontloaderToolPositions
    {

        private bool hasPositionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasPositions
        {
            get
            {
                return this.hasPositionsField;
            }
            set
            {
                this.hasPositionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayForcedToStop
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplaySearchCombineOnField
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayConvoyMinDistance
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayLevelCompactMode
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayAllowUnloadOnFirstHeadland
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayBaleCollectionField
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplaySiloSelectedFillTypeGrainTransportDriver
    {

        private byte sizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplaySiloSelectedFillTypeFillableFieldWorkDriver
    {

        private byte sizeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayTurnOnField
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayLevelCompactSearchRadius
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayDriveUnloadNow
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayStreetSpeed
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayRefillUntilPct
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayUseAITurns
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayLevelCompactSiloTyp
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayWarningLightsMode
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplayShowVisualWaypointsCrossPoint
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayUseRecordingSpeed
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplaySelectedCombineToUnload
    {

        private byte combineIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte combineId
        {
            get
            {
                return this.combineIdField;
            }
            set
            {
                this.combineIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCourseplayFieldSpeed
    {

        private byte valueField;

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
    public partial class vehiclesVehicleCourseplaySowingMachineFertilizerEnabled
    {

        private bool activeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCover
    {

        private byte stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCylindered
    {

        private vehiclesVehicleCylinderedMovingTool[] movingToolField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "movingTool" )]
        public vehiclesVehicleCylinderedMovingTool[] movingTool
        {
            get
            {
                return this.movingToolField;
            }
            set
            {
                this.movingToolField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleCylinderedMovingTool
    {

        private decimal translationField;

        private bool translationFieldSpecified;

        private decimal rotationField;

        private bool rotationFieldSpecified;

        private decimal animationTimeField;

        private bool animationTimeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal translation
        {
            get
            {
                return this.translationField;
            }
            set
            {
                this.translationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool translationSpecified
        {
            get
            {
                return this.translationFieldSpecified;
            }
            set
            {
                this.translationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal rotation
        {
            get
            {
                return this.rotationField;
            }
            set
            {
                this.rotationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rotationSpecified
        {
            get
            {
                return this.rotationFieldSpecified;
            }
            set
            {
                this.rotationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal animationTime
        {
            get
            {
                return this.animationTimeField;
            }
            set
            {
                this.animationTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool animationTimeSpecified
        {
            get
            {
                return this.animationTimeFieldSpecified;
            }
            set
            {
                this.animationTimeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleDrivable
    {

        private decimal cruiseControlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cruiseControl
        {
            get
            {
                return this.cruiseControlField;
            }
            set
            {
                this.cruiseControlField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFillUnit
    {

        private vehiclesVehicleFillUnitUnit[] unitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "unit" )]
        public vehiclesVehicleFillUnitUnit[] unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFillUnitUnit
    {

        private byte indexField;

        private string fillTypeField;

        private decimal fillLevelField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fillLevel
        {
            get
            {
                return this.fillLevelField;
            }
            set
            {
                this.fillLevelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFoldable
    {

        private decimal foldAnimTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal foldAnimTime
        {
            get
            {
                return this.foldAnimTimeField;
            }
            set
            {
                this.foldAnimTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleFollowMe
    {

        private byte distanceField;

        private decimal offsetField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte distance
        {
            get
            {
                return this.distanceField;
            }
            set
            {
                this.distanceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal offset
        {
            get
            {
                return this.offsetField;
            }
            set
            {
                this.offsetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehiclePipe
    {

        private byte stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehiclePlow
    {

        private bool rotationMaxField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool rotationMax
        {
            get
            {
                return this.rotationMaxField;
            }
            set
            {
                this.rotationMaxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleReceivingHopper
    {

        private bool createBoxesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool createBoxes
        {
            get
            {
                return this.createBoxesField;
            }
            set
            {
                this.createBoxesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleSowingMachine
    {

        private string selectedSeedFruitTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string selectedSeedFruitType
        {
            get
            {
                return this.selectedSeedFruitTypeField;
            }
            set
            {
                this.selectedSeedFruitTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleTensionBelts
    {

        private vehiclesVehicleTensionBeltsBelt[] beltField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "belt" )]
        public vehiclesVehicleTensionBeltsBelt[] belt
        {
            get
            {
                return this.beltField;
            }
            set
            {
                this.beltField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleTensionBeltsBelt
    {

        private bool isActiveField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleVarBaleCap
    {

        private ushort baleCapacityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort baleCapacity
        {
            get
            {
                return this.baleCapacityField;
            }
            set
            {
                this.baleCapacityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleWashable
    {

        private vehiclesVehicleWashableDirtNode[] dirtNodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "dirtNode" )]
        public vehiclesVehicleWashableDirtNode[] dirtNode
        {
            get
            {
                return this.dirtNodeField;
            }
            set
            {
                this.dirtNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleWashableDirtNode
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleWearable
    {

        private vehiclesVehicleWearableWearNode wearNodeField;

        /// <remarks/>
        public vehiclesVehicleWearableWearNode wearNode
        {
            get
            {
                return this.wearNodeField;
            }
            set
            {
                this.wearNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleWearableWearNode
    {

        private decimal amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesVehicleWorkMode
    {

        private byte stateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesAttachments
    {

        private vehiclesAttachmentsAttachment attachmentField;

        private byte rootVehicleIdField;

        /// <remarks/>
        public vehiclesAttachmentsAttachment attachment
        {
            get
            {
                return this.attachmentField;
            }
            set
            {
                this.attachmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte rootVehicleId
        {
            get
            {
                return this.rootVehicleIdField;
            }
            set
            {
                this.rootVehicleIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class vehiclesAttachmentsAttachment
    {

        private byte attachmentIdField;

        private byte inputJointDescIndexField;

        private byte jointIndexField;

        private bool moveDownField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte attachmentId
        {
            get
            {
                return this.attachmentIdField;
            }
            set
            {
                this.attachmentIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte inputJointDescIndex
        {
            get
            {
                return this.inputJointDescIndexField;
            }
            set
            {
                this.inputJointDescIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte jointIndex
        {
            get
            {
                return this.jointIndexField;
            }
            set
            {
                this.jointIndexField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool moveDown
        {
            get
            {
                return this.moveDownField;
            }
            set
            {
                this.moveDownField = value;
            }
        }
    }


}
