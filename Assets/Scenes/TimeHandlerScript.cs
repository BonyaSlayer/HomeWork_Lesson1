using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeHandlerScript : MonoBehaviour
{

    public Text timerText;
    private float currentTime;
    public Text lapsText;
    private int lapCounter;
    public Text lapTimeText;    

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        currentTime = Mathf.Round(Time.time);
        //lapsText.text = Mathf.Round((currentTime - 4) / 10).ToString();
        timerText.text= currentTime.ToString();
    }

    public void LapsFinishBurrontClick()
    {
        ++lapCounter;
        lapsText.text = lapCounter.ToString();
        lapTimeText.text = Mathf.Round(currentTime).ToString();

    }
}
