using UnityEngine;

public class Fruit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Character"))
        {
            Destroy(gameObject); 
        }
        if (other.CompareTag("Ground"))
        {
            Destroy(gameObject); 
        }
    }
}