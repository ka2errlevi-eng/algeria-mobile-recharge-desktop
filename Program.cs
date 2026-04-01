using System;
using System.IO.Ports;

Console.WriteLine("Algeria Mobile Recharge Desktop - starting...");

// Example: list available COM ports
Console.WriteLine("Available COM ports:");
var ports = SerialPort.GetPortNames();
foreach (var port in ports)
    Console.WriteLine($"  {port}");

Console.WriteLine("This is a placeholder for your modem logic.");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();