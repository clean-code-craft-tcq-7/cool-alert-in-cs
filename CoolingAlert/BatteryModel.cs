namespace CoolingAlert;

public enum BatteryState
{
    BATTERY_OK,
    BATTERY_WARNING,
    BATTERY_ALERT
}

public sealed class BatteryDataModel
{
    public int BatteryId { get; init; }
    public ThermalManagementType ThermalManagementType { get; init; }
    public int Temperature { get; init; }
}
