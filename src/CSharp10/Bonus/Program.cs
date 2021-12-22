// See https://aka.ms/new-console-template for more information
// You can use _ as a digit separator from C# 7.
using static System.Console;

var onemillion = 1_000_000;
WriteLine(onemillion);

// native int and native uint uses the size of operating system
// For 32 bit OS it is 32 bit
// For 64 bit OS it is 64 bit
WriteLine($"int.MaxValue = {int.MaxValue:N0}");
WriteLine($"nint.MaxValue = {nint.MaxValue:N0}");
WriteLine($"nuint.MaxValue = {nuint.MaxValue:N0}");