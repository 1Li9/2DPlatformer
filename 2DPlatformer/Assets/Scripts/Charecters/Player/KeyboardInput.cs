using UnityEngine;

[RequireComponent(typeof(Mover), typeof(Jumper), typeof(Health))]
public class KeyboardInput : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const KeyCode JumpButton = KeyCode.Space;

    private Mover _mover;
    private Jumper _jumper;
    private Health _health;

    private void Start()
    {
        _mover = GetComponent<Mover>();
        _jumper = GetComponent<Jumper>();
        _health = GetComponent<Health>();
    }

    private void Update() =>
        ProcessInput();

    private void ProcessInput()
    {
        if (_health.IsAlive == false)
            return;

        float horizontalDirection = Input.GetAxisRaw(Horizontal);
        _mover.Move(horizontalDirection);

        if (Input.GetKeyDown(JumpButton))
            _jumper.Jump();
    }
}
