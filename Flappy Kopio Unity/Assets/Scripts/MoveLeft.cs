using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        // Move the pipes back in front of player if they've gone too far
        if (transform.position.x < -20)
        {
            float randomYpos = UnityEngine.Random.Range(-2, 2);
            transform.position = new Vector3(15, randomYpos, 0);
        }
    }
}
