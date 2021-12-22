using static System.Console;
namespace Interface;
public class Button : IButton
{
    public void Play()
    {
        WriteLine("You pressed Play");
    }
}

