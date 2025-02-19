using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    private readonly float _velosityGate = .2f;

    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundCheckDistance;

    private bool _onGround;
    private int _groundLayer;

    public Animator Animator { get => _animator; set => _animator = value; }
    public Rigidbody2D Rigidbody { get; set; }
    public bool OnGround { get => _onGround; private set => _onGround = value; }

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        _groundLayer = LayerMask.GetMask("Ground");
        Animator.SetBool("IsAlive", true);
    }

    private void Update() =>
            CheckGround();

    private void CheckGround()
    {
        RaycastHit2D ray = Physics2D.Raycast(_groundCheck.position, Vector2.down, _groundCheckDistance, _groundLayer);
        Debug.DrawLine(_groundCheck.position, _groundCheck.position + Vector3.down * _groundCheckDistance, Color.red);

        if (ray.rigidbody != null & Mathf.Abs(Rigidbody.velocity.y) <= _velosityGate)
            _onGround = true;
        else
            _onGround = false;

        Animator.SetBool("OnGround", _onGround);
    }
}
