using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    // Reference to point text
    public TextMeshProUGUI pointText;
    public float points = -1;

    public void pointsUpdate()
    {
        points++;
        pointText.text = "Points: " + points.ToString("00");
    }

    // Start is called before the first frame update
    void Start()
    {
        pointsUpdate();
    }
}
