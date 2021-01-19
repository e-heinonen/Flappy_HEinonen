using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieWhenHitPipe : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(gameObject);
        // Loads the game from the beginning
        SceneManager.LoadScene(0);
    }
}
