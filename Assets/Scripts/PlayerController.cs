using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; // Stores horizontal input values from the player(sphere)
    public float verticalInput; // Stores vertical input values from the player(sphere)
    // public Rigidbody rigidBody;
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the player(sphere)
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed); // controls forward and backward movements
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed); // controls right and left movements
    }
}
