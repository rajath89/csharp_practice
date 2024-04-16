public class TransientService
{
    public Guid ServiceId { get; } = Guid.NewGuid();

    public string Serve() => $"{ServiceId}";
}