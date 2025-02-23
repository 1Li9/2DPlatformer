using UnityEngine;

public class Target : MonoBehaviour
{
    public Vector3 Position { get; private set; }

    private void Start() =>
        Position = transform.position;
}
