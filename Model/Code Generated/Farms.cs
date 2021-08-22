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
    public partial class farms
    {

        private farmsFarm[] farmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "farm" )]
        public farmsFarm[] farm
        {
            get
            {
                return this.farmField;
            }
            set
            {
                this.farmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarm
    {

        private farmsFarmPlayer[] playersField;

        private farmsFarmHandTools handToolsField;

        private farmsFarmFarm[] contractingField;

        private farmsFarmStatistics statisticsField;

        private farmsFarmStats[] financesField;

        private byte farmIdField;

        private string nameField;

        private byte colorField;

        private decimal loanField;

        private decimal moneyField;

        private decimal loanAnnualInterestRateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "player", IsNullable = false )]
        public farmsFarmPlayer[] players
        {
            get
            {
                return this.playersField;
            }
            set
            {
                this.playersField = value;
            }
        }

        /// <remarks/>
        public farmsFarmHandTools handTools
        {
            get
            {
                return this.handToolsField;
            }
            set
            {
                this.handToolsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute( "farm", IsNullable = false )]
        public farmsFarmFarm[] contracting
        {
            get
            {
                return this.contractingField;
            }
            set
            {
                this.contractingField = value;
            }
        }

        /// <remarks/>
        public farmsFarmStatistics statistics
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
        [System.Xml.Serialization.XmlArrayItemAttribute( "stats", IsNullable = false )]
        public farmsFarmStats[] finances
        {
            get
            {
                return this.financesField;
            }
            set
            {
                this.financesField = value;
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
        public byte color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal loan
        {
            get
            {
                return this.loanField;
            }
            set
            {
                this.loanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal money
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal loanAnnualInterestRate
        {
            get
            {
                return this.loanAnnualInterestRateField;
            }
            set
            {
                this.loanAnnualInterestRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarmPlayer
    {

        private string uniqueUserIdField;

        private bool farmManagerField;

        private string lastNicknameField;

        private bool buyVehicleField;

        private bool sellVehicleField;

        private bool buyPlaceableField;

        private bool sellPlaceableField;

        private bool manageContractsField;

        private bool tradeAnimalsField;

        private bool createFieldsField;

        private bool landscapingField;

        private bool hireAssistantField;

        private bool resetVehicleField;

        private bool manageRightsField;

        private bool transferMoneyField;

        private bool updateFarmField;

        private bool manageContractingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string uniqueUserId
        {
            get
            {
                return this.uniqueUserIdField;
            }
            set
            {
                this.uniqueUserIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool farmManager
        {
            get
            {
                return this.farmManagerField;
            }
            set
            {
                this.farmManagerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lastNickname
        {
            get
            {
                return this.lastNicknameField;
            }
            set
            {
                this.lastNicknameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool buyVehicle
        {
            get
            {
                return this.buyVehicleField;
            }
            set
            {
                this.buyVehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool sellVehicle
        {
            get
            {
                return this.sellVehicleField;
            }
            set
            {
                this.sellVehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool buyPlaceable
        {
            get
            {
                return this.buyPlaceableField;
            }
            set
            {
                this.buyPlaceableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool sellPlaceable
        {
            get
            {
                return this.sellPlaceableField;
            }
            set
            {
                this.sellPlaceableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool manageContracts
        {
            get
            {
                return this.manageContractsField;
            }
            set
            {
                this.manageContractsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool tradeAnimals
        {
            get
            {
                return this.tradeAnimalsField;
            }
            set
            {
                this.tradeAnimalsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool createFields
        {
            get
            {
                return this.createFieldsField;
            }
            set
            {
                this.createFieldsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool landscaping
        {
            get
            {
                return this.landscapingField;
            }
            set
            {
                this.landscapingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hireAssistant
        {
            get
            {
                return this.hireAssistantField;
            }
            set
            {
                this.hireAssistantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool resetVehicle
        {
            get
            {
                return this.resetVehicleField;
            }
            set
            {
                this.resetVehicleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool manageRights
        {
            get
            {
                return this.manageRightsField;
            }
            set
            {
                this.manageRightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool transferMoney
        {
            get
            {
                return this.transferMoneyField;
            }
            set
            {
                this.transferMoneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool updateFarm
        {
            get
            {
                return this.updateFarmField;
            }
            set
            {
                this.updateFarmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool manageContracting
        {
            get
            {
                return this.manageContractingField;
            }
            set
            {
                this.manageContractingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarmHandTools
    {

        private farmsFarmHandToolsHandTool handToolField;

        /// <remarks/>
        public farmsFarmHandToolsHandTool handTool
        {
            get
            {
                return this.handToolField;
            }
            set
            {
                this.handToolField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarmHandToolsHandTool
    {

        private string filenameField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarmFarm
    {

        private byte farmIdField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarmStatistics
    {

        private decimal traveledDistanceField;

        private decimal fuelUsageField;

        private decimal seedUsageField;

        private decimal sprayUsageField;

        private decimal workedHectaresField;

        private decimal cultivatedHectaresField;

        private decimal sownHectaresField;

        private decimal fertilizedHectaresField;

        private decimal threshedHectaresField;

        private decimal plowedHectaresField;

        private decimal workedTimeField;

        private decimal cultivatedTimeField;

        private decimal sownTimeField;

        private decimal fertilizedTimeField;

        private decimal threshedTimeField;

        private decimal plowedTimeField;

        private byte baleCountField;

        private byte breedCowsCountField;

        private byte breedSheepCountField;

        private ushort breedPigsCountField;

        private byte breedChickenCountField;

        private byte breedHorsesCountField;

        private byte fieldJobMissionCountField;

        private int fieldJobMissionByNPCField;

        private byte transportMissionCountField;

        private decimal revenueField;

        private decimal expensesField;

        private decimal playTimeField;

        private byte plantedTreeCountField;

        private byte cutTreeCountField;

        private decimal woodTonsSoldField;

        private byte treeTypesCutField;

        /// <remarks/>
        public decimal traveledDistance
        {
            get
            {
                return this.traveledDistanceField;
            }
            set
            {
                this.traveledDistanceField = value;
            }
        }

        /// <remarks/>
        public decimal fuelUsage
        {
            get
            {
                return this.fuelUsageField;
            }
            set
            {
                this.fuelUsageField = value;
            }
        }

        /// <remarks/>
        public decimal seedUsage
        {
            get
            {
                return this.seedUsageField;
            }
            set
            {
                this.seedUsageField = value;
            }
        }

        /// <remarks/>
        public decimal sprayUsage
        {
            get
            {
                return this.sprayUsageField;
            }
            set
            {
                this.sprayUsageField = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
        public decimal cultivatedHectares
        {
            get
            {
                return this.cultivatedHectaresField;
            }
            set
            {
                this.cultivatedHectaresField = value;
            }
        }

        /// <remarks/>
        public decimal sownHectares
        {
            get
            {
                return this.sownHectaresField;
            }
            set
            {
                this.sownHectaresField = value;
            }
        }

        /// <remarks/>
        public decimal fertilizedHectares
        {
            get
            {
                return this.fertilizedHectaresField;
            }
            set
            {
                this.fertilizedHectaresField = value;
            }
        }

        /// <remarks/>
        public decimal threshedHectares
        {
            get
            {
                return this.threshedHectaresField;
            }
            set
            {
                this.threshedHectaresField = value;
            }
        }

        /// <remarks/>
        public decimal plowedHectares
        {
            get
            {
                return this.plowedHectaresField;
            }
            set
            {
                this.plowedHectaresField = value;
            }
        }

        /// <remarks/>
        public decimal workedTime
        {
            get
            {
                return this.workedTimeField;
            }
            set
            {
                this.workedTimeField = value;
            }
        }

        /// <remarks/>
        public decimal cultivatedTime
        {
            get
            {
                return this.cultivatedTimeField;
            }
            set
            {
                this.cultivatedTimeField = value;
            }
        }

        /// <remarks/>
        public decimal sownTime
        {
            get
            {
                return this.sownTimeField;
            }
            set
            {
                this.sownTimeField = value;
            }
        }

        /// <remarks/>
        public decimal fertilizedTime
        {
            get
            {
                return this.fertilizedTimeField;
            }
            set
            {
                this.fertilizedTimeField = value;
            }
        }

        /// <remarks/>
        public decimal threshedTime
        {
            get
            {
                return this.threshedTimeField;
            }
            set
            {
                this.threshedTimeField = value;
            }
        }

        /// <remarks/>
        public decimal plowedTime
        {
            get
            {
                return this.plowedTimeField;
            }
            set
            {
                this.plowedTimeField = value;
            }
        }

        /// <remarks/>
        public byte baleCount
        {
            get
            {
                return this.baleCountField;
            }
            set
            {
                this.baleCountField = value;
            }
        }

        /// <remarks/>
        public byte breedCowsCount
        {
            get
            {
                return this.breedCowsCountField;
            }
            set
            {
                this.breedCowsCountField = value;
            }
        }

        /// <remarks/>
        public byte breedSheepCount
        {
            get
            {
                return this.breedSheepCountField;
            }
            set
            {
                this.breedSheepCountField = value;
            }
        }

        /// <remarks/>
        public ushort breedPigsCount
        {
            get
            {
                return this.breedPigsCountField;
            }
            set
            {
                this.breedPigsCountField = value;
            }
        }

        /// <remarks/>
        public byte breedChickenCount
        {
            get
            {
                return this.breedChickenCountField;
            }
            set
            {
                this.breedChickenCountField = value;
            }
        }

        /// <remarks/>
        public byte breedHorsesCount
        {
            get
            {
                return this.breedHorsesCountField;
            }
            set
            {
                this.breedHorsesCountField = value;
            }
        }

        /// <remarks/>
        public byte fieldJobMissionCount
        {
            get
            {
                return this.fieldJobMissionCountField;
            }
            set
            {
                this.fieldJobMissionCountField = value;
            }
        }

        /// <remarks/>
        public int fieldJobMissionByNPC
        {
            get
            {
                return this.fieldJobMissionByNPCField;
            }
            set
            {
                this.fieldJobMissionByNPCField = value;
            }
        }

        /// <remarks/>
        public byte transportMissionCount
        {
            get
            {
                return this.transportMissionCountField;
            }
            set
            {
                this.transportMissionCountField = value;
            }
        }

        /// <remarks/>
        public decimal revenue
        {
            get
            {
                return this.revenueField;
            }
            set
            {
                this.revenueField = value;
            }
        }

        /// <remarks/>
        public decimal expenses
        {
            get
            {
                return this.expensesField;
            }
            set
            {
                this.expensesField = value;
            }
        }

        /// <remarks/>
        public decimal playTime
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

        /// <remarks/>
        public byte plantedTreeCount
        {
            get
            {
                return this.plantedTreeCountField;
            }
            set
            {
                this.plantedTreeCountField = value;
            }
        }

        /// <remarks/>
        public byte cutTreeCount
        {
            get
            {
                return this.cutTreeCountField;
            }
            set
            {
                this.cutTreeCountField = value;
            }
        }

        /// <remarks/>
        public decimal woodTonsSold
        {
            get
            {
                return this.woodTonsSoldField;
            }
            set
            {
                this.woodTonsSoldField = value;
            }
        }

        /// <remarks/>
        public byte treeTypesCut
        {
            get
            {
                return this.treeTypesCutField;
            }
            set
            {
                this.treeTypesCutField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class farmsFarmStats
    {

        private decimal newVehiclesCostField;

        private decimal soldVehiclesField;

        private decimal newAnimalsCostField;

        private decimal soldAnimalsField;

        private decimal constructionCostField;

        private decimal soldBuildingsField;

        private decimal fieldPurchaseField;

        private decimal fieldSellingField;

        private decimal vehicleRunningCostField;

        private decimal vehicleLeasingCostField;

        private decimal animalUpkeepField;

        private decimal propertyMaintenanceField;

        private decimal propertyIncomeField;

        private decimal soldWoodField;

        private decimal soldBalesField;

        private decimal soldWoolField;

        private decimal soldMilkField;

        private decimal purchaseFuelField;

        private decimal purchaseSeedsField;

        private decimal purchaseFertilizerField;

        private decimal purchaseSaplingsField;

        private decimal purchaseWaterField;

        private decimal harvestIncomeField;

        private decimal incomeBgaField;

        private decimal missionIncomeField;

        private decimal wagePaymentField;

        private decimal otherField;

        private decimal loanInterestField;

        private byte dayField;

        /// <remarks/>
        public decimal newVehiclesCost
        {
            get
            {
                return this.newVehiclesCostField;
            }
            set
            {
                this.newVehiclesCostField = value;
            }
        }

        /// <remarks/>
        public decimal soldVehicles
        {
            get
            {
                return this.soldVehiclesField;
            }
            set
            {
                this.soldVehiclesField = value;
            }
        }

        /// <remarks/>
        public decimal newAnimalsCost
        {
            get
            {
                return this.newAnimalsCostField;
            }
            set
            {
                this.newAnimalsCostField = value;
            }
        }

        /// <remarks/>
        public decimal soldAnimals
        {
            get
            {
                return this.soldAnimalsField;
            }
            set
            {
                this.soldAnimalsField = value;
            }
        }

        /// <remarks/>
        public decimal constructionCost
        {
            get
            {
                return this.constructionCostField;
            }
            set
            {
                this.constructionCostField = value;
            }
        }

        /// <remarks/>
        public decimal soldBuildings
        {
            get
            {
                return this.soldBuildingsField;
            }
            set
            {
                this.soldBuildingsField = value;
            }
        }

        /// <remarks/>
        public decimal fieldPurchase
        {
            get
            {
                return this.fieldPurchaseField;
            }
            set
            {
                this.fieldPurchaseField = value;
            }
        }

        /// <remarks/>
        public decimal fieldSelling
        {
            get
            {
                return this.fieldSellingField;
            }
            set
            {
                this.fieldSellingField = value;
            }
        }

        /// <remarks/>
        public decimal vehicleRunningCost
        {
            get
            {
                return this.vehicleRunningCostField;
            }
            set
            {
                this.vehicleRunningCostField = value;
            }
        }

        /// <remarks/>
        public decimal vehicleLeasingCost
        {
            get
            {
                return this.vehicleLeasingCostField;
            }
            set
            {
                this.vehicleLeasingCostField = value;
            }
        }

        /// <remarks/>
        public decimal animalUpkeep
        {
            get
            {
                return this.animalUpkeepField;
            }
            set
            {
                this.animalUpkeepField = value;
            }
        }

        /// <remarks/>
        public decimal propertyMaintenance
        {
            get
            {
                return this.propertyMaintenanceField;
            }
            set
            {
                this.propertyMaintenanceField = value;
            }
        }

        /// <remarks/>
        public decimal propertyIncome
        {
            get
            {
                return this.propertyIncomeField;
            }
            set
            {
                this.propertyIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal soldWood
        {
            get
            {
                return this.soldWoodField;
            }
            set
            {
                this.soldWoodField = value;
            }
        }

        /// <remarks/>
        public decimal soldBales
        {
            get
            {
                return this.soldBalesField;
            }
            set
            {
                this.soldBalesField = value;
            }
        }

        /// <remarks/>
        public decimal soldWool
        {
            get
            {
                return this.soldWoolField;
            }
            set
            {
                this.soldWoolField = value;
            }
        }

        /// <remarks/>
        public decimal soldMilk
        {
            get
            {
                return this.soldMilkField;
            }
            set
            {
                this.soldMilkField = value;
            }
        }

        /// <remarks/>
        public decimal purchaseFuel
        {
            get
            {
                return this.purchaseFuelField;
            }
            set
            {
                this.purchaseFuelField = value;
            }
        }

        /// <remarks/>
        public decimal purchaseSeeds
        {
            get
            {
                return this.purchaseSeedsField;
            }
            set
            {
                this.purchaseSeedsField = value;
            }
        }

        /// <remarks/>
        public decimal purchaseFertilizer
        {
            get
            {
                return this.purchaseFertilizerField;
            }
            set
            {
                this.purchaseFertilizerField = value;
            }
        }

        /// <remarks/>
        public decimal purchaseSaplings
        {
            get
            {
                return this.purchaseSaplingsField;
            }
            set
            {
                this.purchaseSaplingsField = value;
            }
        }

        /// <remarks/>
        public decimal purchaseWater
        {
            get
            {
                return this.purchaseWaterField;
            }
            set
            {
                this.purchaseWaterField = value;
            }
        }

        /// <remarks/>
        public decimal harvestIncome
        {
            get
            {
                return this.harvestIncomeField;
            }
            set
            {
                this.harvestIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal incomeBga
        {
            get
            {
                return this.incomeBgaField;
            }
            set
            {
                this.incomeBgaField = value;
            }
        }

        /// <remarks/>
        public decimal missionIncome
        {
            get
            {
                return this.missionIncomeField;
            }
            set
            {
                this.missionIncomeField = value;
            }
        }

        /// <remarks/>
        public decimal wagePayment
        {
            get
            {
                return this.wagePaymentField;
            }
            set
            {
                this.wagePaymentField = value;
            }
        }

        /// <remarks/>
        public decimal other
        {
            get
            {
                return this.otherField;
            }
            set
            {
                this.otherField = value;
            }
        }

        /// <remarks/>
        public decimal loanInterest
        {
            get
            {
                return this.loanInterestField;
            }
            set
            {
                this.loanInterestField = value;
            }
        }

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
    }


}
