using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    [SerializeField] int timeLimit=30;
    [SerializeField] Text timerText;
    float timer;
    bool jouken = false;
    [SerializeField] GameObject kaunto;//�e�L�X�g���������Ă���panel�������
    [SerializeField] Text KeyText;//�e�L�X�g�������
    //private AudioSource audioSource;
    //private AudioClip se1;
    //private AudioClip se2;
    Text text;
    public bool isGame = false;
    void Start()
    {
        text=KeyText.GetComponent<Text>();
        StartCoroutine("CountDown");
    }
    void Update()
    {
        if (jouken == true)
        {
            timer += Time.deltaTime;
            int remaining = timeLimit - (int)timer;
            if (remaining >= 10)
            {
                timerText.text = $"�̂���:{remaining.ToString("D2")}�b";
            }
            else if(remaining<10)
            {
                timerText.text = $"�̂���:{remaining.ToString("D1")}�b";
            }
            if (remaining <= 0)
            {
                timerText.text = "";

            }
        }
       
    }
    IEnumerator CountDown()
    {
        for (int v = 3; v >= 0; v--)
        {
            kaunto.SetActive(true);
            
            if (v != 0)
            {
                KeyText.text = "--" + v.ToString()+"--" ;
                //audioSource = gameObject.GetComponent<AudioSource>();�@�@�������ł����炢���
                //audioSource.PlayOneShot(se4);
                yield return new WaitForSeconds(1);//1�b�҂�
            }
            else
            {
                //audioSource = gameObject.GetComponent<AudioSource>();
                //audioSource.PlayOneShot(se5);
                KeyText.text = ("���").ToString();
                isGame=true;
                yield return new WaitForSeconds(1);
                text.enabled=false;
                jouken = true;
                yield break;
            }
        }
    }
}
