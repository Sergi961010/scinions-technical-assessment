using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomSpawnPointStrategy : ISpawnPointStrategy
{
    readonly List<Transform> _unusedSpawnPoints;
    readonly Transform[] _spawnPoints;
    public RandomSpawnPointStrategy(Transform[] spawnPoints)
    {
        _spawnPoints = spawnPoints;
        _unusedSpawnPoints = new List<Transform>();
    }
    public Transform NextSpawnPoint()
    {
        if (!_unusedSpawnPoints.Any())
        {
            _unusedSpawnPoints.AddRange(_spawnPoints);
        }

        var randomIndex = Random.Range(0, _unusedSpawnPoints.Count);
        Transform nextSpawnPoint = _unusedSpawnPoints[randomIndex];
        _unusedSpawnPoints.RemoveAt(randomIndex);
        return nextSpawnPoint;
    }
}