using UnityEngine;

[RequireComponent(typeof(Player), typeof(Mover), typeof(Jumper))]
public class KeyboardInput : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const KeyCode JumpButton = KeyCode.Space;

    private Mover _mover;
    private Jumper _jumper;

    private void Start()
    {
        _mover = GetComponent<Mover>();
        _jumper = GetComponent<Jumper>();
    }

    private void Update() =>
        ProcessInput();

    private void ProcessInput()
    {
        float horizontalDirection = Input.GetAxisRaw(Horizontal);
        _mover.Move(horizontalDirection);

        if (Input.GetKeyDown(JumpButton))
            _jumper.Jump();
    }
}
