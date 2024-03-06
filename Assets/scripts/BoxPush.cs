using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPush : MonoBehaviour
{
    public float pushForce = 3.0f;
    void OnControllerColliderHit(ControllerColliderHit hit) {
        //contact = hit;
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body != null && !body.isKinematic) 
        {
        body.velocity = hit.moveDirection * pushForce;
        }
    }
}
