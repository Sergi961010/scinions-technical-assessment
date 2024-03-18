using UnityEngine;

public class CollectableController : MonoBehaviour, ICollectable
{
    [SerializeField] protected CollectableData _collectableData;
    protected virtual void Collect()
    {
        Destroy(gameObject);
    }
}