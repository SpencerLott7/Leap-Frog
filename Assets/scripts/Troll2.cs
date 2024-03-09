using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll2 : MonoBehaviour
{
    public Transform block;
    public Transform targetPosition;
    public Transform initialPosition;

    public float moveSpeed;

    private bool isMoving = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("P2"))
        {
            isMoving = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("P2"))
        {
            isMoving = false;
        }
    }

    private void Update()
    {
        if (isMoving)
        {
            MoveToTarget();
        }
        else
        {
            MoveBack();
        }
    }

    private void MoveToTarget()
    {
        float step = moveSpeed * Time.deltaTime;
        block.position = Vector3.MoveTowards(block.position, targetPosition.position, step);
    }

    private void MoveBack()
    {
        float step = moveSpeed * Time.deltaTime;
        block.position = Vector3.MoveTowards(block.position, initialPosition.position, step);
    }
}
