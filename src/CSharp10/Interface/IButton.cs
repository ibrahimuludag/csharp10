using static System.Console;

namespace Interface;
public interface IButton
{
    void Play();
    void Stop() => WriteLine("You pressed Stop");
}

