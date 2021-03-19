using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGObjectMoveLeft : MonoBehaviour
{
    public float objSpeed;
    public float objHeight;
    public float objY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * objSpeed);
        // Move the pipes back in front of player if they've gone too far
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(15, objY, objHeight);
        }
    }
}
