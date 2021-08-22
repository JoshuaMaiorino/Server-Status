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
    public partial class careerSavegame
    {

        private careerSavegameSettings settingsField;

        private careerSavegameMap mapField;

        private careerSavegameStatistics statisticsField;

        private careerSavegameMapsSplitShapeFileIds mapsSplitShapeFileIdsField;

        private careerSavegameMod[] modField;

        private byte revisionField;

        private bool validField;

        /// <remarks/>
        public careerSavegameSettings settings
        {
            get
            {
                return this.settingsField;
            }
            set
            {
                this.settingsField = value;
            }
        }

        /// <remarks/>
        public careerSavegameMap map
        {
            get
            {
                return this.mapField;
            }
            set
            {
                this.mapField = value;
            }
        }

        /// <remarks/>
        public careerSavegameStatistics statistics
        {
            get
            {
                return this.statisticsField;
            }
            set
            {
                this.statisticsField = value;
            }
        }

        /// <remarks/>
        public careerSavegameMapsSplitShapeFileIds mapsSplitShapeFileIds
        {
            get
            {
                return this.mapsSplitShapeFileIdsField;
            }
            set
            {
                this.mapsSplitShapeFileIdsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "mod" )]
        public careerSavegameMod[] mod
        {
            get
            {
                return this.modField;
            }
            set
            {
                this.modField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte revision
        {
            get
            {
                return this.revisionField;
            }
            set
            {
                this.revisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool valid
        {
            get
            {
                return this.validField;
            }
            set
            {
                this.validField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class careerSavegameSettings
    {

        private string savegameNameField;

        private string mapIdField;

        private string mapTitleField;

        private System.DateTime saveDateField;

        private byte playerModelIndexField;

        private byte playerColorIndexField;

        private byte playerBodyIndexField;

        private byte playerHatIndexField;

        private byte playerAccessoryIndexField;

        private byte playerHairIndexField;

        private byte playerJacketIndexField;

        private string playerNameField;

        private bool resetVehiclesField;

        private bool isPlantWitheringEnabledField;

        private bool trafficEnabledField;

        private bool stopAndGoBrakingField;

        private bool automaticMotorStartEnabledField;

        private bool fruitDestructionField;

        private bool plowingRequiredEnabledField;

        private bool weedsEnabledField;

        private bool limeRequiredField;

        private bool fuelUsageLowField;

        private bool helperBuyFuelField;

        private bool helperBuySeedsField;

        private bool helperBuyFertilizerField;

        private byte helperSlurrySourceField;

        private byte helperManureSourceField;

        private byte densityMapRevisionField;

        private byte terrainLodTextureRevisionField;

        private byte splitShapesRevisionField;

        private byte tipCollisionRevisionField;

        private byte placementCollisionRevisionField;

        private byte mapDensityMapRevisionField;

        private byte mapTerrainLodTextureRevisionField;

        private byte mapSplitShapesRevisionField;

        private byte mapTipCollisionRevisionField;

        private byte mapPlacementCollisionRevisionField;

        private byte difficultyField;

        private byte economicDifficultyField;

        private byte plantGrowthRateField;

        private byte dirtIntervalField;

        private decimal timeScaleField;

        private decimal autoSaveIntervalField;

        /// <remarks/>
        public string savegameName
        {
            get
            {
                return this.savegameNameField;
            }
            set
            {
                this.savegameNameField = value;
            }
        }

        /// <remarks/>
        public string mapId
        {
            get
            {
                return this.mapIdField;
            }
            set
            {
                this.mapIdField = value;
            }
        }

        /// <remarks/>
        public string mapTitle
        {
            get
            {
                return this.mapTitleField;
            }
            set
            {
                this.mapTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( DataType = "date" )]
        public System.DateTime saveDate
        {
            get
            {
                return this.saveDateField;
            }
            set
            {
                this.saveDateField = value;
            }
        }

        /// <remarks/>
        public byte playerModelIndex
        {
            get
            {
                return this.playerModelIndexField;
            }
            set
            {
                this.playerModelIndexField = value;
            }
        }

        /// <remarks/>
        public byte playerColorIndex
        {
            get
            {
                return this.playerColorIndexField;
            }
            set
            {
                this.playerColorIndexField = value;
            }
        }

        /// <remarks/>
        public byte playerBodyIndex
        {
            get
            {
                return this.playerBodyIndexField;
            }
            set
            {
                this.playerBodyIndexField = value;
            }
        }

        /// <remarks/>
        public byte playerHatIndex
        {
            get
            {
                return this.playerHatIndexField;
            }
            set
            {
                this.playerHatIndexField = value;
            }
        }

        /// <remarks/>
        public byte playerAccessoryIndex
        {
            get
            {
                return this.playerAccessoryIndexField;
            }
            set
            {
                this.playerAccessoryIndexField = value;
            }
        }

        /// <remarks/>
        public byte playerHairIndex
        {
            get
            {
                return this.playerHairIndexField;
            }
            set
            {
                this.playerHairIndexField = value;
            }
        }

        /// <remarks/>
        public byte playerJacketIndex
        {
            get
            {
                return this.playerJacketIndexField;
            }
            set
            {
                this.playerJacketIndexField = value;
            }
        }

        /// <remarks/>
        public string playerName
        {
            get
            {
                return this.playerNameField;
            }
            set
            {
                this.playerNameField = value;
            }
        }

        /// <remarks/>
        public bool resetVehicles
        {
            get
            {
                return this.resetVehiclesField;
            }
            set
            {
                this.resetVehiclesField = value;
            }
        }

        /// <remarks/>
        public bool isPlantWitheringEnabled
        {
            get
            {
                return this.isPlantWitheringEnabledField;
            }
            set
            {
                this.isPlantWitheringEnabledField = value;
            }
        }

        /// <remarks/>
        public bool trafficEnabled
        {
            get
            {
                return this.trafficEnabledField;
            }
            set
            {
                this.trafficEnabledField = value;
            }
        }

        /// <remarks/>
        public bool stopAndGoBraking
        {
            get
            {
                return this.stopAndGoBrakingField;
            }
            set
            {
                this.stopAndGoBrakingField = value;
            }
        }

        /// <remarks/>
        public bool automaticMotorStartEnabled
        {
            get
            {
                return this.automaticMotorStartEnabledField;
            }
            set
            {
                this.automaticMotorStartEnabledField = value;
            }
        }

        /// <remarks/>
        public bool fruitDestruction
        {
            get
            {
                return this.fruitDestructionField;
            }
            set
            {
                this.fruitDestructionField = value;
            }
        }

        /// <remarks/>
        public bool plowingRequiredEnabled
        {
            get
            {
                return this.plowingRequiredEnabledField;
            }
            set
            {
                this.plowingRequiredEnabledField = value;
            }
        }

        /// <remarks/>
        public bool weedsEnabled
        {
            get
            {
                return this.weedsEnabledField;
            }
            set
            {
                this.weedsEnabledField = value;
            }
        }

        /// <remarks/>
        public bool limeRequired
        {
            get
            {
                return this.limeRequiredField;
            }
            set
            {
                this.limeRequiredField = value;
            }
        }

        /// <remarks/>
        public bool fuelUsageLow
        {
            get
            {
                return this.fuelUsageLowField;
            }
            set
            {
                this.fuelUsageLowField = value;
            }
        }

        /// <remarks/>
        public bool helperBuyFuel
        {
            get
            {
                return this.helperBuyFuelField;
            }
            set
            {
                this.helperBuyFuelField = value;
            }
        }

        /// <remarks/>
        public bool helperBuySeeds
        {
            get
            {
                return this.helperBuySeedsField;
            }
            set
            {
                this.helperBuySeedsField = value;
            }
        }

        /// <remarks/>
        public bool helperBuyFertilizer
        {
            get
            {
                return this.helperBuyFertilizerField;
            }
            set
            {
                this.helperBuyFertilizerField = value;
            }
        }

        /// <remarks/>
        public byte helperSlurrySource
        {
            get
            {
                return this.helperSlurrySourceField;
            }
            set
            {
                this.helperSlurrySourceField = value;
            }
        }

        /// <remarks/>
        public byte helperManureSource
        {
            get
            {
                return this.helperManureSourceField;
            }
            set
            {
                this.helperManureSourceField = value;
            }
        }

        /// <remarks/>
        public byte densityMapRevision
        {
            get
            {
                return this.densityMapRevisionField;
            }
            set
            {
                this.densityMapRevisionField = value;
            }
        }

        /// <remarks/>
        public byte terrainLodTextureRevision
        {
            get
            {
                return this.terrainLodTextureRevisionField;
            }
            set
            {
                this.terrainLodTextureRevisionField = value;
            }
        }

        /// <remarks/>
        public byte splitShapesRevision
        {
            get
            {
                return this.splitShapesRevisionField;
            }
            set
            {
                this.splitShapesRevisionField = value;
            }
        }

        /// <remarks/>
        public byte tipCollisionRevision
        {
            get
            {
                return this.tipCollisionRevisionField;
            }
            set
            {
                this.tipCollisionRevisionField = value;
            }
        }

        /// <remarks/>
        public byte placementCollisionRevision
        {
            get
            {
                return this.placementCollisionRevisionField;
            }
            set
            {
                this.placementCollisionRevisionField = value;
            }
        }

        /// <remarks/>
        public byte mapDensityMapRevision
        {
            get
            {
                return this.mapDensityMapRevisionField;
            }
            set
            {
                this.mapDensityMapRevisionField = value;
            }
        }

        /// <remarks/>
        public byte mapTerrainLodTextureRevision
        {
            get
            {
                return this.mapTerrainLodTextureRevisionField;
            }
            set
            {
                this.mapTerrainLodTextureRevisionField = value;
            }
        }

        /// <remarks/>
        public byte mapSplitShapesRevision
        {
            get
            {
                return this.mapSplitShapesRevisionField;
            }
            set
            {
                this.mapSplitShapesRevisionField = value;
            }
        }

        /// <remarks/>
        public byte mapTipCollisionRevision
        {
            get
            {
                return this.mapTipCollisionRevisionField;
            }
            set
            {
                this.mapTipCollisionRevisionField = value;
            }
        }

        /// <remarks/>
        public byte mapPlacementCollisionRevision
        {
            get
            {
                return this.mapPlacementCollisionRevisionField;
            }
            set
            {
                this.mapPlacementCollisionRevisionField = value;
            }
        }

        /// <remarks/>
        public byte difficulty
        {
            get
            {
                return this.difficultyField;
            }
            set
            {
                this.difficultyField = value;
            }
        }

        /// <remarks/>
        public byte economicDifficulty
        {
            get
            {
                return this.economicDifficultyField;
            }
            set
            {
                this.economicDifficultyField = value;
            }
        }

        /// <remarks/>
        public byte plantGrowthRate
        {
            get
            {
                return this.plantGrowthRateField;
            }
            set
            {
                this.plantGrowthRateField = value;
            }
        }

        /// <remarks/>
        public byte dirtInterval
        {
            get
            {
                return this.dirtIntervalField;
            }
            set
            {
                this.dirtIntervalField = value;
            }
        }

        /// <remarks/>
        public decimal timeScale
        {
            get
            {
                return this.timeScaleField;
            }
            set
            {
                this.timeScaleField = value;
            }
        }

        /// <remarks/>
        public decimal autoSaveInterval
        {
            get
            {
                return this.autoSaveIntervalField;
            }
            set
            {
                this.autoSaveIntervalField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class careerSavegameMap
    {

        private byte foundHelpIconsField;

        /// <remarks/>
        public byte foundHelpIcons
        {
            get
            {
                return this.foundHelpIconsField;
            }
            set
            {
                this.foundHelpIconsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class careerSavegameStatistics
    {

        private double moneyField;

        private double playTimeField;

        /// <remarks/>
        public double money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public double playTime
        {
            get
            {
                return this.playTimeField;
            }
            set
            {
                this.playTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class careerSavegameMapsSplitShapeFileIds
    {

        private careerSavegameMapsSplitShapeFileIdsID idField;

        private byte countField;

        /// <remarks/>
        public careerSavegameMapsSplitShapeFileIdsID id
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
        public byte count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class careerSavegameMapsSplitShapeFileIdsID
    {

        private byte idField;

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
    public partial class careerSavegameMod
    {

        private string modNameField;

        private string titleField;

        private string versionField;

        private bool requiredField;

        private string fileHashField;

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
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fileHash
        {
            get
            {
                return this.fileHashField;
            }
            set
            {
                this.fileHashField = value;
            }
        }
    }


}
