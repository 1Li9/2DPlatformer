using UnityEngine;

public class Jumper : PlayerComponent
{
    [SerializeField] private float _jumpForce;

    public void Jump()
    {
        if (Player.OnGround)
        {
            Player.Animator.SetTrigger("Jump");
            Player.Rigidbody.AddForce(new Vector2(0, _jumpForce));
        }
    }
}
