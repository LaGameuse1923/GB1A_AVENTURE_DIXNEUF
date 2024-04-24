    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class projectille : MonoBehaviour
{


    public float followdistance;
    public float catchdistance;
    public float speed;
    public Transform target;
    // Start is called before the first frame update

    public GameObject objectToDestroy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            // Damage or destroy the enemy.
            Debug.Log("Collision");
            Destroy(objectToDestroy);
        }


    }


    void Awake()
    {

        target = GameObject.FindGameObjectWithTag("Enemy")?.GetComponent<Transform>();
        Invoke("Destroyprojo", 1f); // Activate hitbox after 0.2 seconds.
    }


    // Update is called once per frame
    void Update()
    {
    
        Move();
        
    }

    public void Move()
    {

        //catch the player when the player is near
            
        if (target != null  && Vector2.Distance(transform.position, target.position) > followdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }


    }

    public void Destroyprojo()
    {
        Debug.Log("destroy");
        Destroy(objectToDestroy);
    }
}
