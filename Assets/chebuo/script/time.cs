using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    [SerializeField]public int timeLimit=30;
    [SerializeField] Text timerText;
    float timer;
    public int remaining;
    bool jouken = false;
    [SerializeField] GameObject kaunto;//テキストをくっつけているpanelをいれて
    [SerializeField] Text KeyText;//テキストをいれて
    private AudioSource audioSource;
    //private AudioClip se1;
    //private AudioClip se2;
    Text text;
    public GameObject ClearScene;
    ImageInstantiate imageinstantiate;
    [SerializeField] GameObject chebuspawner;
    public bool isGame = false;
    void Start()
    {
        imageinstantiate = chebuspawner.GetComponent<ImageInstantiate>();
        audioSource = gameObject.GetComponent<AudioSource>();　　//音源ができたらいれて
        text =KeyText.GetComponent<Text>();
        StartCoroutine("CountDown");
        ClearScene.SetActive(false);

    }
    void Update()
    {
        if (jouken)
        {
            timer += Time.deltaTime;
            remaining = timeLimit - (int)timer;
            if (remaining >= 10)
            {
                timerText.text = $"のこり:{remaining.ToString("D2")}秒";
            }
            else if(remaining<10)
            {
                timerText.text = $"のこり:{remaining.ToString("D1")}秒";
            }
            if (remaining <= 0)
            {
                timerText.enabled = false;
                if (!imageinstantiate.make)
                {
                    imageinstantiate.kati = true;
                }
            }
        }
        if (imageinstantiate.kati)
        {
            ClearScene.SetActive(true);
            chebuspawner.SetActive(false);
        }
    }
    IEnumerator CountDown()
    {
        audioSource.Play();
        for (int v = 3; v >= 0; v--)
        {
            
            kaunto.SetActive(true);           
            if (v != 0)
            {
                KeyText.text = "--" + v.ToString()+"--" ; 
                
                yield return new WaitForSeconds(1);//1秒待つ

            }
            else
            {
                //audioSource = gameObject.GetComponent<AudioSource>();
                //audioSource.PlayOneShot(se5);
                KeyText.text = ("守護").ToString();
                isGame=true;
                yield return null;
                
                text.enabled=false;
                Debug.Log("jouken1");
                jouken = true;
                Debug.Log("jouken2");
                yield break;
            }
        }
    }
}
