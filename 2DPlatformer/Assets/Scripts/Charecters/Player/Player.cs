using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public Animator Animator { get => _animator; private set => _animator = value; }
    public Rigidbody2D Rigidbody { get; private set; }
    public bool OnGround { get; set; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        Animator.SetBool("IsAlive", true);
    }
}
