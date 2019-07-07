using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;


    // Start is called before the first frame update

    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) )
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }



        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag =="Boat")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
