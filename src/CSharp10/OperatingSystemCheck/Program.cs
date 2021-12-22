if (OperatingSystem.IsWindows())
{
    Console.WriteLine("You running on Windows");
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    Console.WriteLine("You running on Windows 10 or later");
}
else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
{
    Console.WriteLine("You running on IOS at least 14.5");
}
else if (OperatingSystem.IsBrowser())
{
    Console.WriteLine("You running on browser with a Blazor app");
}


#if NET6_0_OR_GREATER
    Console.WriteLine("You running on .NET 6 or greater");
#endif
#if NET6_0_WINDOWS
    Console.WriteLine("You running on .NET 6 or greater on Windows");
#endif
#if NET6_0_IOS
    Console.WriteLine("You running on .NET 6 on IOS");
#endif