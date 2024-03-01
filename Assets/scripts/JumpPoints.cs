using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpPoints : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public TMP_Text winlabel;

    public TMP_Text points1L;
    public TMP_Text points2L;

    public TMP_Text jumps1L;
    public TMP_Text jumps2L;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        points1L.text = "Player 1 has "+Managers.Player.health.ToString();
        //points2L.text = "Player 2 has "+P2Points.ToString();

        jumps1L.text= Managers.Player.jumpCount.ToString();
        //jumps2L.text= .ToString();
        }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("P2"))
        {
        float pos1=P1.transform.position.y;
        float pos2=P2.transform.position.y;
        /*if(pos1>pos2){
            P1Points++;
            Managers.Player.addJump;
            Debug.Log("Blue has "+P1Points);
        }
        else if(pos1<pos2)
        {
            Managers.Player.ChangeHealth(-1);
            jump2_script.jumpCount++;
            Debug.Log("Red has "+P2Points);
        }
        else{
        }*/
        }
    }
}

