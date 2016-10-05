using UnityEngine;
using System.Collections;

public class NewBehaviourScript2 : MonoBehaviour {
    private CharacterController mycharactercontroller;
    private Vector3 movevector;
    private float gravity = 12.0f;
	// Use this for initialization
	void Start () {
        mycharactercontroller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        movevector = Vector3.zero;

        if (mycharactercontroller.isGrounded)
        {
            movevector.y = 0.0f;
        }
        else
        {
            movevector.y = -12.0f;

        }
        //x

        movevector.x = Input.GetAxisRaw("Horizontal");

        //y

       // movevector.y = -12.0f;

        //z
        movevector.z = Input.GetAxisRaw("Vertical");

        mycharactercontroller.Move(movevector* Time.deltaTime);

    }
}
