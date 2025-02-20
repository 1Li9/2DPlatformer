using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public Animator Animator { get => _animator; private set => _animator = value; }
}
