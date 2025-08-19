using System.Threading;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab; 
    public int coinCount = 20;   
    public Vector3 spawnAreaMin;  
    public Vector3 spawnAreaMax;
    float yOffset = 0.5f;
    private float coinInterval = 2f;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= coinInterval)
        {
            SpawnCoins();
            timer = 0f;
        }
    }

    private void SpawnCoins()
    {
        for (int i = 0; i < coinCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(spawnAreaMin.x, spawnAreaMax.x),
                Random.Range(spawnAreaMin.y, spawnAreaMax.y) + yOffset,
                Random.Range(spawnAreaMin.z, spawnAreaMax.z)
            );

            Quaternion coinRotation = Quaternion.Euler(90f, 0f, 0f);

            GameObject coin = Instantiate(coinPrefab, randomPosition, coinRotation); 
            Destroy(coin, Random.Range(2f, 5f));
        }
    }
}
