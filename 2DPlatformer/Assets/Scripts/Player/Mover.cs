using UnityEngine;

[RequireComponent(typeof(Player), typeof(SpriteFlipper))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Player _player;
    private SpriteFlipper _flipper;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _player = GetComponent<Player>();
        _flipper = GetComponent<SpriteFlipper>();
        _rigidbody = _player.Rigidbody;
    }

    public void Move(float horizontalDirection)
    {
        _rigidbody.velocity = new Vector2(horizontalDirection * _speed, _rigidbody.velocity.y);
        _player.Animator.SetBool("IsRunning", horizontalDirection > 0f | horizontalDirection < 0f);

        if (horizontalDirection < 0f & _flipper.IsTurnedToRight || horizontalDirection > 0f & _flipper.IsTurnedToRight == false)
            _flipper.Flip();
    }
}
