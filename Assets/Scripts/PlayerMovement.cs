using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 direction;
    [SerializeField] float speed = 3f;
    public Rigidbody rb;

    //CharacterController cc;
    void Start()
    {
        //cc = gameObject.GetComponent<CharacterController>();
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Make world direction into local direction
        Vector3 newDirection = transform.TransformDirection(direction);
        //Debug.Log("FirstPersonMovement - Update");
        //transform.Translate(direction * speed * Time.deltaTime);


        //move using physics
        rb.MovePosition(rb.position + (newDirection * speed * Time.deltaTime));

    }

    void OnPlayerMovement(InputValue value)
    {
        //Debug.Log("OnPlayerMovement");

        Vector2 movement = value.Get<Vector2>();

        direction.x = movement.x;
        direction.z = movement.y;


    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter - collision.gameObject.name: "+ collision.gameObject.tag);
        //if (collision.gameObject.name == "walls")  // or 
        if(collision.gameObject.CompareTag("walls"))
        {
            Debug.Log("OnCollisionEnter - walls");
            rb.velocity = Vector3.zero;
            direction.x = 0;
            direction.z = 0;
        }
    }




}
