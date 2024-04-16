public class MyExpensiveService
{
    private readonly ILogger<MyExpensiveService> _logger;
    private readonly Lazy<IExpensiveService1> _expensiveService1;
    private readonly Lazy<IExpensiveService2> _expensiveService2;

    private readonly IConfiguration _configuration;

    public MyExpensiveService(ILogger<MyExpensiveService> logger,Lazy<IExpensiveService1> expensiveService1, Lazy<IExpensiveService2> expensiveService2, IConfiguration configuration)
    {
        _logger = logger;
        _expensiveService1 = expensiveService1;
        _expensiveService2 = expensiveService2;
        _configuration = configuration;
    }

    public void DoSomethingThatNeedsExpensiveWork()
    {
        _logger.LogInformation("Doing something that needs expensive work...");
        var exp1 = _expensiveService1.Value;
        if(exp1 != null) exp1.DoExpensiveWork();
        if(!_expensiveService2.IsValueCreated) _logger.LogInformation("expensive work2 not created");
    }
}