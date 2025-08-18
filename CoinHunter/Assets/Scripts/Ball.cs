using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
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
            player.Die();

        }

        if(other.CompareTag("Ground"))
        {
            gameObject.SetActive(false);
        }
    }
}
