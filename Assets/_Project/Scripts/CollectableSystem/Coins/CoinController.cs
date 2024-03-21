using System;
using UnityEngine;

public class CoinController : MonoBehaviour, ICollectable
{
    [SerializeField] private CollectableData _collectableData;
    public static event Action<int> OnCoinCollected;

    public void Collect()
    {
        Destroy(gameObject);
        OnCoinCollected?.Invoke(_collectableData.points);
    }
}