using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] int bosstimeLimit;
    [SerializeField] Text bossTimerText;
    float bosstime;
    void Update()
    {
        bosstime += Time.deltaTime;
        int remaining = bosstimeLimit - (int)bosstime;
        bossTimerText.text = $"ÇÃÇ±ÇËÅF{remaining.ToString("D3")}ïb";
    }
}
