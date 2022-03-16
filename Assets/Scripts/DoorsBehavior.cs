using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsBehavior : MonoBehaviour
{

    Animator animator;
   [SerializeField] GameObject doorObject;

    private void Start()
    {
        animator = doorObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter - other.tag: " + other.tag);

        if(other.CompareTag("Player"))
            animator.SetBool("isPresent", true);

    }

    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("OnTriggerStay");
    //    animator.SetBool("isPresent", true);
    //}

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit - other.tag: " + other.tag);

        if (other.CompareTag("Player"))
            animator.SetBool("isPresent", false);
    }

   
}
