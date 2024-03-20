using UnityEngine;

public class CollectableFactory : ICollectableFactory
{
    CollectableData _collectableData;
    public CollectableFactory(CollectableData collectableData) => _collectableData = collectableData;
    public ICollectable Create(Transform spawnPoint)
    {
        GameObject instance = Object.Instantiate(_collectableData.collectablePrefab, spawnPoint.position, Quaternion.identity);
        return instance.GetComponent<ICollectable>();
    }
}
