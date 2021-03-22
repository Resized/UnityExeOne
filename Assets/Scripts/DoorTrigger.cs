using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public GameObject target;
    private Animator anim;
    private AudioSource sound;
    void Start()
    {
        anim = target.gameObject.GetComponent<Animator>();
        sound = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        anim.SetBool("isDoorOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("isDoorOpening", false);

    }

    private void OnTriggerStay(Collider other)
    {
        
    }
    void Update()
    {

    }
}
