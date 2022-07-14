using Unit_9;

MyException myException = new MyException("My exception message");

List<Exception> exceptions = new List<Exception>();
exceptions.Add(myException);
exceptions.Add(new FormatException());
exceptions.Add(new NullReferenceException());
exceptions.Add(new ArgumentOutOfRangeException());
exceptions.Add(new DivideByZeroException());

for (int i = 0; i < exceptions.Count; i++)
{
    try
    {
        throw exceptions[i];
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}