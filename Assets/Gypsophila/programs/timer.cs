using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour

{
    [SerializeField] int bosstimeLimit;
    [SerializeField] Text bossTimerText;
    [SerializeField] GameObject count;
    [SerializeField] Text KeyText;
    float bosstime;
    public bool delete = false;
    GameManager gamemanager;
    bosschebu bosschebu;
    void Start()
    {
           
    }
    void Update()
    {
        bosstime += Time.deltaTime;
        int remaining = bosstimeLimit - (int)bosstime;
        bossTimerText.text = $"ÇÃÇ±ÇËÅF{remaining.ToString("D3")}ïb";
        if(remaining <= 0)
    {
            bossTimerText.text = "";
        }
    }
  

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1);

        for (int v = 3; v >= 0; v--)
        {
            count.SetActive(true);
            if (v != 0)
            {
                KeyText.text = v.ToString();
                yield return new WaitForSeconds(1); //1ïbë“Ç¬
            }
            else
            {
                KeyText.text = ("START").ToString();
                yield return new WaitForSeconds(2);
                count.SetActive(false);
                GameObject chebu = GameObject.Find("Chebu");
                bosschebu = chebu.GetComponent<bosschebu>();
                bosschebu.ugoke();
            }
        }
        yield break;
    }

}


