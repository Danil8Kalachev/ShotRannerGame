using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private Transform[] _coinSpawnPoints;

    private void Start()
    {
        int spawnPointNumberCoin = Random.Range(0, _coinSpawnPoints.Length);
        Instantiate(_template, _coinSpawnPoints[spawnPointNumberCoin]);
    }
}