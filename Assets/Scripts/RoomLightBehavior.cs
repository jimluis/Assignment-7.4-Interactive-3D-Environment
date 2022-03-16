using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLightBehavior : MonoBehaviour
{

    [SerializeField]Light[] roomLight;

    private void Start()
    {
        //roomLight = gameObject.GetComponent<Light>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("RoomLightBehavior - OnTriggerEnter - other.tag: " + other.tag);

        if (other.CompareTag("Player") && roomLight != null && roomLight.Length > 0)
        { 
            foreach(Light lamp in roomLight)
            {
                lamp.enabled = true;
            }
        }


    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("RoomLightBehavior - OnTriggerStay");
        if (other.CompareTag("Player") && roomLight != null && roomLight.Length > 0)
        {
            foreach (Light lamp in roomLight)
            {
                lamp.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("RoomLightBehavior - OnTriggerExit - other.tag: " + other.tag);

        if (other.CompareTag("Player") && roomLight != null && roomLight.Length > 0)
        {
            foreach (Light lamp in roomLight)
            {
                lamp.enabled = false;
            }
        }
    }
}
