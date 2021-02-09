using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        // Does the playgame function when clicking play button
        playButton.onClick.AddListener(playgame);
        // Closes software when clicking quit button
        quitButton.onClick.AddListener(Application.Quit);
    }

    // Loads level
    void playgame()
    {
        SceneManager.LoadScene(1);
    }
}
