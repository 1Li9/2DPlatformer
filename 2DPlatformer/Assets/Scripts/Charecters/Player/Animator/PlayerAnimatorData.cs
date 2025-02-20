using UnityEngine;

public static class PlayerAnimatorData
{
    public static class Params
    {
        public static readonly int OnGround = Animator.StringToHash(nameof(OnGround));
        public static readonly int IsRunning = Animator.StringToHash(nameof(IsRunning));
        public static readonly int Jump = Animator.StringToHash(nameof(Jump));
        public static readonly int IsAlive = Animator.StringToHash(nameof(IsAlive));
        public static readonly int Dead = Animator.StringToHash(nameof(Dead));
    }
}
