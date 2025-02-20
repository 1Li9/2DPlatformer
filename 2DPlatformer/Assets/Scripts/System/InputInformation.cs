using UnityEngine;

public struct InputInformation
{
    public readonly float Axis;
    public readonly KeyCode KeyCode;

    public InputInformation(float axis, KeyCode keyCode)
    {
        Axis = axis;
        KeyCode = keyCode;
    }

    public InputInformation(float axis)
    {
        Axis = axis;
        KeyCode = 0;
    }
}
