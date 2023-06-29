using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    private float timeValue = 0;
    private TextMeshPro timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        timeValue += Time.deltaTime;
        
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        float hours = Mathf.FloorToInt(timeToDisplay / 3600);
        float minutes = Mathf.FloorToInt((timeToDisplay % 3600) / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}
