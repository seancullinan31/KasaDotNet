// See https://aka.ms/new-console-template for more information
using KasaLib;
using KasaLib.InputObjects;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

var auth = new kasaAuth();
var authToken = await auth.postAuth("changeme", "changeme");
Console.WriteLine(authToken.error_code.ToString());