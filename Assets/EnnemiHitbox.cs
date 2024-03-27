using UnityEngine;


public class Hitbox : MonoBehaviour
{
    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("épée"))
        {
            // Damage or destroy the enemy.
            Debug.Log("Collision");
            Destroy(objectToDestroy);
        }
    }
}
