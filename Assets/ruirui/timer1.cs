using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class timer1 : MonoBehaviour
{
    [SerializeField] int timeLimit;
    [SerializeField] Text timerText;
    float time;


    void Update()
    {
            time += Time.deltaTime;
            int remaining = timeLimit - (int)time;

            timerText.text = $"�̂���F{remaining.ToString("D2")}�b";
    }
    
}
