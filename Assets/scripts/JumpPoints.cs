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

    // Update is called once per frame
    void Update()
    {
        points1L.text = "Player 1 has "+Managers.Player.health.ToString();
        points2L.text = "Player 2 has "+Managers.Player2.health.ToString();
        }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("P2"))
        {
        float pos1=P1.transform.position.y;
        float pos2=P2.transform.position.y;
        if(pos1>pos2){
            Managers.Player2.ChangeHealth(-1);
            Debug.Log("Red has "+Managers.Player2.health);
        }
        else if(pos1<pos2)
        {
            Managers.Player.ChangeHealth(-1);
            Debug.Log("Blue has "+Managers.Player.health);
        }
        else{
        }
        }
    }
}

