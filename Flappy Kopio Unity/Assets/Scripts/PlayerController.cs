using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public UIScript playerUI;
    public float jumpForce;
    public float gravityModifier;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Gets player's rigidbody
        playerRb = GetComponent<Rigidbody>();

        // Resets gravity
        Physics.gravity = new Vector3(0, -9.8F, 0);
        // Gets physics for the gravity
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // Move forward at a fixed speed
        // transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);

        // Player first stops any momentum it had and jumps when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.velocity = Vector3.zero;
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if object's layer is set to "Enemy" (Ground and the pipes have this layer):
        if (other.gameObject.layer == 8)
        {
            // Loads the game from the main menu
            SceneManager.LoadScene(0);
        }

        // If object's layer is set to "Point" (the space between the pipes has that layer so it detects when player has moved through the pipes):
        if (other.gameObject.layer == 9)
        {
            playerUI.pointsUpdate();
            Debug.Log("You have " + playerUI.points + " points!");
        }
    }
}
