using UnityEngine;

public class SpriteFlipper : MonoBehaviour
{
    [SerializeField] private bool _isTurnedToRight;

    public bool IsTurnedToRight { get => _isTurnedToRight; private set => _isTurnedToRight = value; }

    public void Flip()
    {
        transform.localScale = Vector3.Scale(new Vector3(-1f, 1f, 1f), transform.localScale);
        IsTurnedToRight = !IsTurnedToRight;
    }
}
