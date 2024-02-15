using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPoints : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public int P1Points;
    public int P2Points;
    // Start is called before the first frame update
    void Start()
    {
        P1Points = 0;
        P2Points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter()
    {
        float pos1=P1.transform.position.y;
        float pos2=P2.transform.position.y;
        if(pos1>pos2){
            P1Points++;
            Debug.Log("Blue has "+P1Points);
        }
        else if(pos1<pos2)
        {
            P2Points++;
            Debug.Log("Red has "+P2Points);
        }
        else{

        }
    }
}
