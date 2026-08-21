using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public InputAction MoveAction;
    public float speed = 3.0f;

    Vector2 move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody2d=GetComponent<Rigidbody2D>();
        MoveAction.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        move = MoveAction.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
}
