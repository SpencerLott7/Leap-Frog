using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : MonoBehaviour
{
    public Transform block;
    public Vector3 startpos;

    public Transform pos1;
    public Transform pos2;

    private float speed = 30;

    private bool yup;

    // Start is called before the first frame update
    void Start()
    {

    }
    void update()
    {
        if(yup)
        {
            float step = speed * Time.deltaTime;
            block.position = Vector3.MoveTowards(block.position, pos2.position, step);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("P1"))
        {
            yup=true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("P1"))
        {
           //block.position = pos1.position;
        }
    }
}
