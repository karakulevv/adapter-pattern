using AdapterPattern.Interfaces;
using AdapterPattern.Models;

namespace AdapterPattern.Services;

/// <summary>
/// Create the Adapter
/// </summary>
public class DeviceAdapter : IWallOutlet
{
    private DeviceTypeA deviceTypeA;

    // Constructor that takes a DeviceTypeA instance
    public DeviceAdapter(DeviceTypeA deviceTypeA)
    {
        this.deviceTypeA = deviceTypeA;
    }

    // Implementing the target interface
    public void SupplyPower()
    {
        Console.WriteLine("Adapter is supplying power:");
        // Adapt the specific interface to the target interface
        deviceTypeA.ConnectTypeAPlug();
    }
}