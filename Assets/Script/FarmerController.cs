using UnityEngine;

public class FarmerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody2D rb;
    private float speed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Vector2 velocity = Vector2.left * speed;
            rb.linearVelocity = velocity;
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector2 velocity = Vector2.right * speed;
            rb.linearVelocity = velocity;
        }
    }
}
