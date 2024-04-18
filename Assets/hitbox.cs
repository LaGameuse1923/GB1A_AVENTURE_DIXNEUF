using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{

    [SerializeField] private CircleCollider2D boitedecolision;

    // Start is called before the first frame update
    void Start()
    {
        boitedecolision = transform.Find("HitboxGameObjectName").GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
