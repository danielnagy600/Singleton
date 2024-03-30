//Example: Managing a database connection pool,Caching,Configuration,Resource management
//Logger
//Violates the single responsibility principle: How create and lifecyce management
//IoC
//Where there must be exactly one instance of a class
//Thread-safe

var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Console.WriteLine("Instances are the same.");
}

public class Logger 
{
    private static readonly Lazy<Logger> lazyLogger = new Lazy<Logger>(() => new Logger());

    public static Logger Instance
    {
        get
        {
           return lazyLogger.Value ;
        }
    }
    protected Logger() { }
}