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
    public partial class items
    {

        private itemsItem[] itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "item" )]
        public itemsItem[] item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItem
    {

        private object[] itemsField;

        private string classNameField;

        private byte idField;

        private string modNameField;

        private string filenameField;

        private string positionField;

        private string rotationField;

        private byte ageField;

        private bool ageFieldSpecified;

        private decimal priceField;

        private bool priceFieldSpecified;

        private byte farmIdField;

        private string mapBoundIdField;

        private decimal globalProductionFactorField;

        private bool globalProductionFactorFieldSpecified;

        private decimal valueScaleField;

        private bool valueScaleFieldSpecified;

        private decimal fillLevelField;

        private bool fillLevelFieldSpecified;

        private decimal wrappingStateField;

        private bool wrappingStateFieldSpecified;

        private string wrappingColorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "animalPenExtension", typeof( itemsItemAnimalPenExtension ) )]
        [System.Xml.Serialization.XmlElementAttribute( "animatedObjects", typeof( itemsItemAnimatedObjects ) )]
        [System.Xml.Serialization.XmlElementAttribute( "bga", typeof( itemsItemBga ) )]
        [System.Xml.Serialization.XmlElementAttribute( "bunkerSilo", typeof( itemsItemBunkerSilo ) )]
        [System.Xml.Serialization.XmlElementAttribute( "module", typeof( itemsItemModule ) )]
        [System.Xml.Serialization.XmlElementAttribute( "sellingStation", typeof( itemsItemSellingStation ) )]
        [System.Xml.Serialization.XmlElementAttribute( "storage", typeof( itemsItemStorage ) )]
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
        public string className
        {
            get
            {
                return this.classNameField;
            }
            set
            {
                this.classNameField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte age
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageSpecified
        {
            get
            {
                return this.ageFieldSpecified;
            }
            set
            {
                this.ageFieldSpecified = value;
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool priceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
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
        public string mapBoundId
        {
            get
            {
                return this.mapBoundIdField;
            }
            set
            {
                this.mapBoundIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal globalProductionFactor
        {
            get
            {
                return this.globalProductionFactorField;
            }
            set
            {
                this.globalProductionFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool globalProductionFactorSpecified
        {
            get
            {
                return this.globalProductionFactorFieldSpecified;
            }
            set
            {
                this.globalProductionFactorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal valueScale
        {
            get
            {
                return this.valueScaleField;
            }
            set
            {
                this.valueScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueScaleSpecified
        {
            get
            {
                return this.valueScaleFieldSpecified;
            }
            set
            {
                this.valueScaleFieldSpecified = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fillLevelSpecified
        {
            get
            {
                return this.fillLevelFieldSpecified;
            }
            set
            {
                this.fillLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal wrappingState
        {
            get
            {
                return this.wrappingStateField;
            }
            set
            {
                this.wrappingStateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool wrappingStateSpecified
        {
            get
            {
                return this.wrappingStateFieldSpecified;
            }
            set
            {
                this.wrappingStateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string wrappingColor
        {
            get
            {
                return this.wrappingColorField;
            }
            set
            {
                this.wrappingColorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemAnimalPenExtension
    {

        private itemsItemAnimalPenExtensionUniversalParts universalPartsField;

        private itemsItemAnimalPenExtensionWaterAddon waterAddonField;

        /// <remarks/>
        public itemsItemAnimalPenExtensionUniversalParts universalParts
        {
            get
            {
                return this.universalPartsField;
            }
            set
            {
                this.universalPartsField = value;
            }
        }

        /// <remarks/>
        public itemsItemAnimalPenExtensionWaterAddon waterAddon
        {
            get
            {
                return this.waterAddonField;
            }
            set
            {
                this.waterAddonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemAnimalPenExtensionUniversalParts
    {

        private itemsItemAnimalPenExtensionUniversalPartsWaterAddonPart[] waterAddonPartField;

        private itemsItemAnimalPenExtensionUniversalPartsMilkAddonPart milkAddonPartField;

        private byte versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "waterAddonPart" )]
        public itemsItemAnimalPenExtensionUniversalPartsWaterAddonPart[] waterAddonPart
        {
            get
            {
                return this.waterAddonPartField;
            }
            set
            {
                this.waterAddonPartField = value;
            }
        }

        /// <remarks/>
        public itemsItemAnimalPenExtensionUniversalPartsMilkAddonPart milkAddonPart
        {
            get
            {
                return this.milkAddonPartField;
            }
            set
            {
                this.milkAddonPartField = value;
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
    public partial class itemsItemAnimalPenExtensionUniversalPartsWaterAddonPart
    {

        private string positionField;

        private decimal rotationField;

        private string scaleField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scale
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
    public partial class itemsItemAnimalPenExtensionUniversalPartsMilkAddonPart
    {

        private string positionField;

        private decimal rotationField;

        private string scaleField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scale
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
    public partial class itemsItemAnimalPenExtensionWaterAddon
    {

        private byte buildHourField;

        private bool hasBeenPurchasedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte buildHour
        {
            get
            {
                return this.buildHourField;
            }
            set
            {
                this.buildHourField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool hasBeenPurchased
        {
            get
            {
                return this.hasBeenPurchasedField;
            }
            set
            {
                this.hasBeenPurchasedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemAnimatedObjects
    {

        private itemsItemAnimatedObjectsAnimatedObject[] animatedObjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "animatedObject" )]
        public itemsItemAnimatedObjectsAnimatedObject[] animatedObject
        {
            get
            {
                return this.animatedObjectField;
            }
            set
            {
                this.animatedObjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemAnimatedObjectsAnimatedObject
    {

        private decimal timeField;

        private byte directionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte direction
        {
            get
            {
                return this.directionField;
            }
            set
            {
                this.directionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemBga
    {

        private itemsItemBgaDigestateSilo digestateSiloField;

        private itemsItemBgaSlot[] slotField;

        private decimal moneyField;

        /// <remarks/>
        public itemsItemBgaDigestateSilo digestateSilo
        {
            get
            {
                return this.digestateSiloField;
            }
            set
            {
                this.digestateSiloField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "slot" )]
        public itemsItemBgaSlot[] slot
        {
            get
            {
                return this.slotField;
            }
            set
            {
                this.slotField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemBgaDigestateSilo
    {

        private itemsItemBgaDigestateSiloStorage storageField;

        /// <remarks/>
        public itemsItemBgaDigestateSiloStorage storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemBgaDigestateSiloStorage
    {

        private itemsItemBgaDigestateSiloStorageNode nodeField;

        private byte indexField;

        private byte farmIdField;

        /// <remarks/>
        public itemsItemBgaDigestateSiloStorageNode node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

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
    public partial class itemsItemBgaDigestateSiloStorageNode
    {

        private string fillTypeField;

        private decimal fillLevelField;

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
    public partial class itemsItemBgaSlot
    {

        private itemsItemBgaSlotFillType[] fillTypeField;

        private byte indexField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "fillType" )]
        public itemsItemBgaSlotFillType[] fillType
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemBgaSlotFillType
    {

        private string fillTypeField;

        private decimal fillLevelField;

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
    public partial class itemsItemBunkerSilo
    {

        private byte indexField;

        private byte stateField;

        private decimal fillLevelField;

        private decimal compactedFillLevelField;

        private decimal fermentingTimeField;

        private bool openedAtFrontField;

        private bool openedAtBackField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal compactedFillLevel
        {
            get
            {
                return this.compactedFillLevelField;
            }
            set
            {
                this.compactedFillLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal fermentingTime
        {
            get
            {
                return this.fermentingTimeField;
            }
            set
            {
                this.fermentingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool openedAtFront
        {
            get
            {
                return this.openedAtFrontField;
            }
            set
            {
                this.openedAtFrontField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool openedAtBack
        {
            get
            {
                return this.openedAtBackField;
            }
            set
            {
                this.openedAtBackField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemModule
    {

        private itemsItemModuleFillLevel[] fillLevelField;

        private itemsItemModuleAnimal[] animalField;

        private itemsItemModuleBreeding[] breedingField;

        private string nameField;

        private decimal fillCapacityField;

        private decimal cleanlinessFactorField;

        private bool cleanlinessFactorFieldSpecified;

        private decimal foodToDropField;

        private bool foodToDropFieldSpecified;

        private decimal palletFillDeltaField;

        private bool palletFillDeltaFieldSpecified;

        private decimal manureToDropField;

        private bool manureToDropFieldSpecified;

        private decimal manureToRemoveField;

        private bool manureToRemoveFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "fillLevel" )]
        public itemsItemModuleFillLevel[] fillLevel
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "animal" )]
        public itemsItemModuleAnimal[] animal
        {
            get
            {
                return this.animalField;
            }
            set
            {
                this.animalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "breeding" )]
        public itemsItemModuleBreeding[] breeding
        {
            get
            {
                return this.breedingField;
            }
            set
            {
                this.breedingField = value;
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
        public decimal fillCapacity
        {
            get
            {
                return this.fillCapacityField;
            }
            set
            {
                this.fillCapacityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal cleanlinessFactor
        {
            get
            {
                return this.cleanlinessFactorField;
            }
            set
            {
                this.cleanlinessFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool cleanlinessFactorSpecified
        {
            get
            {
                return this.cleanlinessFactorFieldSpecified;
            }
            set
            {
                this.cleanlinessFactorFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal foodToDrop
        {
            get
            {
                return this.foodToDropField;
            }
            set
            {
                this.foodToDropField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool foodToDropSpecified
        {
            get
            {
                return this.foodToDropFieldSpecified;
            }
            set
            {
                this.foodToDropFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal palletFillDelta
        {
            get
            {
                return this.palletFillDeltaField;
            }
            set
            {
                this.palletFillDeltaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool palletFillDeltaSpecified
        {
            get
            {
                return this.palletFillDeltaFieldSpecified;
            }
            set
            {
                this.palletFillDeltaFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal manureToDrop
        {
            get
            {
                return this.manureToDropField;
            }
            set
            {
                this.manureToDropField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manureToDropSpecified
        {
            get
            {
                return this.manureToDropFieldSpecified;
            }
            set
            {
                this.manureToDropFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal manureToRemove
        {
            get
            {
                return this.manureToRemoveField;
            }
            set
            {
                this.manureToRemoveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manureToRemoveSpecified
        {
            get
            {
                return this.manureToRemoveFieldSpecified;
            }
            set
            {
                this.manureToRemoveFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemModuleFillLevel
    {

        private string fillTypeField;

        private decimal fillLevelField;

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
    public partial class itemsItemModuleAnimal
    {

        private string fillTypeField;

        private decimal dirtScaleField;

        private bool isRidingActiveField;

        private bool isRidingActiveFieldSpecified;

        private string nameField;

        private decimal fitnessScaleField;

        private bool fitnessScaleFieldSpecified;

        private decimal healthScaleField;

        private bool healthScaleFieldSpecified;

        private decimal ridingTimerField;

        private bool ridingTimerFieldSpecified;

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
        public decimal dirtScale
        {
            get
            {
                return this.dirtScaleField;
            }
            set
            {
                this.dirtScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isRidingActive
        {
            get
            {
                return this.isRidingActiveField;
            }
            set
            {
                this.isRidingActiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRidingActiveSpecified
        {
            get
            {
                return this.isRidingActiveFieldSpecified;
            }
            set
            {
                this.isRidingActiveFieldSpecified = value;
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
        public decimal fitnessScale
        {
            get
            {
                return this.fitnessScaleField;
            }
            set
            {
                this.fitnessScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fitnessScaleSpecified
        {
            get
            {
                return this.fitnessScaleFieldSpecified;
            }
            set
            {
                this.fitnessScaleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal healthScale
        {
            get
            {
                return this.healthScaleField;
            }
            set
            {
                this.healthScaleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool healthScaleSpecified
        {
            get
            {
                return this.healthScaleFieldSpecified;
            }
            set
            {
                this.healthScaleFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal ridingTimer
        {
            get
            {
                return this.ridingTimerField;
            }
            set
            {
                this.ridingTimerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ridingTimerSpecified
        {
            get
            {
                return this.ridingTimerFieldSpecified;
            }
            set
            {
                this.ridingTimerFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemModuleBreeding
    {

        private string fillTypeField;

        private decimal percentageField;

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
        public decimal percentage
        {
            get
            {
                return this.percentageField;
            }
            set
            {
                this.percentageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemSellingStation
    {

        private itemsItemSellingStationStats[] statsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "stats" )]
        public itemsItemSellingStationStats[] stats
        {
            get
            {
                return this.statsField;
            }
            set
            {
                this.statsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemSellingStationStats
    {

        private itemsItemSellingStationStatsCurveBaseCurve curveBaseCurveField;

        private itemsItemSellingStationStatsCurve1 curve1Field;

        private string fillTypeField;

        private decimal receivedField;

        private decimal paidField;

        private byte priceVersionField;

        private bool isInPlateauField;

        private byte nextPlateauNumberField;

        private uint plateauDurationField;

        private decimal meanValueField;

        private decimal plateauTimeField;

        /// <remarks/>
        public itemsItemSellingStationStatsCurveBaseCurve curveBaseCurve
        {
            get
            {
                return this.curveBaseCurveField;
            }
            set
            {
                this.curveBaseCurveField = value;
            }
        }

        /// <remarks/>
        public itemsItemSellingStationStatsCurve1 curve1
        {
            get
            {
                return this.curve1Field;
            }
            set
            {
                this.curve1Field = value;
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
        public decimal received
        {
            get
            {
                return this.receivedField;
            }
            set
            {
                this.receivedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal paid
        {
            get
            {
                return this.paidField;
            }
            set
            {
                this.paidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte priceVersion
        {
            get
            {
                return this.priceVersionField;
            }
            set
            {
                this.priceVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isInPlateau
        {
            get
            {
                return this.isInPlateauField;
            }
            set
            {
                this.isInPlateauField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte nextPlateauNumber
        {
            get
            {
                return this.nextPlateauNumberField;
            }
            set
            {
                this.nextPlateauNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint plateauDuration
        {
            get
            {
                return this.plateauDurationField;
            }
            set
            {
                this.plateauDurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal meanValue
        {
            get
            {
                return this.meanValueField;
            }
            set
            {
                this.meanValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal plateauTime
        {
            get
            {
                return this.plateauTimeField;
            }
            set
            {
                this.plateauTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemSellingStationStatsCurveBaseCurve
    {

        private decimal nominalAmplitudeField;

        private decimal nominalAmplitudeVariationField;

        private byte amplitudeDistributionField;

        private uint nominalPeriodField;

        private uint nominalPeriodVariationField;

        private byte periodDistributionField;

        private decimal amplitudeField;

        private decimal periodField;

        private decimal timeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nominalAmplitude
        {
            get
            {
                return this.nominalAmplitudeField;
            }
            set
            {
                this.nominalAmplitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nominalAmplitudeVariation
        {
            get
            {
                return this.nominalAmplitudeVariationField;
            }
            set
            {
                this.nominalAmplitudeVariationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte amplitudeDistribution
        {
            get
            {
                return this.amplitudeDistributionField;
            }
            set
            {
                this.amplitudeDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nominalPeriod
        {
            get
            {
                return this.nominalPeriodField;
            }
            set
            {
                this.nominalPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nominalPeriodVariation
        {
            get
            {
                return this.nominalPeriodVariationField;
            }
            set
            {
                this.nominalPeriodVariationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte periodDistribution
        {
            get
            {
                return this.periodDistributionField;
            }
            set
            {
                this.periodDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amplitude
        {
            get
            {
                return this.amplitudeField;
            }
            set
            {
                this.amplitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemSellingStationStatsCurve1
    {

        private decimal nominalAmplitudeField;

        private decimal nominalAmplitudeVariationField;

        private byte amplitudeDistributionField;

        private uint nominalPeriodField;

        private uint nominalPeriodVariationField;

        private byte periodDistributionField;

        private decimal amplitudeField;

        private decimal periodField;

        private decimal timeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nominalAmplitude
        {
            get
            {
                return this.nominalAmplitudeField;
            }
            set
            {
                this.nominalAmplitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal nominalAmplitudeVariation
        {
            get
            {
                return this.nominalAmplitudeVariationField;
            }
            set
            {
                this.nominalAmplitudeVariationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte amplitudeDistribution
        {
            get
            {
                return this.amplitudeDistributionField;
            }
            set
            {
                this.amplitudeDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nominalPeriod
        {
            get
            {
                return this.nominalPeriodField;
            }
            set
            {
                this.nominalPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint nominalPeriodVariation
        {
            get
            {
                return this.nominalPeriodVariationField;
            }
            set
            {
                this.nominalPeriodVariationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte periodDistribution
        {
            get
            {
                return this.periodDistributionField;
            }
            set
            {
                this.periodDistributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amplitude
        {
            get
            {
                return this.amplitudeField;
            }
            set
            {
                this.amplitudeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal time
        {
            get
            {
                return this.timeField;
            }
            set
            {
                this.timeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute( "code" )]
    [System.Xml.Serialization.XmlTypeAttribute( AnonymousType = true )]
    public partial class itemsItemStorage
    {

        private itemsItemStorageNode[] nodeField;

        private byte indexField;

        private byte farmIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( "node" )]
        public itemsItemStorageNode[] node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }

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
    public partial class itemsItemStorageNode
    {

        private string fillTypeField;

        private decimal fillLevelField;

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


}
