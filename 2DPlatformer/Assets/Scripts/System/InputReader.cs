using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);

    [SerializeField] private KeyCode[] _buttons;

    public event Action<InputInformation> OnInputChanged;

    private void Update() =>
        ProcessInput();

    private void ProcessInput() =>
        OnInputChanged?.Invoke(new InputInformation(Input.GetAxisRaw(Horizontal), GetPressedButton()));

    private KeyCode GetPressedButton()
    {
        foreach (KeyCode button in _buttons)
        {
            if (Input.GetKeyDown(button))
                return button;
        }

        return KeyCode.None;
    }
}
