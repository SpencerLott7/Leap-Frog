using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddJump : MonoBehaviour
{
    private void OnTriggerEnter (Collider other) 
    {
        if(other.CompareTag("P1"))
        {
            Managers.Player.addJump(1);
            Destroy(gameObject, 0);
        }
        if(other.CompareTag("P2"))
        {
            Managers.Player2.addJump(1);
            Destroy(gameObject, 0);
        }
    }
}
