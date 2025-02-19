using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] GameObjectPool _pool;

    private int _coinsCount = 0;

    public event Action<int> CoinsCountChanged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Coin coin))
        {
            _pool.Release(coin);
            _coinsCount++;
            CoinsCountChanged?.Invoke(_coinsCount);
        }
    }
}
