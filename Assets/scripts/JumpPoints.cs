using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JumpPoints : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public Rigidbody player2Rigidbody;
    public TMP_Text winlabel;

    public TMP_Text points1L;
    public TMP_Text points2L;

    // Update is called once per frame
    void Update()
    {
        points1L.text = "Player 1 has "+Managers.Player.health.ToString();
        points2L.text = "Player 2 has "+Managers.Player2.health.ToString();
        
        if(Managers.Player.health == 1)
        {
            winlabel.text = "Player 1 Has Won The Game!";
            StopGame();
        }
        if(Managers.Player2.health == 1)
        {
            winlabel.text = "Player 2 Has Won The Game!";
            StopGame();
        }
    }

    void StopGame()
    {
        playerRigidbody.constraints = RigidbodyConstraints.FreezePosition;
        player2Rigidbody.constraints = RigidbodyConstraints.FreezePosition;
    }
}

