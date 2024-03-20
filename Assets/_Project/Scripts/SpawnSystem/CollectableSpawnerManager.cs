using UnityEngine;

public class CollectableSpawnerManager : MonoBehaviour
{
    [SerializeField] private SpawnPointStrategyType _spawnPointStrategyType;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private CollectableData _collectableData;
    [SerializeField] private float _minSpawnInterval, _maxSpawnInterval;

    private ISpawnPointStrategy _spawnPointStrategy;

    private CountdownTimer _spawnTimer;

    private enum SpawnPointStrategyType
    {
        Random
    }

    private CollectableSpawner _spawner;

    private void Awake()
    {
        _spawnPointStrategy = _spawnPointStrategyType switch
        {
            SpawnPointStrategyType.Random => new RandomSpawnPointStrategy(spawnPoints),
            _ => _spawnPointStrategy,
        };

        _spawner = new CollectableSpawner(new CollectableFactory(_collectableData), _spawnPointStrategy);

        float randomTime = Random.Range(_minSpawnInterval, _maxSpawnInterval);
        _spawnTimer = new CountdownTimer(randomTime);
        _spawnTimer.OnTimerStop += () =>
        {
            Spawn();
            _spawnTimer.Reset(randomTime);
            _spawnTimer.Start();
        };
    }

    private void Start() => _spawnTimer.Start();

    private void Update() => _spawnTimer.Tick(Time.deltaTime);

    private void Spawn() => _spawner.Spawn();
}