using UnityEngine;

[RequireComponent(typeof(Rigidbody2D),typeof(CharacterFlipper), typeof(InputReader))]
public class Mover : Player
{
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;
    private CharacterFlipper _flipper;
    private InputReader _reader;

    private void OnEnable()
    {
        _reader = GetComponent<InputReader>();
        _reader.OnInputChanged += Move;
    }

    private void OnDisable() =>
        _reader.OnInputChanged -= Move;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _flipper = GetComponent<CharacterFlipper>();
    }

    private void Move(InputInformation information)
    {
        if(StateMachine.GetBool(PlayerAnimatorData.Params.IsAlive) == false) 
            return;

        float horizontalDirection = information.Axis;

        _rigidbody.velocity = new Vector2(horizontalDirection * _speed, _rigidbody.velocity.y);
        bool isRunning = horizontalDirection > 0f | horizontalDirection < 0f;
        StateMachine.SetBool(PlayerAnimatorData.Params.IsRunning, isRunning);

        if (horizontalDirection < 0f & _flipper.IsTurnedToRight || horizontalDirection > 0f & _flipper.IsTurnedToRight == false)
            _flipper.Flip();
    }
}
