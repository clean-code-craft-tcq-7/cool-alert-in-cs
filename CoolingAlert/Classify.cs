namespace CoolingAlert;

// ----------- STEP 5 -----------------
/*
// Separation of classification from the email action.
public static class Classify
{
    public static BatteryState ClassifyBatteryState(BatteryDataModel batteryData)
    {
        BatteryState state = BatteryState.BATTERY_OK;
        float alertThreshold = Thresholds.AlertTemperatureForCoolingType(batteryData.ThermalManagementType);
        if (batteryData.Temperature >= alertThreshold)
        {
            state = BatteryState.BATTERY_ALERT;
        }
        return state;
    }
}
*/
// ----------- STEP 5 code ends -------
