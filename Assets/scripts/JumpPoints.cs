using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPoints : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;

    private PlayerInput jump1_script;
    private Player2Input jump2_script;

    public int P1Points;
    public int P2Points;
    // Start is called before the first frame update
    void Start()
    {
        jump1_script = P1.GetComponent<PlayerInput>();
        jump2_script = P2.GetComponent<Player2Input>();
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
            jump1_script.jumpCount++;
            Debug.Log("Blue has "+P1Points);
        }
        else if(pos1<pos2)
        {
            P2Points++;
            jump2_script.jumpCount++;
            Debug.Log("Red has "+P2Points);
        }
        else{

        }
    }
}
