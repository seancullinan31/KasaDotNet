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
        Console.WriteLine(device.alias);
    }
} else
{
    Console.WriteLine("Error logging in: " + authToken.error_code);
}