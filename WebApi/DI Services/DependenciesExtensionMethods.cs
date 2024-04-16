public static class DependenciesExtensionMethods
{
    public static void AddAppDependencies(this IServiceCollection Services)
    {
        Services.AddTransient<TransientService>();
        Services.AddScoped<ScopedService>();
        Services.AddSingleton<SingletonService>();
        Services.AddScoped<ExpensiveService1>();
        Services.AddScoped<ExpensiveService2>();

        // Services.AddScoped<Lazy<IExpensiveService>>(provider =>
        //             new Lazy<IExpensiveService>(() => provider.GetRequiredService<IExpensiveService>()));

        Services.AddScoped<Lazy<IExpensiveService1>>(provider =>
            new Lazy<IExpensiveService1>(() => provider.GetRequiredService<ExpensiveService1>()));

        Services.AddScoped<Lazy<IExpensiveService2>>(provider =>
            new Lazy<IExpensiveService2>(() => provider.GetRequiredService<ExpensiveService2>()));


        Services.AddScoped<MyExpensiveService>();
    }
}