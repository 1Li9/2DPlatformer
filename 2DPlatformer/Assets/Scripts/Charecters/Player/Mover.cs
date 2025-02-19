using UnityEngine;

[RequireComponent(typeof(SpriteFlipper))]
public class Mover : PlayerComponent
{
    [SerializeField] private float _speed;

    private SpriteFlipper _flipper;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _flipper = GetComponent<SpriteFlipper>();
        _rigidbody = Player.Rigidbody;
    }

    public void Move(float horizontalDirection)
    {
        _rigidbody.velocity = new Vector2(horizontalDirection * _speed, _rigidbody.velocity.y);
        Player.Animator.SetBool("IsRunning", horizontalDirection > 0f | horizontalDirection < 0f);

        if (horizontalDirection < 0f & _flipper.IsTurnedToRight || horizontalDirection > 0f & _flipper.IsTurnedToRight == false)
            _flipper.Flip();
    }
}
