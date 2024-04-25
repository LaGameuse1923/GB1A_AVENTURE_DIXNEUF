using UnityEngine;


public class Hitbox : MonoBehaviour
{
    public GameObject EnnemiPosition;
    public GameObject objectToDestroy;
    public GameObject Soul;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("épée"))
        {
            // Damage or destroy the enemy.
            Debug.Log("Collision");
            Destroy(objectToDestroy);
            Instantiate(Soul, EnnemiPosition.transform.position, Quaternion.identity);
        }


    }
}
