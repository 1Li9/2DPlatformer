using UnityEngine;

public class CharacterFlipper : MonoBehaviour
{
    [SerializeField] private bool _isTurnedToRight;

    public bool IsTurnedToRight { get => _isTurnedToRight; private set => _isTurnedToRight = value; }

    public void Flip()
    {
        transform.rotation *= Quaternion.Euler(0f, 180f, 0f);
        IsTurnedToRight = !IsTurnedToRight;
    }
}
