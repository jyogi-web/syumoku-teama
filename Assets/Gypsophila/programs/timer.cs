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
    [SerializeField] GameObject kaunto;//�e�L�X�g���������Ă���panel�������
    [SerializeField] Text KeyText;//�e�L�X�g�������
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
            timerText.text = $"�̂���F{remaining.ToString("D3")}�b";
        }
    }

    IEnumerator CountDown()
    {
        for (int v = 3; v >= 0; v--)
        {
            kaunto.SetActive(true);
            yield return new WaitForSeconds(1);//1�b�҂�
            if (v != 0)
            {
                KeyText.text = v.ToString();
                //audioSource = gameObject.GetComponent<AudioSource>();�@�@�������ł����炢���
                //audioSource.PlayOneShot(se4);
            }
            else
            {
                //audioSource = gameObject.GetComponent<AudioSource>();
                //audioSource.PlayOneShot(se5);
                KeyText.text = ("���").ToString();
                yield return new WaitForSeconds(2);
                kaunto.SetActive(false);
            }

        }
        jouken = true;
        yield break;
    }
}
