using UnityEngine;

public class Coin : MonoBehaviour
{
    public void Release() =>
        Destroy(gameObject);
}
