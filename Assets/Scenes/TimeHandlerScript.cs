using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TimeHandlerScript : MonoBehaviour
{

    public Text timerText;
    private float currentTime;
    public Text lapsText;
    private int lapCounter;
    public Text lapTimeText;
    private float lastLapTime;
    public Text prevLapTime;
    private float prevLapTimeValue;
    private bool flag;

    
    void Start()
    {
        flag = false;     
    }
    public void StartButtonClick()
    {        
        flag = true;        
    }

    void Update()
    {
        if (flag == true)
        {             
            currentTime = Mathf.Round(Time.time);
            timerText.text = currentTime.ToString();
        }
    }

    public void LapsFinishBttonClick()
    {
        CalculateRaceData();
        DisplayRaceData();
    }

    private void CalculateRaceData()
    {
        prevLapTimeValue = lastLapTime;
        lastLapTime =  currentTime;        
        ++lapCounter;        
    }

    private void DisplayRaceData()
    {
        prevLapTime.text = prevLapTimeValue.ToString();
        lapsText.text = lapCounter.ToString();
        lapTimeText.text = lastLapTime.ToString();
    }

    
}
