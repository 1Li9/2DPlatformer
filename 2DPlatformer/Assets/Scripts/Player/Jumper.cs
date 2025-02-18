using UnityEngine;

[RequireComponent(typeof(Player))]
public class Jumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Player _player;

    private void Start() =>
        _player = GetComponent<Player>();

    public void Jump()
    {
        if (_player.OnGround)
        {
            _player.Animator.SetTrigger("Jump");
            _player.Rigidbody.AddForce(new Vector2(0, _jumpForce));
        }
    }
}
