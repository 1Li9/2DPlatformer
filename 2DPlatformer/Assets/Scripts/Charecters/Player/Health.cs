using System;

public class Health : Player, IDamageble
{
    public event Action Dead;

    public void TakeDamage()
    {
        if (StateMachine.GetBool(PlayerAnimatorData.Params.IsAlive) == false)
            return;

        StateMachine.SetBool(PlayerAnimatorData.Params.IsAlive, false);
        StateMachine.SetTrigger(PlayerAnimatorData.Params.Dead);
        Dead?.Invoke();
    }
}
