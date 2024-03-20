using UnityEngine;

[CreateAssetMenu(fileName = "CollectibleData", menuName = "ScriptableObjects/CollectibleData", order = 1)]
public class CollectableData : ScriptableObject
{
    public GameObject collectablePrefab;
    public int points;
}