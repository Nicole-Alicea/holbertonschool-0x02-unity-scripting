using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput; // Stores horizontal input values from the player(sphere)
    public float verticalInput; // Stores vertical input values from the player(sphere)
    public float speed = 10f;
    private int score = 0;
    public int health = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        // read values from keyboard
        horizontalInput = Input.GetAxis("Horizontal"); // works with WASD and arrow keys
        verticalInput = Input.GetAxis("Vertical"); // works with WASD and arrow keys

        // move the player(sphere)
        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed); // controls forward and backward movements
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed); // controls right and left movements
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            Debug.Log($"Score: {score}");
            Destroy(other.gameObject);
        }

        if (other.tag == "Trap")
        {
            health--;
            Debug.Log($"Health: {health}");
        }
    
    }
}
