using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour

{
    [SerializeField] int bosstimeLimit;
    [SerializeField] Text bossTimerText;
    [SerializeField] GameObject count;
    [SerializeField] Text KeyText;
    [SerializeField] GameObject healthgauge;
    public GameObject boss;
    public Sprite[] bosschebus;
    float bosstime;
    public bool delete = false;
    public bool kaisi = false;
    GameManager gamemanager;
    bosschebu bosschebu;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = boss.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (chebukanti.chebukenin)
        {
            spriteRenderer.sprite = bosschebus[0];
        }
        else
        {
            spriteRenderer.sprite = bosschebus[1];
        }
    }
  

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(2);
        //セリフを""に書き換える
        //for (int v = 3; v >= 0; v--)
        //{
        //    count.SetActive(true);
        //    if (v != 0)
        //    {
        //        KeyText.text = v.ToString();
       //        yield return new WaitForSeconds(1); //1秒待つ
        //    }
        //    else
        //    {
                KeyText.text = ("いくぞ！").ToString();
                healthgauge.SetActive(true);
                yield return new WaitForSeconds(2);
                kaisi = true;
                count.SetActive(false);
                GameObject chebu = GameObject.Find("Chebu");
                Animator animator = chebu.GetComponent<Animator>();
                animator.enabled = false;
                bosschebu = chebu.GetComponent<bosschebu>();
                bosschebu.ugoke();
         //   }
       // }

        yield break;
    }

}


