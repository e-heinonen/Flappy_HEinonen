using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieWhenHitPipe : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(gameObject);
    }
}
