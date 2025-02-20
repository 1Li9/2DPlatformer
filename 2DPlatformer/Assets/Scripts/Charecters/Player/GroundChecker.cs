using UnityEngine;

public class GroundChecker : Player
{
    [SerializeField] private Transform _groundCheck;
    [Range(0f, 1f)]
    [SerializeField] private float _groundCheckDistance;

    private int _groundLayer;

    private void Start() =>
        _groundLayer = LayerMask.GetMask("Ground");

    private void Update() =>
        CheckGround();

    private void CheckGround()
    {
        RaycastHit2D ray = Physics2D.Raycast(_groundCheck.position, Vector2.down, _groundCheckDistance, _groundLayer);
        Debug.DrawLine(_groundCheck.position, _groundCheck.position + Vector3.down * _groundCheckDistance, Color.red);

        if (ray.rigidbody != null)
            StateMachine.SetBool(PlayerAnimatorData.Params.OnGround, true);
        else
            StateMachine.SetBool(PlayerAnimatorData.Params.OnGround, false);
    }

}
