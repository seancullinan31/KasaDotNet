// See https://aka.ms/new-console-template for more information
using KasaLib;
using Microsoft.Extensions.Configuration;

ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
IConfiguration configuration = configurationBuilder.AddUserSecrets<Program>().Build();
string userName = configuration.GetSection("kasa")["userName"];
string password = configuration.GetSection("kasa")["password"];

var authToken = await kasaAuth.Instance().postAuth(userName, password);
if (authToken.error_code ==0 )
{
    var deviceList = await kasaDevices.Instance().getDeviceList(authToken);
    foreach ( var device in deviceList.result.deviceList )
    {
        Console.WriteLine(device.alias + "- Device Id: " + device.deviceId);
    }
    var energyMonitor = await kasaGetState.Instance().getDeviceState(authToken, "80064AB5C09A1099DCA327E53340E35C218CCC01");
    Console.WriteLine(energyMonitor);
} else
{
    Console.WriteLine("Error logging in: " + authToken.error_code);
}