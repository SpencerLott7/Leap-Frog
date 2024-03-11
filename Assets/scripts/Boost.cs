using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public Transform P1;
    public Transform P2;
    public Transform start1;
    public Transform start2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("P1"))
        {
            //Managers.Inventory.AddItem("Apple");
            //Managers.Player.ChangeHealth(1);
            //ResetPlayerPosition(P1, start1);
            other.gameObject.transform.position = start1.position;
            Debug.Log("here");
        }
        if (other.CompareTag("P2"))
        {
            Managers.Inventory2.AddItem("Apple");
            Managers.Player2.ChangeHealth(1);
            ResetPlayerPosition(P2, start2);
        }
    }

    

    private void ResetPlayerPosition(Transform player, Transform startPosition)
    {
        player.position = startPosition.position;
    }
}
