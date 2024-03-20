public class CollectableSpawner
{
    ICollectableFactory _collectableFactory;
    ISpawnPointStrategy _spawnPointStrategy;
    public CollectableSpawner(ICollectableFactory collectableFactory, ISpawnPointStrategy spawnPointStrategy)
    {
        _collectableFactory = collectableFactory;
        _spawnPointStrategy = spawnPointStrategy;
    }
    public void Spawn() => _collectableFactory.Create(_spawnPointStrategy.NextSpawnPoint());
}
