using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    
   private void OnTriggerEnter (Collider other) 
    {
        if(other.CompareTag("P1"))
        {
            Managers.Inventory.AddItem("Apple");
            P1.GetComponent<PlayerInput>().AppleSpeed();
            Destroy(gameObject, 0);
        }
        if(other.CompareTag("P2"))
        {
            Managers.Inventory2.AddItem("Apple");
            P2.GetComponent<Player2Input>().AppleSpeed();
            Destroy(gameObject, 0);
        }
    }
}
