using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemipatrol : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    public SpriteRenderer graphics;
    private Transform target;
    private int destPoint;

    // Start is called before the first frame update
    void Start()
    {
        target = waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        Debug.Log("MON SERPENT" + transform.position);
        Debug.Log("LE WAYPOINT" + target.position);
        //Debug.Log(Mathf.Abs(transform.position.x - target.position.x));
        //if (Vector2.Distance(transform.position, target.position) < 0.3f){
        if (Mathf.Abs(transform.position.x - target.position.x) < 0.3f) {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
            graphics.flipX = !graphics.flipX;
        }
    }
}               
