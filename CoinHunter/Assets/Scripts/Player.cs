using Unity.VisualScripting;
using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(h, 0f, v);

        if (velocity.magnitude > 1f)
        {
            velocity.Normalize();
        }

        velocity *= speed;

        body.linearVelocity = velocity;

    }

    public void Die()
    {
        Destroy(gameObject);
    }

}

