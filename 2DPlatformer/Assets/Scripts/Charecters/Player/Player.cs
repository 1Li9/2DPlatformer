using UnityEngine;

[RequireComponent(typeof(PlayerAnimator))]
public abstract class Player : MonoBehaviour
{
    protected Animator StateMachine;

    private void Awake()
    {
        StateMachine = GetComponent<PlayerAnimator>().Animator;
        SetStateMachineParams();
    }

    private void SetStateMachineParams()
    {
        bool isAlive = true;
        StateMachine.SetBool(PlayerAnimatorData.Params.IsAlive, isAlive);
    }
}
