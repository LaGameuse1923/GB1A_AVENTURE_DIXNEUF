using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{

    public int refspawn;
    public moveplayer recupererindex;
    public int avantindex;
    public string AversB;

    private void Awake()
    {
        recupererindex = GameObject.FindWithTag("Player").GetComponent<moveplayer>();
        avantindex = recupererindex.avantindex;
        if (avantindex == refspawn)
        {
            GameObject.FindWithTag("Player").transform.position = transform.position;
        }



        // GameObject.FindGameObjectsWithTag("Player") = transform.position;
    }
}