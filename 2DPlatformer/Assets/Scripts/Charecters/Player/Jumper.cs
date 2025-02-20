using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(InputReader))]
public class Jumper : Player
{
    private const KeyCode JumpButton = KeyCode.Space;

    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private InputReader _reader;

    private void OnEnable()
    {
        _reader = GetComponent<InputReader>();
        _reader.OnInputChanged += Jump;
    }

    private void OnDisable() =>
        _reader.OnInputChanged -= Jump;

    private void Start() =>
        _rigidbody = GetComponent<Rigidbody2D>();

    private void Jump(InputInformation information)
    {
        bool canJump = StateMachine.GetBool(PlayerAnimatorData.Params.OnGround) &
            StateMachine.GetBool(PlayerAnimatorData.Params.IsAlive) == true &
            information.KeyCode == JumpButton;

        if (canJump == false)
            return;

        StateMachine.SetTrigger(PlayerAnimatorData.Params.Jump);
        _rigidbody.AddForce(new Vector2(0, _jumpForce));
    }
}
