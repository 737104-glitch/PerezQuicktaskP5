using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class WinningText : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject WinnerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            WinnerText.SetActive(true);
        }
    }
}
