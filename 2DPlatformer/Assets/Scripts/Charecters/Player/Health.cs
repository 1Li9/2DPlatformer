using System;

public class Health : PlayerComponent, IDamageble
{
    public event Action Dead;
    public bool IsAlive { get; private set; } = true;

    private void Start() =>
        Player.Animator.SetBool("IsAlive", true);

    public void TakeDamage()
    {
        if (IsAlive == false)
            return;

        IsAlive = false;
        Player.Animator.SetTrigger("Dead");
        Dead?.Invoke();
    }
}
