using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrinterProcessingStateDetail {
        [EnumMember(Value = "paused")]
        Paused,
        [EnumMember(Value = "mediaJam")]
        MediaJam,
        [EnumMember(Value = "mediaNeeded")]
        MediaNeeded,
        [EnumMember(Value = "mediaLow")]
        MediaLow,
        [EnumMember(Value = "mediaEmpty")]
        MediaEmpty,
        [EnumMember(Value = "coverOpen")]
        CoverOpen,
        [EnumMember(Value = "interlockOpen")]
        InterlockOpen,
        [EnumMember(Value = "outputTrayMissing")]
        OutputTrayMissing,
        [EnumMember(Value = "outputAreaFull")]
        OutputAreaFull,
        [EnumMember(Value = "markerSupplyLow")]
        MarkerSupplyLow,
        [EnumMember(Value = "markerSupplyEmpty")]
        MarkerSupplyEmpty,
        [EnumMember(Value = "inputTrayMissing")]
        InputTrayMissing,
        [EnumMember(Value = "outputAreaAlmostFull")]
        OutputAreaAlmostFull,
        [EnumMember(Value = "markerWasteAlmostFull")]
        MarkerWasteAlmostFull,
        [EnumMember(Value = "markerWasteFull")]
        MarkerWasteFull,
        [EnumMember(Value = "fuserOverTemp")]
        FuserOverTemp,
        [EnumMember(Value = "fuserUnderTemp")]
        FuserUnderTemp,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "movingToPaused")]
        MovingToPaused,
        [EnumMember(Value = "shutdown")]
        Shutdown,
        [EnumMember(Value = "connectingToDevice")]
        ConnectingToDevice,
        [EnumMember(Value = "timedOut")]
        TimedOut,
        [EnumMember(Value = "stopping")]
        Stopping,
        [EnumMember(Value = "stoppedPartially")]
        StoppedPartially,
        [EnumMember(Value = "tonerLow")]
        TonerLow,
        [EnumMember(Value = "tonerEmpty")]
        TonerEmpty,
        [EnumMember(Value = "spoolAreaFull")]
        SpoolAreaFull,
        [EnumMember(Value = "doorOpen")]
        DoorOpen,
        [EnumMember(Value = "opticalPhotoConductorNearEndOfLife")]
        OpticalPhotoConductorNearEndOfLife,
        [EnumMember(Value = "opticalPhotoConductorLifeOver")]
        OpticalPhotoConductorLifeOver,
        [EnumMember(Value = "developerLow")]
        DeveloperLow,
        [EnumMember(Value = "developerEmpty")]
        DeveloperEmpty,
        [EnumMember(Value = "interpreterResourceUnavailable")]
        InterpreterResourceUnavailable,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "alertRemovalOfBinaryChangeEntry")]
        AlertRemovalOfBinaryChangeEntry,
        [EnumMember(Value = "banderAdded")]
        BanderAdded,
        [EnumMember(Value = "banderAlmostEmpty")]
        BanderAlmostEmpty,
        [EnumMember(Value = "banderAlmostFull")]
        BanderAlmostFull,
        [EnumMember(Value = "banderAtLimit")]
        BanderAtLimit,
        [EnumMember(Value = "banderClosed")]
        BanderClosed,
        [EnumMember(Value = "banderConfigurationChange")]
        BanderConfigurationChange,
        [EnumMember(Value = "banderCoverClosed")]
        BanderCoverClosed,
        [EnumMember(Value = "banderCoverOpen")]
        BanderCoverOpen,
        [EnumMember(Value = "banderEmpty")]
        BanderEmpty,
        [EnumMember(Value = "banderFull")]
        BanderFull,
        [EnumMember(Value = "banderInterlockClosed")]
        BanderInterlockClosed,
        [EnumMember(Value = "banderInterlockOpen")]
        BanderInterlockOpen,
        [EnumMember(Value = "banderJam")]
        BanderJam,
        [EnumMember(Value = "banderLifeAlmostOver")]
        BanderLifeAlmostOver,
        [EnumMember(Value = "banderLifeOver")]
        BanderLifeOver,
        [EnumMember(Value = "banderMemoryExhausted")]
        BanderMemoryExhausted,
        [EnumMember(Value = "banderMissing")]
        BanderMissing,
        [EnumMember(Value = "banderMotorFailure")]
        BanderMotorFailure,
        [EnumMember(Value = "banderNearLimit")]
        BanderNearLimit,
        [EnumMember(Value = "banderOffline")]
        BanderOffline,
        [EnumMember(Value = "banderOpened")]
        BanderOpened,
        [EnumMember(Value = "banderOverTemperature")]
        BanderOverTemperature,
        [EnumMember(Value = "banderPowerSaver")]
        BanderPowerSaver,
        [EnumMember(Value = "banderRecoverableFailure")]
        BanderRecoverableFailure,
        [EnumMember(Value = "banderRecoverableStorage")]
        BanderRecoverableStorage,
        [EnumMember(Value = "banderRemoved")]
        BanderRemoved,
        [EnumMember(Value = "banderResourceAdded")]
        BanderResourceAdded,
        [EnumMember(Value = "banderResourceRemoved")]
        BanderResourceRemoved,
        [EnumMember(Value = "banderThermistorFailure")]
        BanderThermistorFailure,
        [EnumMember(Value = "banderTimingFailure")]
        BanderTimingFailure,
        [EnumMember(Value = "banderTurnedOff")]
        BanderTurnedOff,
        [EnumMember(Value = "banderTurnedOn")]
        BanderTurnedOn,
        [EnumMember(Value = "banderUnderTemperature")]
        BanderUnderTemperature,
        [EnumMember(Value = "banderUnrecoverableFailure")]
        BanderUnrecoverableFailure,
        [EnumMember(Value = "banderUnrecoverableStorageError")]
        BanderUnrecoverableStorageError,
        [EnumMember(Value = "banderWarmingUp")]
        BanderWarmingUp,
        [EnumMember(Value = "binderAdded")]
        BinderAdded,
        [EnumMember(Value = "binderAlmostEmpty")]
        BinderAlmostEmpty,
        [EnumMember(Value = "binderAlmostFull")]
        BinderAlmostFull,
        [EnumMember(Value = "binderAtLimit")]
        BinderAtLimit,
        [EnumMember(Value = "binderClosed")]
        BinderClosed,
        [EnumMember(Value = "binderConfigurationChange")]
        BinderConfigurationChange,
        [EnumMember(Value = "binderCoverClosed")]
        BinderCoverClosed,
        [EnumMember(Value = "binderCoverOpen")]
        BinderCoverOpen,
        [EnumMember(Value = "binderEmpty")]
        BinderEmpty,
        [EnumMember(Value = "binderFull")]
        BinderFull,
        [EnumMember(Value = "binderInterlockClosed")]
        BinderInterlockClosed,
        [EnumMember(Value = "binderInterlockOpen")]
        BinderInterlockOpen,
        [EnumMember(Value = "binderJam")]
        BinderJam,
        [EnumMember(Value = "binderLifeAlmostOver")]
        BinderLifeAlmostOver,
        [EnumMember(Value = "binderLifeOver")]
        BinderLifeOver,
        [EnumMember(Value = "binderMemoryExhausted")]
        BinderMemoryExhausted,
        [EnumMember(Value = "binderMissing")]
        BinderMissing,
        [EnumMember(Value = "binderMotorFailure")]
        BinderMotorFailure,
        [EnumMember(Value = "binderNearLimit")]
        BinderNearLimit,
        [EnumMember(Value = "binderOffline")]
        BinderOffline,
        [EnumMember(Value = "binderOpened")]
        BinderOpened,
        [EnumMember(Value = "binderOverTemperature")]
        BinderOverTemperature,
        [EnumMember(Value = "binderPowerSaver")]
        BinderPowerSaver,
        [EnumMember(Value = "binderRecoverableFailure")]
        BinderRecoverableFailure,
        [EnumMember(Value = "binderRecoverableStorage")]
        BinderRecoverableStorage,
        [EnumMember(Value = "binderRemoved")]
        BinderRemoved,
        [EnumMember(Value = "binderResourceAdded")]
        BinderResourceAdded,
        [EnumMember(Value = "binderResourceRemoved")]
        BinderResourceRemoved,
        [EnumMember(Value = "binderThermistorFailure")]
        BinderThermistorFailure,
        [EnumMember(Value = "binderTimingFailure")]
        BinderTimingFailure,
        [EnumMember(Value = "binderTurnedOff")]
        BinderTurnedOff,
        [EnumMember(Value = "binderTurnedOn")]
        BinderTurnedOn,
        [EnumMember(Value = "binderUnderTemperature")]
        BinderUnderTemperature,
        [EnumMember(Value = "binderUnrecoverableFailure")]
        BinderUnrecoverableFailure,
        [EnumMember(Value = "binderUnrecoverableStorageError")]
        BinderUnrecoverableStorageError,
        [EnumMember(Value = "binderWarmingUp")]
        BinderWarmingUp,
        [EnumMember(Value = "cameraFailure")]
        CameraFailure,
        [EnumMember(Value = "chamberCooling")]
        ChamberCooling,
        [EnumMember(Value = "chamberFailure")]
        ChamberFailure,
        [EnumMember(Value = "chamberHeating")]
        ChamberHeating,
        [EnumMember(Value = "chamberTemperatureHigh")]
        ChamberTemperatureHigh,
        [EnumMember(Value = "chamberTemperatureLow")]
        ChamberTemperatureLow,
        [EnumMember(Value = "cleanerLifeAlmostOver")]
        CleanerLifeAlmostOver,
        [EnumMember(Value = "cleanerLifeOver")]
        CleanerLifeOver,
        [EnumMember(Value = "configurationChange")]
        ConfigurationChange,
        [EnumMember(Value = "deactivated")]
        Deactivated,
        [EnumMember(Value = "deleted")]
        Deleted,
        [EnumMember(Value = "dieCutterAdded")]
        DieCutterAdded,
        [EnumMember(Value = "dieCutterAlmostEmpty")]
        DieCutterAlmostEmpty,
        [EnumMember(Value = "dieCutterAlmostFull")]
        DieCutterAlmostFull,
        [EnumMember(Value = "dieCutterAtLimit")]
        DieCutterAtLimit,
        [EnumMember(Value = "dieCutterClosed")]
        DieCutterClosed,
        [EnumMember(Value = "dieCutterConfigurationChange")]
        DieCutterConfigurationChange,
        [EnumMember(Value = "dieCutterCoverClosed")]
        DieCutterCoverClosed,
        [EnumMember(Value = "dieCutterCoverOpen")]
        DieCutterCoverOpen,
        [EnumMember(Value = "dieCutterEmpty")]
        DieCutterEmpty,
        [EnumMember(Value = "dieCutterFull")]
        DieCutterFull,
        [EnumMember(Value = "dieCutterInterlockClosed")]
        DieCutterInterlockClosed,
        [EnumMember(Value = "dieCutterInterlockOpen")]
        DieCutterInterlockOpen,
        [EnumMember(Value = "dieCutterJam")]
        DieCutterJam,
        [EnumMember(Value = "dieCutterLifeAlmostOver")]
        DieCutterLifeAlmostOver,
        [EnumMember(Value = "dieCutterLifeOver")]
        DieCutterLifeOver,
        [EnumMember(Value = "dieCutterMemoryExhausted")]
        DieCutterMemoryExhausted,
        [EnumMember(Value = "dieCutterMissing")]
        DieCutterMissing,
        [EnumMember(Value = "dieCutterMotorFailure")]
        DieCutterMotorFailure,
        [EnumMember(Value = "dieCutterNearLimit")]
        DieCutterNearLimit,
        [EnumMember(Value = "dieCutterOffline")]
        DieCutterOffline,
        [EnumMember(Value = "dieCutterOpened")]
        DieCutterOpened,
        [EnumMember(Value = "dieCutterOverTemperature")]
        DieCutterOverTemperature,
        [EnumMember(Value = "dieCutterPowerSaver")]
        DieCutterPowerSaver,
        [EnumMember(Value = "dieCutterRecoverableFailure")]
        DieCutterRecoverableFailure,
        [EnumMember(Value = "dieCutterRecoverableStorage")]
        DieCutterRecoverableStorage,
        [EnumMember(Value = "dieCutterRemoved")]
        DieCutterRemoved,
        [EnumMember(Value = "dieCutterResourceAdded")]
        DieCutterResourceAdded,
        [EnumMember(Value = "dieCutterResourceRemoved")]
        DieCutterResourceRemoved,
        [EnumMember(Value = "dieCutterThermistorFailure")]
        DieCutterThermistorFailure,
        [EnumMember(Value = "dieCutterTimingFailure")]
        DieCutterTimingFailure,
        [EnumMember(Value = "dieCutterTurnedOff")]
        DieCutterTurnedOff,
        [EnumMember(Value = "dieCutterTurnedOn")]
        DieCutterTurnedOn,
        [EnumMember(Value = "dieCutterUnderTemperature")]
        DieCutterUnderTemperature,
        [EnumMember(Value = "dieCutterUnrecoverableFailure")]
        DieCutterUnrecoverableFailure,
        [EnumMember(Value = "dieCutterUnrecoverableStorageError")]
        DieCutterUnrecoverableStorageError,
        [EnumMember(Value = "dieCutterWarmingUp")]
        DieCutterWarmingUp,
        [EnumMember(Value = "extruderCooling")]
        ExtruderCooling,
        [EnumMember(Value = "extruderFailure")]
        ExtruderFailure,
        [EnumMember(Value = "extruderHeating")]
        ExtruderHeating,
        [EnumMember(Value = "extruderJam")]
        ExtruderJam,
        [EnumMember(Value = "extruderTemperatureHigh")]
        ExtruderTemperatureHigh,
        [EnumMember(Value = "extruderTemperatureLow")]
        ExtruderTemperatureLow,
        [EnumMember(Value = "fanFailure")]
        FanFailure,
        [EnumMember(Value = "faxModemLifeAlmostOver")]
        FaxModemLifeAlmostOver,
        [EnumMember(Value = "faxModemLifeOver")]
        FaxModemLifeOver,
        [EnumMember(Value = "faxModemMissing")]
        FaxModemMissing,
        [EnumMember(Value = "faxModemTurnedOff")]
        FaxModemTurnedOff,
        [EnumMember(Value = "faxModemTurnedOn")]
        FaxModemTurnedOn,
        [EnumMember(Value = "folderAdded")]
        FolderAdded,
        [EnumMember(Value = "folderAlmostEmpty")]
        FolderAlmostEmpty,
        [EnumMember(Value = "folderAlmostFull")]
        FolderAlmostFull,
        [EnumMember(Value = "folderAtLimit")]
        FolderAtLimit,
        [EnumMember(Value = "folderClosed")]
        FolderClosed,
        [EnumMember(Value = "folderConfigurationChange")]
        FolderConfigurationChange,
        [EnumMember(Value = "folderCoverClosed")]
        FolderCoverClosed,
        [EnumMember(Value = "folderCoverOpen")]
        FolderCoverOpen,
        [EnumMember(Value = "folderEmpty")]
        FolderEmpty,
        [EnumMember(Value = "folderFull")]
        FolderFull,
        [EnumMember(Value = "folderInterlockClosed")]
        FolderInterlockClosed,
        [EnumMember(Value = "folderInterlockOpen")]
        FolderInterlockOpen,
        [EnumMember(Value = "folderJam")]
        FolderJam,
        [EnumMember(Value = "folderLifeAlmostOver")]
        FolderLifeAlmostOver,
        [EnumMember(Value = "folderLifeOver")]
        FolderLifeOver,
        [EnumMember(Value = "folderMemoryExhausted")]
        FolderMemoryExhausted,
        [EnumMember(Value = "folderMissing")]
        FolderMissing,
        [EnumMember(Value = "folderMotorFailure")]
        FolderMotorFailure,
        [EnumMember(Value = "folderNearLimit")]
        FolderNearLimit,
        [EnumMember(Value = "folderOffline")]
        FolderOffline,
        [EnumMember(Value = "folderOpened")]
        FolderOpened,
        [EnumMember(Value = "folderOverTemperature")]
        FolderOverTemperature,
        [EnumMember(Value = "folderPowerSaver")]
        FolderPowerSaver,
        [EnumMember(Value = "folderRecoverableFailure")]
        FolderRecoverableFailure,
        [EnumMember(Value = "folderRecoverableStorage")]
        FolderRecoverableStorage,
        [EnumMember(Value = "folderRemoved")]
        FolderRemoved,
        [EnumMember(Value = "folderResourceAdded")]
        FolderResourceAdded,
        [EnumMember(Value = "folderResourceRemoved")]
        FolderResourceRemoved,
        [EnumMember(Value = "folderThermistorFailure")]
        FolderThermistorFailure,
        [EnumMember(Value = "folderTimingFailure")]
        FolderTimingFailure,
        [EnumMember(Value = "folderTurnedOff")]
        FolderTurnedOff,
        [EnumMember(Value = "folderTurnedOn")]
        FolderTurnedOn,
        [EnumMember(Value = "folderUnderTemperature")]
        FolderUnderTemperature,
        [EnumMember(Value = "folderUnrecoverableFailure")]
        FolderUnrecoverableFailure,
        [EnumMember(Value = "folderUnrecoverableStorageError")]
        FolderUnrecoverableStorageError,
        [EnumMember(Value = "folderWarmingUp")]
        FolderWarmingUp,
        [EnumMember(Value = "hibernate")]
        Hibernate,
        [EnumMember(Value = "holdNewJobs")]
        HoldNewJobs,
        [EnumMember(Value = "identifyPrinterRequested")]
        IdentifyPrinterRequested,
        [EnumMember(Value = "imprinterAdded")]
        ImprinterAdded,
        [EnumMember(Value = "imprinterAlmostEmpty")]
        ImprinterAlmostEmpty,
        [EnumMember(Value = "imprinterAlmostFull")]
        ImprinterAlmostFull,
        [EnumMember(Value = "imprinterAtLimit")]
        ImprinterAtLimit,
        [EnumMember(Value = "imprinterClosed")]
        ImprinterClosed,
        [EnumMember(Value = "imprinterConfigurationChange")]
        ImprinterConfigurationChange,
        [EnumMember(Value = "imprinterCoverClosed")]
        ImprinterCoverClosed,
        [EnumMember(Value = "imprinterCoverOpen")]
        ImprinterCoverOpen,
        [EnumMember(Value = "imprinterEmpty")]
        ImprinterEmpty,
        [EnumMember(Value = "imprinterFull")]
        ImprinterFull,
        [EnumMember(Value = "imprinterInterlockClosed")]
        ImprinterInterlockClosed,
        [EnumMember(Value = "imprinterInterlockOpen")]
        ImprinterInterlockOpen,
        [EnumMember(Value = "imprinterJam")]
        ImprinterJam,
        [EnumMember(Value = "imprinterLifeAlmostOver")]
        ImprinterLifeAlmostOver,
        [EnumMember(Value = "imprinterLifeOver")]
        ImprinterLifeOver,
        [EnumMember(Value = "imprinterMemoryExhausted")]
        ImprinterMemoryExhausted,
        [EnumMember(Value = "imprinterMissing")]
        ImprinterMissing,
        [EnumMember(Value = "imprinterMotorFailure")]
        ImprinterMotorFailure,
        [EnumMember(Value = "imprinterNearLimit")]
        ImprinterNearLimit,
        [EnumMember(Value = "imprinterOffline")]
        ImprinterOffline,
        [EnumMember(Value = "imprinterOpened")]
        ImprinterOpened,
        [EnumMember(Value = "imprinterOverTemperature")]
        ImprinterOverTemperature,
        [EnumMember(Value = "imprinterPowerSaver")]
        ImprinterPowerSaver,
        [EnumMember(Value = "imprinterRecoverableFailure")]
        ImprinterRecoverableFailure,
        [EnumMember(Value = "imprinterRecoverableStorage")]
        ImprinterRecoverableStorage,
        [EnumMember(Value = "imprinterRemoved")]
        ImprinterRemoved,
        [EnumMember(Value = "imprinterResourceAdded")]
        ImprinterResourceAdded,
        [EnumMember(Value = "imprinterResourceRemoved")]
        ImprinterResourceRemoved,
        [EnumMember(Value = "imprinterThermistorFailure")]
        ImprinterThermistorFailure,
        [EnumMember(Value = "imprinterTimingFailure")]
        ImprinterTimingFailure,
        [EnumMember(Value = "imprinterTurnedOff")]
        ImprinterTurnedOff,
        [EnumMember(Value = "imprinterTurnedOn")]
        ImprinterTurnedOn,
        [EnumMember(Value = "imprinterUnderTemperature")]
        ImprinterUnderTemperature,
        [EnumMember(Value = "imprinterUnrecoverableFailure")]
        ImprinterUnrecoverableFailure,
        [EnumMember(Value = "imprinterUnrecoverableStorageError")]
        ImprinterUnrecoverableStorageError,
        [EnumMember(Value = "imprinterWarmingUp")]
        ImprinterWarmingUp,
        [EnumMember(Value = "inputCannotFeedSizeSelected")]
        InputCannotFeedSizeSelected,
        [EnumMember(Value = "inputManualInputRequest")]
        InputManualInputRequest,
        [EnumMember(Value = "inputMediaColorChange")]
        InputMediaColorChange,
        [EnumMember(Value = "inputMediaFormPartsChange")]
        InputMediaFormPartsChange,
        [EnumMember(Value = "inputMediaSizeChange")]
        InputMediaSizeChange,
        [EnumMember(Value = "inputMediaTrayFailure")]
        InputMediaTrayFailure,
        [EnumMember(Value = "inputMediaTrayFeedError")]
        InputMediaTrayFeedError,
        [EnumMember(Value = "inputMediaTrayJam")]
        InputMediaTrayJam,
        [EnumMember(Value = "inputMediaTypeChange")]
        InputMediaTypeChange,
        [EnumMember(Value = "inputMediaWeightChange")]
        InputMediaWeightChange,
        [EnumMember(Value = "inputPickRollerFailure")]
        InputPickRollerFailure,
        [EnumMember(Value = "inputPickRollerLifeOver")]
        InputPickRollerLifeOver,
        [EnumMember(Value = "inputPickRollerLifeWarn")]
        InputPickRollerLifeWarn,
        [EnumMember(Value = "inputPickRollerMissing")]
        InputPickRollerMissing,
        [EnumMember(Value = "inputTrayElevationFailure")]
        InputTrayElevationFailure,
        [EnumMember(Value = "inputTrayPositionFailure")]
        InputTrayPositionFailure,
        [EnumMember(Value = "inserterAdded")]
        InserterAdded,
        [EnumMember(Value = "inserterAlmostEmpty")]
        InserterAlmostEmpty,
        [EnumMember(Value = "inserterAlmostFull")]
        InserterAlmostFull,
        [EnumMember(Value = "inserterAtLimit")]
        InserterAtLimit,
        [EnumMember(Value = "inserterClosed")]
        InserterClosed,
        [EnumMember(Value = "inserterConfigurationChange")]
        InserterConfigurationChange,
        [EnumMember(Value = "inserterCoverClosed")]
        InserterCoverClosed,
        [EnumMember(Value = "inserterCoverOpen")]
        InserterCoverOpen,
        [EnumMember(Value = "inserterEmpty")]
        InserterEmpty,
        [EnumMember(Value = "inserterFull")]
        InserterFull,
        [EnumMember(Value = "inserterInterlockClosed")]
        InserterInterlockClosed,
        [EnumMember(Value = "inserterInterlockOpen")]
        InserterInterlockOpen,
        [EnumMember(Value = "inserterJam")]
        InserterJam,
        [EnumMember(Value = "inserterLifeAlmostOver")]
        InserterLifeAlmostOver,
        [EnumMember(Value = "inserterLifeOver")]
        InserterLifeOver,
        [EnumMember(Value = "inserterMemoryExhausted")]
        InserterMemoryExhausted,
        [EnumMember(Value = "inserterMissing")]
        InserterMissing,
        [EnumMember(Value = "inserterMotorFailure")]
        InserterMotorFailure,
        [EnumMember(Value = "inserterNearLimit")]
        InserterNearLimit,
        [EnumMember(Value = "inserterOffline")]
        InserterOffline,
        [EnumMember(Value = "inserterOpened")]
        InserterOpened,
        [EnumMember(Value = "inserterOverTemperature")]
        InserterOverTemperature,
        [EnumMember(Value = "inserterPowerSaver")]
        InserterPowerSaver,
        [EnumMember(Value = "inserterRecoverableFailure")]
        InserterRecoverableFailure,
        [EnumMember(Value = "inserterRecoverableStorage")]
        InserterRecoverableStorage,
        [EnumMember(Value = "inserterRemoved")]
        InserterRemoved,
        [EnumMember(Value = "inserterResourceAdded")]
        InserterResourceAdded,
        [EnumMember(Value = "inserterResourceRemoved")]
        InserterResourceRemoved,
        [EnumMember(Value = "inserterThermistorFailure")]
        InserterThermistorFailure,
        [EnumMember(Value = "inserterTimingFailure")]
        InserterTimingFailure,
        [EnumMember(Value = "inserterTurnedOff")]
        InserterTurnedOff,
        [EnumMember(Value = "inserterTurnedOn")]
        InserterTurnedOn,
        [EnumMember(Value = "inserterUnderTemperature")]
        InserterUnderTemperature,
        [EnumMember(Value = "inserterUnrecoverableFailure")]
        InserterUnrecoverableFailure,
        [EnumMember(Value = "inserterUnrecoverableStorageError")]
        InserterUnrecoverableStorageError,
        [EnumMember(Value = "inserterWarmingUp")]
        InserterWarmingUp,
        [EnumMember(Value = "interlockClosed")]
        InterlockClosed,
        [EnumMember(Value = "interpreterCartridgeAdded")]
        InterpreterCartridgeAdded,
        [EnumMember(Value = "interpreterCartridgeDeleted")]
        InterpreterCartridgeDeleted,
        [EnumMember(Value = "interpreterComplexPageEncountered")]
        InterpreterComplexPageEncountered,
        [EnumMember(Value = "interpreterMemoryDecrease")]
        InterpreterMemoryDecrease,
        [EnumMember(Value = "interpreterMemoryIncrease")]
        InterpreterMemoryIncrease,
        [EnumMember(Value = "interpreterResourceAdded")]
        InterpreterResourceAdded,
        [EnumMember(Value = "interpreterResourceDeleted")]
        InterpreterResourceDeleted,
        [EnumMember(Value = "lampAtEol")]
        LampAtEol,
        [EnumMember(Value = "lampFailure")]
        LampFailure,
        [EnumMember(Value = "lampNearEol")]
        LampNearEol,
        [EnumMember(Value = "laserAtEol")]
        LaserAtEol,
        [EnumMember(Value = "laserFailure")]
        LaserFailure,
        [EnumMember(Value = "laserNearEol")]
        LaserNearEol,
        [EnumMember(Value = "makeEnvelopeAdded")]
        MakeEnvelopeAdded,
        [EnumMember(Value = "makeEnvelopeAlmostEmpty")]
        MakeEnvelopeAlmostEmpty,
        [EnumMember(Value = "makeEnvelopeAlmostFull")]
        MakeEnvelopeAlmostFull,
        [EnumMember(Value = "makeEnvelopeAtLimit")]
        MakeEnvelopeAtLimit,
        [EnumMember(Value = "makeEnvelopeClosed")]
        MakeEnvelopeClosed,
        [EnumMember(Value = "makeEnvelopeConfigurationChange")]
        MakeEnvelopeConfigurationChange,
        [EnumMember(Value = "makeEnvelopeCoverClosed")]
        MakeEnvelopeCoverClosed,
        [EnumMember(Value = "makeEnvelopeCoverOpen")]
        MakeEnvelopeCoverOpen,
        [EnumMember(Value = "makeEnvelopeEmpty")]
        MakeEnvelopeEmpty,
        [EnumMember(Value = "makeEnvelopeFull")]
        MakeEnvelopeFull,
        [EnumMember(Value = "makeEnvelopeInterlockClosed")]
        MakeEnvelopeInterlockClosed,
        [EnumMember(Value = "makeEnvelopeInterlockOpen")]
        MakeEnvelopeInterlockOpen,
        [EnumMember(Value = "makeEnvelopeJam")]
        MakeEnvelopeJam,
        [EnumMember(Value = "makeEnvelopeLifeAlmostOver")]
        MakeEnvelopeLifeAlmostOver,
        [EnumMember(Value = "makeEnvelopeLifeOver")]
        MakeEnvelopeLifeOver,
        [EnumMember(Value = "makeEnvelopeMemoryExhausted")]
        MakeEnvelopeMemoryExhausted,
        [EnumMember(Value = "makeEnvelopeMissing")]
        MakeEnvelopeMissing,
        [EnumMember(Value = "makeEnvelopeMotorFailure")]
        MakeEnvelopeMotorFailure,
        [EnumMember(Value = "makeEnvelopeNearLimit")]
        MakeEnvelopeNearLimit,
        [EnumMember(Value = "makeEnvelopeOffline")]
        MakeEnvelopeOffline,
        [EnumMember(Value = "makeEnvelopeOpened")]
        MakeEnvelopeOpened,
        [EnumMember(Value = "makeEnvelopeOverTemperature")]
        MakeEnvelopeOverTemperature,
        [EnumMember(Value = "makeEnvelopePowerSaver")]
        MakeEnvelopePowerSaver,
        [EnumMember(Value = "makeEnvelopeRecoverableFailure")]
        MakeEnvelopeRecoverableFailure,
        [EnumMember(Value = "makeEnvelopeRecoverableStorage")]
        MakeEnvelopeRecoverableStorage,
        [EnumMember(Value = "makeEnvelopeRemoved")]
        MakeEnvelopeRemoved,
        [EnumMember(Value = "makeEnvelopeResourceAdded")]
        MakeEnvelopeResourceAdded,
        [EnumMember(Value = "makeEnvelopeResourceRemoved")]
        MakeEnvelopeResourceRemoved,
        [EnumMember(Value = "makeEnvelopeThermistorFailure")]
        MakeEnvelopeThermistorFailure,
        [EnumMember(Value = "makeEnvelopeTimingFailure")]
        MakeEnvelopeTimingFailure,
        [EnumMember(Value = "makeEnvelopeTurnedOff")]
        MakeEnvelopeTurnedOff,
        [EnumMember(Value = "makeEnvelopeTurnedOn")]
        MakeEnvelopeTurnedOn,
        [EnumMember(Value = "makeEnvelopeUnderTemperature")]
        MakeEnvelopeUnderTemperature,
        [EnumMember(Value = "makeEnvelopeUnrecoverableFailure")]
        MakeEnvelopeUnrecoverableFailure,
        [EnumMember(Value = "makeEnvelopeUnrecoverableStorageError")]
        MakeEnvelopeUnrecoverableStorageError,
        [EnumMember(Value = "makeEnvelopeWarmingUp")]
        MakeEnvelopeWarmingUp,
        [EnumMember(Value = "markerAdjustingPrintQuality")]
        MarkerAdjustingPrintQuality,
        [EnumMember(Value = "markerCleanerMissing")]
        MarkerCleanerMissing,
        [EnumMember(Value = "markerDeveloperAlmostEmpty")]
        MarkerDeveloperAlmostEmpty,
        [EnumMember(Value = "markerDeveloperEmpty")]
        MarkerDeveloperEmpty,
        [EnumMember(Value = "markerDeveloperMissing")]
        MarkerDeveloperMissing,
        [EnumMember(Value = "markerFuserMissing")]
        MarkerFuserMissing,
        [EnumMember(Value = "markerFuserThermistorFailure")]
        MarkerFuserThermistorFailure,
        [EnumMember(Value = "markerFuserTimingFailure")]
        MarkerFuserTimingFailure,
        [EnumMember(Value = "markerInkAlmostEmpty")]
        MarkerInkAlmostEmpty,
        [EnumMember(Value = "markerInkEmpty")]
        MarkerInkEmpty,
        [EnumMember(Value = "markerInkMissing")]
        MarkerInkMissing,
        [EnumMember(Value = "markerOpcMissing")]
        MarkerOpcMissing,
        [EnumMember(Value = "markerPrintRibbonAlmostEmpty")]
        MarkerPrintRibbonAlmostEmpty,
        [EnumMember(Value = "markerPrintRibbonEmpty")]
        MarkerPrintRibbonEmpty,
        [EnumMember(Value = "markerPrintRibbonMissing")]
        MarkerPrintRibbonMissing,
        [EnumMember(Value = "markerSupplyAlmostEmpty")]
        MarkerSupplyAlmostEmpty,
        [EnumMember(Value = "markerSupplyMissing")]
        MarkerSupplyMissing,
        [EnumMember(Value = "markerTonerCartridgeMissing")]
        MarkerTonerCartridgeMissing,
        [EnumMember(Value = "markerTonerMissing")]
        MarkerTonerMissing,
        [EnumMember(Value = "markerWasteInkReceptacleAlmostFull")]
        MarkerWasteInkReceptacleAlmostFull,
        [EnumMember(Value = "markerWasteInkReceptacleFull")]
        MarkerWasteInkReceptacleFull,
        [EnumMember(Value = "markerWasteInkReceptacleMissing")]
        MarkerWasteInkReceptacleMissing,
        [EnumMember(Value = "markerWasteMissing")]
        MarkerWasteMissing,
        [EnumMember(Value = "markerWasteTonerReceptacleAlmostFull")]
        MarkerWasteTonerReceptacleAlmostFull,
        [EnumMember(Value = "markerWasteTonerReceptacleFull")]
        MarkerWasteTonerReceptacleFull,
        [EnumMember(Value = "markerWasteTonerReceptacleMissing")]
        MarkerWasteTonerReceptacleMissing,
        [EnumMember(Value = "materialEmpty")]
        MaterialEmpty,
        [EnumMember(Value = "materialLow")]
        MaterialLow,
        [EnumMember(Value = "materialNeeded")]
        MaterialNeeded,
        [EnumMember(Value = "mediaDrying")]
        MediaDrying,
        [EnumMember(Value = "mediaPathCannotDuplexMediaSelected")]
        MediaPathCannotDuplexMediaSelected,
        [EnumMember(Value = "mediaPathFailure")]
        MediaPathFailure,
        [EnumMember(Value = "mediaPathInputEmpty")]
        MediaPathInputEmpty,
        [EnumMember(Value = "mediaPathInputFeedError")]
        MediaPathInputFeedError,
        [EnumMember(Value = "mediaPathInputJam")]
        MediaPathInputJam,
        [EnumMember(Value = "mediaPathInputRequest")]
        MediaPathInputRequest,
        [EnumMember(Value = "mediaPathJam")]
        MediaPathJam,
        [EnumMember(Value = "mediaPathMediaTrayAlmostFull")]
        MediaPathMediaTrayAlmostFull,
        [EnumMember(Value = "mediaPathMediaTrayFull")]
        MediaPathMediaTrayFull,
        [EnumMember(Value = "mediaPathMediaTrayMissing")]
        MediaPathMediaTrayMissing,
        [EnumMember(Value = "mediaPathOutputFeedError")]
        MediaPathOutputFeedError,
        [EnumMember(Value = "mediaPathOutputFull")]
        MediaPathOutputFull,
        [EnumMember(Value = "mediaPathOutputJam")]
        MediaPathOutputJam,
        [EnumMember(Value = "mediaPathPickRollerFailure")]
        MediaPathPickRollerFailure,
        [EnumMember(Value = "mediaPathPickRollerLifeOver")]
        MediaPathPickRollerLifeOver,
        [EnumMember(Value = "mediaPathPickRollerLifeWarn")]
        MediaPathPickRollerLifeWarn,
        [EnumMember(Value = "mediaPathPickRollerMissing")]
        MediaPathPickRollerMissing,
        [EnumMember(Value = "motorFailure")]
        MotorFailure,
        [EnumMember(Value = "outputMailboxSelectFailure")]
        OutputMailboxSelectFailure,
        [EnumMember(Value = "outputMediaTrayFailure")]
        OutputMediaTrayFailure,
        [EnumMember(Value = "outputMediaTrayFeedError")]
        OutputMediaTrayFeedError,
        [EnumMember(Value = "outputMediaTrayJam")]
        OutputMediaTrayJam,
        [EnumMember(Value = "perforaterAdded")]
        PerforaterAdded,
        [EnumMember(Value = "perforaterAlmostEmpty")]
        PerforaterAlmostEmpty,
        [EnumMember(Value = "perforaterAlmostFull")]
        PerforaterAlmostFull,
        [EnumMember(Value = "perforaterAtLimit")]
        PerforaterAtLimit,
        [EnumMember(Value = "perforaterClosed")]
        PerforaterClosed,
        [EnumMember(Value = "perforaterConfigurationChange")]
        PerforaterConfigurationChange,
        [EnumMember(Value = "perforaterCoverClosed")]
        PerforaterCoverClosed,
        [EnumMember(Value = "perforaterCoverOpen")]
        PerforaterCoverOpen,
        [EnumMember(Value = "perforaterEmpty")]
        PerforaterEmpty,
        [EnumMember(Value = "perforaterFull")]
        PerforaterFull,
        [EnumMember(Value = "perforaterInterlockClosed")]
        PerforaterInterlockClosed,
        [EnumMember(Value = "perforaterInterlockOpen")]
        PerforaterInterlockOpen,
        [EnumMember(Value = "perforaterJam")]
        PerforaterJam,
        [EnumMember(Value = "perforaterLifeAlmostOver")]
        PerforaterLifeAlmostOver,
        [EnumMember(Value = "perforaterLifeOver")]
        PerforaterLifeOver,
        [EnumMember(Value = "perforaterMemoryExhausted")]
        PerforaterMemoryExhausted,
        [EnumMember(Value = "perforaterMissing")]
        PerforaterMissing,
        [EnumMember(Value = "perforaterMotorFailure")]
        PerforaterMotorFailure,
        [EnumMember(Value = "perforaterNearLimit")]
        PerforaterNearLimit,
        [EnumMember(Value = "perforaterOffline")]
        PerforaterOffline,
        [EnumMember(Value = "perforaterOpened")]
        PerforaterOpened,
        [EnumMember(Value = "perforaterOverTemperature")]
        PerforaterOverTemperature,
        [EnumMember(Value = "perforaterPowerSaver")]
        PerforaterPowerSaver,
        [EnumMember(Value = "perforaterRecoverableFailure")]
        PerforaterRecoverableFailure,
        [EnumMember(Value = "perforaterRecoverableStorage")]
        PerforaterRecoverableStorage,
        [EnumMember(Value = "perforaterRemoved")]
        PerforaterRemoved,
        [EnumMember(Value = "perforaterResourceAdded")]
        PerforaterResourceAdded,
        [EnumMember(Value = "perforaterResourceRemoved")]
        PerforaterResourceRemoved,
        [EnumMember(Value = "perforaterThermistorFailure")]
        PerforaterThermistorFailure,
        [EnumMember(Value = "perforaterTimingFailure")]
        PerforaterTimingFailure,
        [EnumMember(Value = "perforaterTurnedOff")]
        PerforaterTurnedOff,
        [EnumMember(Value = "perforaterTurnedOn")]
        PerforaterTurnedOn,
        [EnumMember(Value = "perforaterUnderTemperature")]
        PerforaterUnderTemperature,
        [EnumMember(Value = "perforaterUnrecoverableFailure")]
        PerforaterUnrecoverableFailure,
        [EnumMember(Value = "perforaterUnrecoverableStorageError")]
        PerforaterUnrecoverableStorageError,
        [EnumMember(Value = "perforaterWarmingUp")]
        PerforaterWarmingUp,
        [EnumMember(Value = "platformCooling")]
        PlatformCooling,
        [EnumMember(Value = "platformFailure")]
        PlatformFailure,
        [EnumMember(Value = "platformHeating")]
        PlatformHeating,
        [EnumMember(Value = "platformTemperatureHigh")]
        PlatformTemperatureHigh,
        [EnumMember(Value = "platformTemperatureLow")]
        PlatformTemperatureLow,
        [EnumMember(Value = "powerDown")]
        PowerDown,
        [EnumMember(Value = "powerUp")]
        PowerUp,
        [EnumMember(Value = "printerManualReset")]
        PrinterManualReset,
        [EnumMember(Value = "printerNmsReset")]
        PrinterNmsReset,
        [EnumMember(Value = "printerReadyToPrint")]
        PrinterReadyToPrint,
        [EnumMember(Value = "puncherAdded")]
        PuncherAdded,
        [EnumMember(Value = "puncherAlmostEmpty")]
        PuncherAlmostEmpty,
        [EnumMember(Value = "puncherAlmostFull")]
        PuncherAlmostFull,
        [EnumMember(Value = "puncherAtLimit")]
        PuncherAtLimit,
        [EnumMember(Value = "puncherClosed")]
        PuncherClosed,
        [EnumMember(Value = "puncherConfigurationChange")]
        PuncherConfigurationChange,
        [EnumMember(Value = "puncherCoverClosed")]
        PuncherCoverClosed,
        [EnumMember(Value = "puncherCoverOpen")]
        PuncherCoverOpen,
        [EnumMember(Value = "puncherEmpty")]
        PuncherEmpty,
        [EnumMember(Value = "puncherFull")]
        PuncherFull,
        [EnumMember(Value = "puncherInterlockClosed")]
        PuncherInterlockClosed,
        [EnumMember(Value = "puncherInterlockOpen")]
        PuncherInterlockOpen,
        [EnumMember(Value = "puncherJam")]
        PuncherJam,
        [EnumMember(Value = "puncherLifeAlmostOver")]
        PuncherLifeAlmostOver,
        [EnumMember(Value = "puncherLifeOver")]
        PuncherLifeOver,
        [EnumMember(Value = "puncherMemoryExhausted")]
        PuncherMemoryExhausted,
        [EnumMember(Value = "puncherMissing")]
        PuncherMissing,
        [EnumMember(Value = "puncherMotorFailure")]
        PuncherMotorFailure,
        [EnumMember(Value = "puncherNearLimit")]
        PuncherNearLimit,
        [EnumMember(Value = "puncherOffline")]
        PuncherOffline,
        [EnumMember(Value = "puncherOpened")]
        PuncherOpened,
        [EnumMember(Value = "puncherOverTemperature")]
        PuncherOverTemperature,
        [EnumMember(Value = "puncherPowerSaver")]
        PuncherPowerSaver,
        [EnumMember(Value = "puncherRecoverableFailure")]
        PuncherRecoverableFailure,
        [EnumMember(Value = "puncherRecoverableStorage")]
        PuncherRecoverableStorage,
        [EnumMember(Value = "puncherRemoved")]
        PuncherRemoved,
        [EnumMember(Value = "puncherResourceAdded")]
        PuncherResourceAdded,
        [EnumMember(Value = "puncherResourceRemoved")]
        PuncherResourceRemoved,
        [EnumMember(Value = "puncherThermistorFailure")]
        PuncherThermistorFailure,
        [EnumMember(Value = "puncherTimingFailure")]
        PuncherTimingFailure,
        [EnumMember(Value = "puncherTurnedOff")]
        PuncherTurnedOff,
        [EnumMember(Value = "puncherTurnedOn")]
        PuncherTurnedOn,
        [EnumMember(Value = "puncherUnderTemperature")]
        PuncherUnderTemperature,
        [EnumMember(Value = "puncherUnrecoverableFailure")]
        PuncherUnrecoverableFailure,
        [EnumMember(Value = "puncherUnrecoverableStorageError")]
        PuncherUnrecoverableStorageError,
        [EnumMember(Value = "puncherWarmingUp")]
        PuncherWarmingUp,
        [EnumMember(Value = "resuming")]
        Resuming,
        [EnumMember(Value = "scanMediaPathFailure")]
        ScanMediaPathFailure,
        [EnumMember(Value = "scanMediaPathInputEmpty")]
        ScanMediaPathInputEmpty,
        [EnumMember(Value = "scanMediaPathInputFeedError")]
        ScanMediaPathInputFeedError,
        [EnumMember(Value = "scanMediaPathInputJam")]
        ScanMediaPathInputJam,
        [EnumMember(Value = "scanMediaPathInputRequest")]
        ScanMediaPathInputRequest,
        [EnumMember(Value = "scanMediaPathJam")]
        ScanMediaPathJam,
        [EnumMember(Value = "scanMediaPathOutputFeedError")]
        ScanMediaPathOutputFeedError,
        [EnumMember(Value = "scanMediaPathOutputFull")]
        ScanMediaPathOutputFull,
        [EnumMember(Value = "scanMediaPathOutputJam")]
        ScanMediaPathOutputJam,
        [EnumMember(Value = "scanMediaPathPickRollerFailure")]
        ScanMediaPathPickRollerFailure,
        [EnumMember(Value = "scanMediaPathPickRollerLifeOver")]
        ScanMediaPathPickRollerLifeOver,
        [EnumMember(Value = "scanMediaPathPickRollerLifeWarn")]
        ScanMediaPathPickRollerLifeWarn,
        [EnumMember(Value = "scanMediaPathPickRollerMissing")]
        ScanMediaPathPickRollerMissing,
        [EnumMember(Value = "scanMediaPathTrayAlmostFull")]
        ScanMediaPathTrayAlmostFull,
        [EnumMember(Value = "scanMediaPathTrayFull")]
        ScanMediaPathTrayFull,
        [EnumMember(Value = "scanMediaPathTrayMissing")]
        ScanMediaPathTrayMissing,
        [EnumMember(Value = "scannerLightFailure")]
        ScannerLightFailure,
        [EnumMember(Value = "scannerLightLifeAlmostOver")]
        ScannerLightLifeAlmostOver,
        [EnumMember(Value = "scannerLightLifeOver")]
        ScannerLightLifeOver,
        [EnumMember(Value = "scannerLightMissing")]
        ScannerLightMissing,
        [EnumMember(Value = "scannerSensorFailure")]
        ScannerSensorFailure,
        [EnumMember(Value = "scannerSensorLifeAlmostOver")]
        ScannerSensorLifeAlmostOver,
        [EnumMember(Value = "scannerSensorLifeOver")]
        ScannerSensorLifeOver,
        [EnumMember(Value = "scannerSensorMissing")]
        ScannerSensorMissing,
        [EnumMember(Value = "separationCutterAdded")]
        SeparationCutterAdded,
        [EnumMember(Value = "separationCutterAlmostEmpty")]
        SeparationCutterAlmostEmpty,
        [EnumMember(Value = "separationCutterAlmostFull")]
        SeparationCutterAlmostFull,
        [EnumMember(Value = "separationCutterAtLimit")]
        SeparationCutterAtLimit,
        [EnumMember(Value = "separationCutterClosed")]
        SeparationCutterClosed,
        [EnumMember(Value = "separationCutterConfigurationChange")]
        SeparationCutterConfigurationChange,
        [EnumMember(Value = "separationCutterCoverClosed")]
        SeparationCutterCoverClosed,
        [EnumMember(Value = "separationCutterCoverOpen")]
        SeparationCutterCoverOpen,
        [EnumMember(Value = "separationCutterEmpty")]
        SeparationCutterEmpty,
        [EnumMember(Value = "separationCutterFull")]
        SeparationCutterFull,
        [EnumMember(Value = "separationCutterInterlockClosed")]
        SeparationCutterInterlockClosed,
        [EnumMember(Value = "separationCutterInterlockOpen")]
        SeparationCutterInterlockOpen,
        [EnumMember(Value = "separationCutterJam")]
        SeparationCutterJam,
        [EnumMember(Value = "separationCutterLifeAlmostOver")]
        SeparationCutterLifeAlmostOver,
        [EnumMember(Value = "separationCutterLifeOver")]
        SeparationCutterLifeOver,
        [EnumMember(Value = "separationCutterMemoryExhausted")]
        SeparationCutterMemoryExhausted,
        [EnumMember(Value = "separationCutterMissing")]
        SeparationCutterMissing,
        [EnumMember(Value = "separationCutterMotorFailure")]
        SeparationCutterMotorFailure,
        [EnumMember(Value = "separationCutterNearLimit")]
        SeparationCutterNearLimit,
        [EnumMember(Value = "separationCutterOffline")]
        SeparationCutterOffline,
        [EnumMember(Value = "separationCutterOpened")]
        SeparationCutterOpened,
        [EnumMember(Value = "separationCutterOverTemperature")]
        SeparationCutterOverTemperature,
        [EnumMember(Value = "separationCutterPowerSaver")]
        SeparationCutterPowerSaver,
        [EnumMember(Value = "separationCutterRecoverableFailure")]
        SeparationCutterRecoverableFailure,
        [EnumMember(Value = "separationCutterRecoverableStorage")]
        SeparationCutterRecoverableStorage,
        [EnumMember(Value = "separationCutterRemoved")]
        SeparationCutterRemoved,
        [EnumMember(Value = "separationCutterResourceAdded")]
        SeparationCutterResourceAdded,
        [EnumMember(Value = "separationCutterResourceRemoved")]
        SeparationCutterResourceRemoved,
        [EnumMember(Value = "separationCutterThermistorFailure")]
        SeparationCutterThermistorFailure,
        [EnumMember(Value = "separationCutterTimingFailure")]
        SeparationCutterTimingFailure,
        [EnumMember(Value = "separationCutterTurnedOff")]
        SeparationCutterTurnedOff,
        [EnumMember(Value = "separationCutterTurnedOn")]
        SeparationCutterTurnedOn,
        [EnumMember(Value = "separationCutterUnderTemperature")]
        SeparationCutterUnderTemperature,
        [EnumMember(Value = "separationCutterUnrecoverableFailure")]
        SeparationCutterUnrecoverableFailure,
        [EnumMember(Value = "separationCutterUnrecoverableStorageError")]
        SeparationCutterUnrecoverableStorageError,
        [EnumMember(Value = "separationCutterWarmingUp")]
        SeparationCutterWarmingUp,
        [EnumMember(Value = "sheetRotatorAdded")]
        SheetRotatorAdded,
        [EnumMember(Value = "sheetRotatorAlmostEmpty")]
        SheetRotatorAlmostEmpty,
        [EnumMember(Value = "sheetRotatorAlmostFull")]
        SheetRotatorAlmostFull,
        [EnumMember(Value = "sheetRotatorAtLimit")]
        SheetRotatorAtLimit,
        [EnumMember(Value = "sheetRotatorClosed")]
        SheetRotatorClosed,
        [EnumMember(Value = "sheetRotatorConfigurationChange")]
        SheetRotatorConfigurationChange,
        [EnumMember(Value = "sheetRotatorCoverClosed")]
        SheetRotatorCoverClosed,
        [EnumMember(Value = "sheetRotatorCoverOpen")]
        SheetRotatorCoverOpen,
        [EnumMember(Value = "sheetRotatorEmpty")]
        SheetRotatorEmpty,
        [EnumMember(Value = "sheetRotatorFull")]
        SheetRotatorFull,
        [EnumMember(Value = "sheetRotatorInterlockClosed")]
        SheetRotatorInterlockClosed,
        [EnumMember(Value = "sheetRotatorInterlockOpen")]
        SheetRotatorInterlockOpen,
        [EnumMember(Value = "sheetRotatorJam")]
        SheetRotatorJam,
        [EnumMember(Value = "sheetRotatorLifeAlmostOver")]
        SheetRotatorLifeAlmostOver,
        [EnumMember(Value = "sheetRotatorLifeOver")]
        SheetRotatorLifeOver,
        [EnumMember(Value = "sheetRotatorMemoryExhausted")]
        SheetRotatorMemoryExhausted,
        [EnumMember(Value = "sheetRotatorMissing")]
        SheetRotatorMissing,
        [EnumMember(Value = "sheetRotatorMotorFailure")]
        SheetRotatorMotorFailure,
        [EnumMember(Value = "sheetRotatorNearLimit")]
        SheetRotatorNearLimit,
        [EnumMember(Value = "sheetRotatorOffline")]
        SheetRotatorOffline,
        [EnumMember(Value = "sheetRotatorOpened")]
        SheetRotatorOpened,
        [EnumMember(Value = "sheetRotatorOverTemperature")]
        SheetRotatorOverTemperature,
        [EnumMember(Value = "sheetRotatorPowerSaver")]
        SheetRotatorPowerSaver,
        [EnumMember(Value = "sheetRotatorRecoverableFailure")]
        SheetRotatorRecoverableFailure,
        [EnumMember(Value = "sheetRotatorRecoverableStorage")]
        SheetRotatorRecoverableStorage,
        [EnumMember(Value = "sheetRotatorRemoved")]
        SheetRotatorRemoved,
        [EnumMember(Value = "sheetRotatorResourceAdded")]
        SheetRotatorResourceAdded,
        [EnumMember(Value = "sheetRotatorResourceRemoved")]
        SheetRotatorResourceRemoved,
        [EnumMember(Value = "sheetRotatorThermistorFailure")]
        SheetRotatorThermistorFailure,
        [EnumMember(Value = "sheetRotatorTimingFailure")]
        SheetRotatorTimingFailure,
        [EnumMember(Value = "sheetRotatorTurnedOff")]
        SheetRotatorTurnedOff,
        [EnumMember(Value = "sheetRotatorTurnedOn")]
        SheetRotatorTurnedOn,
        [EnumMember(Value = "sheetRotatorUnderTemperature")]
        SheetRotatorUnderTemperature,
        [EnumMember(Value = "sheetRotatorUnrecoverableFailure")]
        SheetRotatorUnrecoverableFailure,
        [EnumMember(Value = "sheetRotatorUnrecoverableStorageError")]
        SheetRotatorUnrecoverableStorageError,
        [EnumMember(Value = "sheetRotatorWarmingUp")]
        SheetRotatorWarmingUp,
        [EnumMember(Value = "slitterAdded")]
        SlitterAdded,
        [EnumMember(Value = "slitterAlmostEmpty")]
        SlitterAlmostEmpty,
        [EnumMember(Value = "slitterAlmostFull")]
        SlitterAlmostFull,
        [EnumMember(Value = "slitterAtLimit")]
        SlitterAtLimit,
        [EnumMember(Value = "slitterClosed")]
        SlitterClosed,
        [EnumMember(Value = "slitterConfigurationChange")]
        SlitterConfigurationChange,
        [EnumMember(Value = "slitterCoverClosed")]
        SlitterCoverClosed,
        [EnumMember(Value = "slitterCoverOpen")]
        SlitterCoverOpen,
        [EnumMember(Value = "slitterEmpty")]
        SlitterEmpty,
        [EnumMember(Value = "slitterFull")]
        SlitterFull,
        [EnumMember(Value = "slitterInterlockClosed")]
        SlitterInterlockClosed,
        [EnumMember(Value = "slitterInterlockOpen")]
        SlitterInterlockOpen,
        [EnumMember(Value = "slitterJam")]
        SlitterJam,
        [EnumMember(Value = "slitterLifeAlmostOver")]
        SlitterLifeAlmostOver,
        [EnumMember(Value = "slitterLifeOver")]
        SlitterLifeOver,
        [EnumMember(Value = "slitterMemoryExhausted")]
        SlitterMemoryExhausted,
        [EnumMember(Value = "slitterMissing")]
        SlitterMissing,
        [EnumMember(Value = "slitterMotorFailure")]
        SlitterMotorFailure,
        [EnumMember(Value = "slitterNearLimit")]
        SlitterNearLimit,
        [EnumMember(Value = "slitterOffline")]
        SlitterOffline,
        [EnumMember(Value = "slitterOpened")]
        SlitterOpened,
        [EnumMember(Value = "slitterOverTemperature")]
        SlitterOverTemperature,
        [EnumMember(Value = "slitterPowerSaver")]
        SlitterPowerSaver,
        [EnumMember(Value = "slitterRecoverableFailure")]
        SlitterRecoverableFailure,
        [EnumMember(Value = "slitterRecoverableStorage")]
        SlitterRecoverableStorage,
        [EnumMember(Value = "slitterRemoved")]
        SlitterRemoved,
        [EnumMember(Value = "slitterResourceAdded")]
        SlitterResourceAdded,
        [EnumMember(Value = "slitterResourceRemoved")]
        SlitterResourceRemoved,
        [EnumMember(Value = "slitterThermistorFailure")]
        SlitterThermistorFailure,
        [EnumMember(Value = "slitterTimingFailure")]
        SlitterTimingFailure,
        [EnumMember(Value = "slitterTurnedOff")]
        SlitterTurnedOff,
        [EnumMember(Value = "slitterTurnedOn")]
        SlitterTurnedOn,
        [EnumMember(Value = "slitterUnderTemperature")]
        SlitterUnderTemperature,
        [EnumMember(Value = "slitterUnrecoverableFailure")]
        SlitterUnrecoverableFailure,
        [EnumMember(Value = "slitterUnrecoverableStorageError")]
        SlitterUnrecoverableStorageError,
        [EnumMember(Value = "slitterWarmingUp")]
        SlitterWarmingUp,
        [EnumMember(Value = "stackerAdded")]
        StackerAdded,
        [EnumMember(Value = "stackerAlmostEmpty")]
        StackerAlmostEmpty,
        [EnumMember(Value = "stackerAlmostFull")]
        StackerAlmostFull,
        [EnumMember(Value = "stackerAtLimit")]
        StackerAtLimit,
        [EnumMember(Value = "stackerClosed")]
        StackerClosed,
        [EnumMember(Value = "stackerConfigurationChange")]
        StackerConfigurationChange,
        [EnumMember(Value = "stackerCoverClosed")]
        StackerCoverClosed,
        [EnumMember(Value = "stackerCoverOpen")]
        StackerCoverOpen,
        [EnumMember(Value = "stackerEmpty")]
        StackerEmpty,
        [EnumMember(Value = "stackerFull")]
        StackerFull,
        [EnumMember(Value = "stackerInterlockClosed")]
        StackerInterlockClosed,
        [EnumMember(Value = "stackerInterlockOpen")]
        StackerInterlockOpen,
        [EnumMember(Value = "stackerJam")]
        StackerJam,
        [EnumMember(Value = "stackerLifeAlmostOver")]
        StackerLifeAlmostOver,
        [EnumMember(Value = "stackerLifeOver")]
        StackerLifeOver,
        [EnumMember(Value = "stackerMemoryExhausted")]
        StackerMemoryExhausted,
        [EnumMember(Value = "stackerMissing")]
        StackerMissing,
        [EnumMember(Value = "stackerMotorFailure")]
        StackerMotorFailure,
        [EnumMember(Value = "stackerNearLimit")]
        StackerNearLimit,
        [EnumMember(Value = "stackerOffline")]
        StackerOffline,
        [EnumMember(Value = "stackerOpened")]
        StackerOpened,
        [EnumMember(Value = "stackerOverTemperature")]
        StackerOverTemperature,
        [EnumMember(Value = "stackerPowerSaver")]
        StackerPowerSaver,
        [EnumMember(Value = "stackerRecoverableFailure")]
        StackerRecoverableFailure,
        [EnumMember(Value = "stackerRecoverableStorage")]
        StackerRecoverableStorage,
        [EnumMember(Value = "stackerRemoved")]
        StackerRemoved,
        [EnumMember(Value = "stackerResourceAdded")]
        StackerResourceAdded,
        [EnumMember(Value = "stackerResourceRemoved")]
        StackerResourceRemoved,
        [EnumMember(Value = "stackerThermistorFailure")]
        StackerThermistorFailure,
        [EnumMember(Value = "stackerTimingFailure")]
        StackerTimingFailure,
        [EnumMember(Value = "stackerTurnedOff")]
        StackerTurnedOff,
        [EnumMember(Value = "stackerTurnedOn")]
        StackerTurnedOn,
        [EnumMember(Value = "stackerUnderTemperature")]
        StackerUnderTemperature,
        [EnumMember(Value = "stackerUnrecoverableFailure")]
        StackerUnrecoverableFailure,
        [EnumMember(Value = "stackerUnrecoverableStorageError")]
        StackerUnrecoverableStorageError,
        [EnumMember(Value = "stackerWarmingUp")]
        StackerWarmingUp,
        [EnumMember(Value = "standby")]
        Standby,
        [EnumMember(Value = "staplerAdded")]
        StaplerAdded,
        [EnumMember(Value = "staplerAlmostEmpty")]
        StaplerAlmostEmpty,
        [EnumMember(Value = "staplerAlmostFull")]
        StaplerAlmostFull,
        [EnumMember(Value = "staplerAtLimit")]
        StaplerAtLimit,
        [EnumMember(Value = "staplerClosed")]
        StaplerClosed,
        [EnumMember(Value = "staplerConfigurationChange")]
        StaplerConfigurationChange,
        [EnumMember(Value = "staplerCoverClosed")]
        StaplerCoverClosed,
        [EnumMember(Value = "staplerCoverOpen")]
        StaplerCoverOpen,
        [EnumMember(Value = "staplerEmpty")]
        StaplerEmpty,
        [EnumMember(Value = "staplerFull")]
        StaplerFull,
        [EnumMember(Value = "staplerInterlockClosed")]
        StaplerInterlockClosed,
        [EnumMember(Value = "staplerInterlockOpen")]
        StaplerInterlockOpen,
        [EnumMember(Value = "staplerJam")]
        StaplerJam,
        [EnumMember(Value = "staplerLifeAlmostOver")]
        StaplerLifeAlmostOver,
        [EnumMember(Value = "staplerLifeOver")]
        StaplerLifeOver,
        [EnumMember(Value = "staplerMemoryExhausted")]
        StaplerMemoryExhausted,
        [EnumMember(Value = "staplerMissing")]
        StaplerMissing,
        [EnumMember(Value = "staplerMotorFailure")]
        StaplerMotorFailure,
        [EnumMember(Value = "staplerNearLimit")]
        StaplerNearLimit,
        [EnumMember(Value = "staplerOffline")]
        StaplerOffline,
        [EnumMember(Value = "staplerOpened")]
        StaplerOpened,
        [EnumMember(Value = "staplerOverTemperature")]
        StaplerOverTemperature,
        [EnumMember(Value = "staplerPowerSaver")]
        StaplerPowerSaver,
        [EnumMember(Value = "staplerRecoverableFailure")]
        StaplerRecoverableFailure,
        [EnumMember(Value = "staplerRecoverableStorage")]
        StaplerRecoverableStorage,
        [EnumMember(Value = "staplerRemoved")]
        StaplerRemoved,
        [EnumMember(Value = "staplerResourceAdded")]
        StaplerResourceAdded,
        [EnumMember(Value = "staplerResourceRemoved")]
        StaplerResourceRemoved,
        [EnumMember(Value = "staplerThermistorFailure")]
        StaplerThermistorFailure,
        [EnumMember(Value = "staplerTimingFailure")]
        StaplerTimingFailure,
        [EnumMember(Value = "staplerTurnedOff")]
        StaplerTurnedOff,
        [EnumMember(Value = "staplerTurnedOn")]
        StaplerTurnedOn,
        [EnumMember(Value = "staplerUnderTemperature")]
        StaplerUnderTemperature,
        [EnumMember(Value = "staplerUnrecoverableFailure")]
        StaplerUnrecoverableFailure,
        [EnumMember(Value = "staplerUnrecoverableStorageError")]
        StaplerUnrecoverableStorageError,
        [EnumMember(Value = "staplerWarmingUp")]
        StaplerWarmingUp,
        [EnumMember(Value = "stitcherAdded")]
        StitcherAdded,
        [EnumMember(Value = "stitcherAlmostEmpty")]
        StitcherAlmostEmpty,
        [EnumMember(Value = "stitcherAlmostFull")]
        StitcherAlmostFull,
        [EnumMember(Value = "stitcherAtLimit")]
        StitcherAtLimit,
        [EnumMember(Value = "stitcherClosed")]
        StitcherClosed,
        [EnumMember(Value = "stitcherConfigurationChange")]
        StitcherConfigurationChange,
        [EnumMember(Value = "stitcherCoverClosed")]
        StitcherCoverClosed,
        [EnumMember(Value = "stitcherCoverOpen")]
        StitcherCoverOpen,
        [EnumMember(Value = "stitcherEmpty")]
        StitcherEmpty,
        [EnumMember(Value = "stitcherFull")]
        StitcherFull,
        [EnumMember(Value = "stitcherInterlockClosed")]
        StitcherInterlockClosed,
        [EnumMember(Value = "stitcherInterlockOpen")]
        StitcherInterlockOpen,
        [EnumMember(Value = "stitcherJam")]
        StitcherJam,
        [EnumMember(Value = "stitcherLifeAlmostOver")]
        StitcherLifeAlmostOver,
        [EnumMember(Value = "stitcherLifeOver")]
        StitcherLifeOver,
        [EnumMember(Value = "stitcherMemoryExhausted")]
        StitcherMemoryExhausted,
        [EnumMember(Value = "stitcherMissing")]
        StitcherMissing,
        [EnumMember(Value = "stitcherMotorFailure")]
        StitcherMotorFailure,
        [EnumMember(Value = "stitcherNearLimit")]
        StitcherNearLimit,
        [EnumMember(Value = "stitcherOffline")]
        StitcherOffline,
        [EnumMember(Value = "stitcherOpened")]
        StitcherOpened,
        [EnumMember(Value = "stitcherOverTemperature")]
        StitcherOverTemperature,
        [EnumMember(Value = "stitcherPowerSaver")]
        StitcherPowerSaver,
        [EnumMember(Value = "stitcherRecoverableFailure")]
        StitcherRecoverableFailure,
        [EnumMember(Value = "stitcherRecoverableStorage")]
        StitcherRecoverableStorage,
        [EnumMember(Value = "stitcherRemoved")]
        StitcherRemoved,
        [EnumMember(Value = "stitcherResourceAdded")]
        StitcherResourceAdded,
        [EnumMember(Value = "stitcherResourceRemoved")]
        StitcherResourceRemoved,
        [EnumMember(Value = "stitcherThermistorFailure")]
        StitcherThermistorFailure,
        [EnumMember(Value = "stitcherTimingFailure")]
        StitcherTimingFailure,
        [EnumMember(Value = "stitcherTurnedOff")]
        StitcherTurnedOff,
        [EnumMember(Value = "stitcherTurnedOn")]
        StitcherTurnedOn,
        [EnumMember(Value = "stitcherUnderTemperature")]
        StitcherUnderTemperature,
        [EnumMember(Value = "stitcherUnrecoverableFailure")]
        StitcherUnrecoverableFailure,
        [EnumMember(Value = "stitcherUnrecoverableStorageError")]
        StitcherUnrecoverableStorageError,
        [EnumMember(Value = "stitcherWarmingUp")]
        StitcherWarmingUp,
        [EnumMember(Value = "subunitAdded")]
        SubunitAdded,
        [EnumMember(Value = "subunitAlmostEmpty")]
        SubunitAlmostEmpty,
        [EnumMember(Value = "subunitAlmostFull")]
        SubunitAlmostFull,
        [EnumMember(Value = "subunitAtLimit")]
        SubunitAtLimit,
        [EnumMember(Value = "subunitClosed")]
        SubunitClosed,
        [EnumMember(Value = "subunitCoolingDown")]
        SubunitCoolingDown,
        [EnumMember(Value = "subunitEmpty")]
        SubunitEmpty,
        [EnumMember(Value = "subunitFull")]
        SubunitFull,
        [EnumMember(Value = "subunitLifeAlmostOver")]
        SubunitLifeAlmostOver,
        [EnumMember(Value = "subunitLifeOver")]
        SubunitLifeOver,
        [EnumMember(Value = "subunitMemoryExhausted")]
        SubunitMemoryExhausted,
        [EnumMember(Value = "subunitMissing")]
        SubunitMissing,
        [EnumMember(Value = "subunitMotorFailure")]
        SubunitMotorFailure,
        [EnumMember(Value = "subunitNearLimit")]
        SubunitNearLimit,
        [EnumMember(Value = "subunitOffline")]
        SubunitOffline,
        [EnumMember(Value = "subunitOpened")]
        SubunitOpened,
        [EnumMember(Value = "subunitOverTemperature")]
        SubunitOverTemperature,
        [EnumMember(Value = "subunitPowerSaver")]
        SubunitPowerSaver,
        [EnumMember(Value = "subunitRecoverableFailure")]
        SubunitRecoverableFailure,
        [EnumMember(Value = "subunitRecoverableStorage")]
        SubunitRecoverableStorage,
        [EnumMember(Value = "subunitRemoved")]
        SubunitRemoved,
        [EnumMember(Value = "subunitResourceAdded")]
        SubunitResourceAdded,
        [EnumMember(Value = "subunitResourceRemoved")]
        SubunitResourceRemoved,
        [EnumMember(Value = "subunitThermistorFailure")]
        SubunitThermistorFailure,
        [EnumMember(Value = "subunitTimingFailure")]
        SubunitTimingFailure,
        [EnumMember(Value = "subunitTurnedOff")]
        SubunitTurnedOff,
        [EnumMember(Value = "subunitTurnedOn")]
        SubunitTurnedOn,
        [EnumMember(Value = "subunitUnderTemperature")]
        SubunitUnderTemperature,
        [EnumMember(Value = "subunitUnrecoverableFailure")]
        SubunitUnrecoverableFailure,
        [EnumMember(Value = "subunitUnrecoverableStorage")]
        SubunitUnrecoverableStorage,
        [EnumMember(Value = "subunitWarmingUp")]
        SubunitWarmingUp,
        [EnumMember(Value = "suspend")]
        Suspend,
        [EnumMember(Value = "testing")]
        Testing,
        [EnumMember(Value = "trimmerAdded")]
        TrimmerAdded,
        [EnumMember(Value = "trimmerAlmostEmpty")]
        TrimmerAlmostEmpty,
        [EnumMember(Value = "trimmerAlmostFull")]
        TrimmerAlmostFull,
        [EnumMember(Value = "trimmerAtLimit")]
        TrimmerAtLimit,
        [EnumMember(Value = "trimmerClosed")]
        TrimmerClosed,
        [EnumMember(Value = "trimmerConfigurationChange")]
        TrimmerConfigurationChange,
        [EnumMember(Value = "trimmerCoverClosed")]
        TrimmerCoverClosed,
        [EnumMember(Value = "trimmerCoverOpen")]
        TrimmerCoverOpen,
        [EnumMember(Value = "trimmerEmpty")]
        TrimmerEmpty,
        [EnumMember(Value = "trimmerFull")]
        TrimmerFull,
        [EnumMember(Value = "trimmerInterlockClosed")]
        TrimmerInterlockClosed,
        [EnumMember(Value = "trimmerInterlockOpen")]
        TrimmerInterlockOpen,
        [EnumMember(Value = "trimmerJam")]
        TrimmerJam,
        [EnumMember(Value = "trimmerLifeAlmostOver")]
        TrimmerLifeAlmostOver,
        [EnumMember(Value = "trimmerLifeOver")]
        TrimmerLifeOver,
        [EnumMember(Value = "trimmerMemoryExhausted")]
        TrimmerMemoryExhausted,
        [EnumMember(Value = "trimmerMissing")]
        TrimmerMissing,
        [EnumMember(Value = "trimmerMotorFailure")]
        TrimmerMotorFailure,
        [EnumMember(Value = "trimmerNearLimit")]
        TrimmerNearLimit,
        [EnumMember(Value = "trimmerOffline")]
        TrimmerOffline,
        [EnumMember(Value = "trimmerOpened")]
        TrimmerOpened,
        [EnumMember(Value = "trimmerOverTemperature")]
        TrimmerOverTemperature,
        [EnumMember(Value = "trimmerPowerSaver")]
        TrimmerPowerSaver,
        [EnumMember(Value = "trimmerRecoverableFailure")]
        TrimmerRecoverableFailure,
        [EnumMember(Value = "trimmerRecoverableStorage")]
        TrimmerRecoverableStorage,
        [EnumMember(Value = "trimmerRemoved")]
        TrimmerRemoved,
        [EnumMember(Value = "trimmerResourceAdded")]
        TrimmerResourceAdded,
        [EnumMember(Value = "trimmerResourceRemoved")]
        TrimmerResourceRemoved,
        [EnumMember(Value = "trimmerThermistorFailure")]
        TrimmerThermistorFailure,
        [EnumMember(Value = "trimmerTimingFailure")]
        TrimmerTimingFailure,
        [EnumMember(Value = "trimmerTurnedOff")]
        TrimmerTurnedOff,
        [EnumMember(Value = "trimmerTurnedOn")]
        TrimmerTurnedOn,
        [EnumMember(Value = "trimmerUnderTemperature")]
        TrimmerUnderTemperature,
        [EnumMember(Value = "trimmerUnrecoverableFailure")]
        TrimmerUnrecoverableFailure,
        [EnumMember(Value = "trimmerUnrecoverableStorageError")]
        TrimmerUnrecoverableStorageError,
        [EnumMember(Value = "trimmerWarmingUp")]
        TrimmerWarmingUp,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "wrapperAdded")]
        WrapperAdded,
        [EnumMember(Value = "wrapperAlmostEmpty")]
        WrapperAlmostEmpty,
        [EnumMember(Value = "wrapperAlmostFull")]
        WrapperAlmostFull,
        [EnumMember(Value = "wrapperAtLimit")]
        WrapperAtLimit,
        [EnumMember(Value = "wrapperClosed")]
        WrapperClosed,
        [EnumMember(Value = "wrapperConfigurationChange")]
        WrapperConfigurationChange,
        [EnumMember(Value = "wrapperCoverClosed")]
        WrapperCoverClosed,
        [EnumMember(Value = "wrapperCoverOpen")]
        WrapperCoverOpen,
        [EnumMember(Value = "wrapperEmpty")]
        WrapperEmpty,
        [EnumMember(Value = "wrapperFull")]
        WrapperFull,
        [EnumMember(Value = "wrapperInterlockClosed")]
        WrapperInterlockClosed,
        [EnumMember(Value = "wrapperInterlockOpen")]
        WrapperInterlockOpen,
        [EnumMember(Value = "wrapperJam")]
        WrapperJam,
        [EnumMember(Value = "wrapperLifeAlmostOver")]
        WrapperLifeAlmostOver,
        [EnumMember(Value = "wrapperLifeOver")]
        WrapperLifeOver,
        [EnumMember(Value = "wrapperMemoryExhausted")]
        WrapperMemoryExhausted,
        [EnumMember(Value = "wrapperMissing")]
        WrapperMissing,
        [EnumMember(Value = "wrapperMotorFailure")]
        WrapperMotorFailure,
        [EnumMember(Value = "wrapperNearLimit")]
        WrapperNearLimit,
        [EnumMember(Value = "wrapperOffline")]
        WrapperOffline,
        [EnumMember(Value = "wrapperOpened")]
        WrapperOpened,
        [EnumMember(Value = "wrapperOverTemperature")]
        WrapperOverTemperature,
        [EnumMember(Value = "wrapperPowerSaver")]
        WrapperPowerSaver,
        [EnumMember(Value = "wrapperRecoverableFailure")]
        WrapperRecoverableFailure,
        [EnumMember(Value = "wrapperRecoverableStorage")]
        WrapperRecoverableStorage,
        [EnumMember(Value = "wrapperRemoved")]
        WrapperRemoved,
        [EnumMember(Value = "wrapperResourceAdded")]
        WrapperResourceAdded,
        [EnumMember(Value = "wrapperResourceRemoved")]
        WrapperResourceRemoved,
        [EnumMember(Value = "wrapperThermistorFailure")]
        WrapperThermistorFailure,
        [EnumMember(Value = "wrapperTimingFailure")]
        WrapperTimingFailure,
        [EnumMember(Value = "wrapperTurnedOff")]
        WrapperTurnedOff,
        [EnumMember(Value = "wrapperTurnedOn")]
        WrapperTurnedOn,
        [EnumMember(Value = "wrapperUnderTemperature")]
        WrapperUnderTemperature,
        [EnumMember(Value = "wrapperUnrecoverableFailure")]
        WrapperUnrecoverableFailure,
        [EnumMember(Value = "wrapperUnrecoverableStorageError")]
        WrapperUnrecoverableStorageError,
        [EnumMember(Value = "wrapperWarmingUp")]
        WrapperWarmingUp,
    }
}
