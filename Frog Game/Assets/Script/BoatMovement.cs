using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    Rigidbody2D rb;

    public float maxSpeed = 12.0f;
    public float minSpeed = 8.0f;

    public float speed = 1.0f;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();


    }
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x * -1, transform.right.y * -1 );
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);

    }
}
