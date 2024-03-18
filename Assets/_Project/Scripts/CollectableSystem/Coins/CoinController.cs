using System;
using UnityEngine;

public class CoinController : CollectableController
{
    public static event Action<int> OnCoinCollected;

    protected override void Collect()
    {
        Debug.Log("Coin Collected");
        OnCoinCollected?.Invoke(_collectableData.points);
    }
}