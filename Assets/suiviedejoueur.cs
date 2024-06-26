using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    //distance when the player is caught
    public float followdistance;
    public float catchdistance;
    public float speed;
    public bool iscaught;
    moveplayer moveplayer;



    [SerializeField]
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveplayer = GetComponent<moveplayer>();


        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        iscaught = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.instance.plusdedificulté)
        {
            speed = 5;
        }
        
        Move();
    }

    public void Move()
    {



        //catch the player when the player is near
        if (Vector2.Distance(transform.position, target.position) > followdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        }
    }
}