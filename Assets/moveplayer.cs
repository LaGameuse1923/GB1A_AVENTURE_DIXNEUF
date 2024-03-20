
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveplayer : MonoBehaviour
{
    [SerializeField]
    private KeyCode leftKey = KeyCode.LeftArrow, rightKey = KeyCode.RightArrow;

    [SerializeField]
    private Rigidbody2D rgbd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgbd.AddForce(Vector2.left * 5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rgbd.AddForce(Vector2.right * 5);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rgbd.AddForce(Vector2.up * 5);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rgbd.AddForce(Vector2.down * 5);
        }
    }

}
   


