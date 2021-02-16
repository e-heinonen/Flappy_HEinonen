using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Gets player's rigidbody
        playerRb = GetComponent<Rigidbody>();
        // Gets physics for the gravity
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Move forward at a fixed speed
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

        // Player jumps when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
