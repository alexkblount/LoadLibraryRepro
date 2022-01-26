// See https://aka.ms/new-console-template for more information
using LoadLibraryRepo;

var p = NativeLibrary.LoadLibrary("VS450.dll");

Console.WriteLine(p);
