using System;

public class Health : PlayerComponent, IDamageble
{
    public event Action Dead;
    public bool IsAlive { get; private set; } = true;

    public void TakeDamage()
    {
        if (IsAlive == false)
            return;

        IsAlive = false;
        Player.Animator.SetTrigger("Dead");
        Dead?.Invoke();
    }
}
