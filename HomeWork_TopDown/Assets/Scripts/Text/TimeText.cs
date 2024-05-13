using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    // Start is called before the first frame update

    Text timeText;

    private void Awake()
    {
        timeText = GetComponent<Text>();    
    }

    // Update is called once per frame
    void Update()
    {
       timeText.text = DateTime.Now.ToString("HH:mm");
    }


}
