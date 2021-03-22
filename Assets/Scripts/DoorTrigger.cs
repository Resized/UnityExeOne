using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject target;
    private Animator anim;
    bool inRange = false;
    bool isDoorOpen = false;
    private void OnTriggerEnter(Collider other)
    {
        //target.transform.RotateAround(target.transform.position, Vector3.up, 90);
        anim.SetBool("isDoorOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        //target.transform.RotateAround(target.transform.position, Vector3.up, -90);
        anim.SetBool("isDoorOpening", false);

    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = target.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
