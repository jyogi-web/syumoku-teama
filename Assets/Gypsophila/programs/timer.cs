using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] int timeLimit;
    [SerializeField] Text timerText;
    float time;
    private bool jouken;
    [SerializeField] GameObject kaunto;//テキストをくっつけているpanelをいれて
    [SerializeField] Text KeyText;//テキストをいれて
    //private AudioSource audioSource;
    //private AudioClip se1;
    //private AudioClip se2;

    void Start()
    {
        StartCoroutine("CountDown");
    }
    void Update()
    {
        if (jouken == true)
        {
            time += Time.deltaTime;
            int remaining = timeLimit - (int)time;
            timerText.text = $"のこり：{remaining.ToString("D3")}秒";
        }
    }

    IEnumerator CountDown()
    {
        for (int v = 3; v >= 0; v--)
        {
            kaunto.SetActive(true);
            yield return new WaitForSeconds(1);//1秒待つ
            if (v != 0)
            {
                KeyText.text = v.ToString();
                //audioSource = gameObject.GetComponent<AudioSource>();　　音源ができたらいれて
                //audioSource.PlayOneShot(se4);
            }
            else
            {
                //audioSource = gameObject.GetComponent<AudioSource>();
                //audioSource.PlayOneShot(se5);
                KeyText.text = ("守護").ToString();
                yield return new WaitForSeconds(2);
                kaunto.SetActive(false);
            }

        }
        jouken = true;
        yield break;
    }
}
