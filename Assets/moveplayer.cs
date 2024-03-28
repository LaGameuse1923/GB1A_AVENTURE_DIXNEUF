
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow;

    [SerializeField]

    public Rigidbody2D rb;

    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;
    private float verticalMovement;
    public float speed;
    private Vector3 change;

    private string SceneDeSpawn;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        //horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        //verticalMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        //MovePlayer(horizontalMovement, verticalMovement);

        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");
        if(change != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        rb.MovePosition(transform.position + change * speed * Time.deltaTime
            );

    }


    //void MovePlayer(float _horizontalMovement, float _verticalMovement)
    //{
       // Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
       // rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);


   // }

}


