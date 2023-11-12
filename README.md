# Adapter Design Pattern Example: Electrical Device Adapter

The Adapter Design Pattern is a structural design pattern that allows the interface of an existing class to be used as another interface. This pattern is particularly useful when you have two incompatible interfaces that need to work together.

## Scenario

Imagine you have a wall power outlet with a specific type of plug, let's call it a "Type A" plug. However, you have various electrical devices with different plug types, such as "Type B" and "Type C." You want to connect these devices to the wall outlet, but their plugs are incompatible. Here, an adapter can help you bridge the gap between the devices and the wall outlet.

## Implementation

### 1. Define the Target Interface

**IWallOutlet:** This interface declares a method `SupplyPower()`, representing the functionality expected from devices that can connect to a wall outlet.

### 2. Implement the Adaptee Class

**DeviceTypeA:** This class represents an existing class with a specific interface that needs adaptation. It has a method `ConnectTypeAPlug()` representing its specific functionality.

### 3. Create the Adapter

**DeviceAdapter:** This class implements the target interface (`IWallOutlet`) and adapts the specific interface of `DeviceTypeA`. It takes a `DeviceTypeA` instance in its constructor.

### 4. Adapter Design Pattern in Action

In the `Main` method, an instance of `DeviceTypeA` is created, and an `IWallOutlet` is instantiated using a `DeviceAdapter` with the `DeviceTypeA` instance. The `SupplyPower` method is then called on the `IWallOutlet`, demonstrating the Adapter Design Pattern.

## How to Use

**Description:** This example illustrates how the Adapter pattern allows a device with a specific plug type to be connected to a wall outlet by creating an adapter class. The adapter class adapts the specific interface of the device to the target interface, allowing the device to work seamlessly with the wall outlet.
