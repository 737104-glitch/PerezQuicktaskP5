using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public GameObject player;
    public InputAction MoveAction;
    public Vector2 moveInput;
    public float gravityScale;



    private Rigidbody2D rb; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
           
        rb.linearVelocity = moveInput * speed;
            
     
    }

    void TurnOnGravity()
    {
        rb.gravityScale = gravityScale;
    }

    void OnMove (InputValue value)
    {
        
    }
}

