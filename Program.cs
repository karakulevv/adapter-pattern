using AdapterPattern.Interfaces;
using AdapterPattern.Models;
using AdapterPattern.Services;

namespace AdapterPattern;

/// <summary>
/// Adapter Design Pattern
/// </summary>
static class Program
{
    static void Main(string[] args)
    {
        // Using the adapter to connect a DeviceTypeA to a Wall Outlet
        DeviceTypeA deviceTypeA = new DeviceTypeA();
        IWallOutlet wallOutlet = new DeviceAdapter(deviceTypeA);

        // Supply power to the device through the wall outlet (using the adapter)
        wallOutlet.SupplyPower();

        // Wait for user
        Console.ReadKey();
    }
}