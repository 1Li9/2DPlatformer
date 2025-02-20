using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _coinsCount = 0;

    public event Action<int> CoinsCountChanged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out SpawnPoint point))
        {
            _coinsCount += point.GetCoins();
            CoinsCountChanged?.Invoke(_coinsCount);
        }
    }
}
