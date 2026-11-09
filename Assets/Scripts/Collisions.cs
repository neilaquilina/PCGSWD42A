using UnityEngine;

public class Collisions : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I collided with "+ collision.gameObject.name);
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered with "+ collision.gameObject.name);
    }
}
