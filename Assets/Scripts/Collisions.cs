using UnityEngine;

public class Collisions : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I collided with "+ collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}
