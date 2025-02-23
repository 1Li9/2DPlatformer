public class Health
{
    public bool IsAlive { get; private set; } = true;

    public void TakeDamage() =>
        IsAlive = false;
}
