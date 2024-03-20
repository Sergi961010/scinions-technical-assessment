using UnityEngine;

public interface ICollectableFactory
{
    ICollectable Create(Transform spawnPoint);
}
