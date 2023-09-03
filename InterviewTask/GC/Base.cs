using InterviewTask.GC;

public class Base : BaseAbstract,  IDisposable
{
    // private static field
   private static int data = 100;

    public Base()
    {
        Console.WriteLine("Base Default Constructor");
    }

    static Base()
    {
        data = 10; 
        Console.WriteLine("Base static Constructor");
    }

    // Flag: Has Dispose already been called?
    bool disposed = false;

    // Public implementation of Dispose pattern callable by consumers.
    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    // Protected implementation of Dispose pattern.
    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
            return;

        if (disposing)
        {
            // Free any other managed objects here.
            //
        }

        disposed = true;
    }

    public override void DoSome()
    {
    }
}