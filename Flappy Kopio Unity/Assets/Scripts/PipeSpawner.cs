using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float pipeDelay = 1;
    private float prevTime = 0;
    private float currentTime;
    public GameObject pipe;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        currentTime = Time.time;
        if((currentTime - prevTime) > pipeDelay)
        {
            Instantiate(pipe, transform.position, pipe.transform.rotation);
            prevTime = currentTime;
        }
    }
}
