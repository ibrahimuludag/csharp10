using static System.Console;

var bigNumber = int.MaxValue - 1;
WriteLine($"Number is {bigNumber}");
bigNumber++;
WriteLine($"Number is {bigNumber}");
bigNumber++;
WriteLine($"Number is {bigNumber}");
bigNumber++;
WriteLine($"Number is {bigNumber}");
WriteLine($"There is OverflowException but exception is not thrown becuase the code block is not surrounded with checked");
WriteLine($"Below code block will throw OverflowException");

checked
{
    var newBigNumber = int.MaxValue - 1;
    WriteLine($"Number is {newBigNumber}");
    newBigNumber++;
    WriteLine($"Number is {newBigNumber}");
    newBigNumber++;
    WriteLine($"Number is {newBigNumber}");
    newBigNumber++;
    WriteLine($"Number is {newBigNumber}");
}



