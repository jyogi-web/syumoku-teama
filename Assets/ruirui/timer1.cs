using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosstimer : MonoBehaviour
{
    [SerializeField] int timeLimit;
    [SerializeField] Text timerText;
    float time;
    void Update()
    {
        time += Time.deltaTime;
        int remaining = timeLimit - (int)time;
        timerText.text = $"ÇÃÇ±ÇËÅF{remaining.ToString("D3")}ïb";
    }
}
