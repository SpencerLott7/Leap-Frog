using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
   private void OnTriggerEnter (Collider other) 
    {
        if(other.CompareTag("P1"))
        {
            Managers.Inventory.AddItem("Apple");
            Destroy(gameObject, 0);
        }
        else if(other.CompareTag("P2"))
        {
            Managers.Inventory2.AddItem("Apple");
            Destroy(gameObject, 0);
        }
    }
}
