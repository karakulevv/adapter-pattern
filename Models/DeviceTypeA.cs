namespace AdapterPattern.Models;

/// <summary>
/// Implement the Adaptee Class
/// </summary>
public class DeviceTypeA
{
    public void ConnectTypeAPlug()
    {
        Console.WriteLine("Device Type A is connected to a Type A plug.");
        // Perform actions specific to Type A plug connection
    }
}