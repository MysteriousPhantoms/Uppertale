using UnityEngine;

public class Moveandspin : MonoBehaviour
{
    public Rigidbody2D RB;
    
    public float Speed = 5;
    public float spinSpeed = 180f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        
        GetComponent<SpriteRenderer>().color = Color.blue;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }
        
        RB.linearVelocity = vel;
        
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
    }
}