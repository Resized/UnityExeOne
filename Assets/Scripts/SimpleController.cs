using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleController : MonoBehaviour
{
    private CharacterController controller;    // Start is called before the first frame update
    public GameObject playerCamera;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 3.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    private float angularSpeed = 1f;

    private float rx = 0f, ry;


    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        float dx, dz;
        // simple motion
        // transform.Translate(new Vector3(0, 0, 0.1f));

        // mouse input
        rx -= Input.GetAxis("Mouse Y") * angularSpeed; // vertical rotation
        ry = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * angularSpeed; // horizontal rotation

        transform.localEulerAngles = new Vector3(0, ry, 0);
        playerCamera.transform.localEulerAngles = new Vector3(rx, 0, 0);
        // keyboard input
        dx = Input.GetAxis("Horizontal");
        dz = Input.GetAxis("Vertical");
        Vector3 motion = new Vector3(dx, 0, dz);
        motion = transform.TransformDirection(motion * playerSpeed); // now in Global coordinates
                                                                     //Check if cjharacter is grounded
        if (controller.isGrounded == false)
        {
            //Add our gravity Vecotr
            motion += Physics.gravity;
        }

        //Apply our move Vector , remeber to multiply by Time.delta
        controller.Move(motion * Time.deltaTime);
    }
}
