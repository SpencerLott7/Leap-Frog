using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddJump : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;

    private PlayerInput jump1_script;
    private Player2Input jump2_script;
    // Start is called before the first frame update
    void Start()
    {
        jump1_script = P1.GetComponent<PlayerInput>();
        jump2_script = P2.GetComponent<Player2Input>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other) 
    {
        if(other.CompareTag("P1"))
        {
            Managers.Player.addJump(1);
            Destroy(gameObject, 0);
        }
        else if(other.CompareTag("P2"))
        {
            Managers.Player2.addJump(1);
            Destroy(gameObject, 0);
        }
    }
}
