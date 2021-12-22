namespace Flags;

[System.Flags]
public enum SecutityAddOn
{
    BlindSpotWarning = 0b0000001,
    ParkingSensor = 0b0000010,
    Abs = 0b0000100,
}