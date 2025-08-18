using System.Threading;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public int ballCount = 80;
    public float ballInterval = 2f;
    public float ballHeight = 10f;

    public Vector2 ballRange = new Vector2(5f, 5f);

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= ballInterval)
        {
            SpawnBall();
            timer = 0f;
        }

    }

    private void SpawnBall()
    {
        Vector3 spawnPos = new Vector3(
            Random.Range(-ballRange.x, ballRange.x),
            ballHeight,
            Random.Range(-ballRange.y, ballRange.y)
        );

        Instantiate(ballPrefab, spawnPos, Quaternion.identity);

    }

}
