using UnityEngine;

public struct InputInformation
{
    public float Axis { get; }
    public KeyCode KeyCode { get; }

    public InputInformation(float axis, KeyCode keyCode)
    {
        Axis = axis;
        KeyCode = keyCode;
    }
}
