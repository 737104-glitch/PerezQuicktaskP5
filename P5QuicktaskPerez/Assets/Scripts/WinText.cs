using UnityEngine;

public class WinText : MonoBehaviour
{

    GameObject WinnerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rigidbody2d;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool WinText = enabled;
    }
}
