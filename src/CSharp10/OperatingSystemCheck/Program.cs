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

