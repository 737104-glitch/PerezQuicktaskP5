using UnityEngine;

public class GameBorder : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rigidBody2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTrggerEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
