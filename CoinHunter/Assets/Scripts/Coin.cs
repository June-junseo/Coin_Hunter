using UnityEngine;

public class Coin : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player player = other.GetComponent<Player>();
            Destroy(gameObject, 0.2f);
            var findGO = GameObject.FindWithTag("GameController");
            var gm = findGO.GetComponent<GameMgr>();
            gm.AddScore(10);
        }
    }

}
