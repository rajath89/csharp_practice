public class ScopedService
{
    public Guid ServiceId { get; } = Guid.NewGuid();

    public string Serve() => $"{ServiceId}";
}