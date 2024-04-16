public class SingletonService
{
    public Guid ServiceId { get; } = Guid.NewGuid();

    public string Serve() => $"{ServiceId}";
}