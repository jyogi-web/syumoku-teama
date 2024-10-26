using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class chebucontroller : MonoBehaviour
{
    Vector3 screenCenter;
    Vector3 worldCenter;
    float middleposx;
    float middleposy;

    Vector3 mepos;
    float pos;

    float angle;
    float rad;
    float rx;
    float ry;
    float r = 3;
    GameObject gauge;
    public GameObject chebus;
    public float speed = 1f;
    Image image;
    float MaxHP=100;
    private static float HP=0f;
    public float heal=5f;
    public float attack=5f;
    int random;
    public static int highscore;
    public static int score;
    public bool bosschange = false;
    int check1;
    int check2;
    ImageInstantiate imageinstantiate;
    public GameObject chebuspawner;
    int chebuhit;
    int chebuin;
    //int constant = 6;
    //public GameObject chebus;
    // Start is called before the first frame update

    public void OnClick()
    {        
        Destroy(chebus);
        highscore += score;
        chebuhit++;
        Debug.Log(score);
    }
    void Start()
    {
        gauge = GameObject.Find("bar");
        image = gauge.GetComponent<Image>();
        imageinstantiate = chebuspawner.GetComponent<ImageInstantiate>();
        speed = (float)Random.Range(speed,speed+1.5f);
        random = Random.Range(0, 2);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("tower"))
        {       

            Destroy(chebus);
            chebuin++;
            imageinstantiate.chebucounter--;
            Increasehp();
        }
        image.fillAmount=HP/MaxHP;
    }
    public void Increasehp()
    {
        if (CompareTag("fruit"))
        {
            HP -= heal;
        }
        if (CompareTag("chebu"))
        {
            HP+= attack;
        }
        image.fillAmount = HP / MaxHP;
    }
    // Update is called once per frame
    void Update()
    {
        //カメラの中央の座標取得
        screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane);
        /*カメラ中央のワールド座標
        worldCenter=Camera.main.ScreenToWorldPoint(screenCenter);
        middleposx = worldCenter.x;
        middleposy = worldCenter.y;
        */
        //自分自身の座標取得
        mepos = this.transform.position;
        //中央に引き寄せる
        image.fillAmount = HP/MaxHP;
        //Debug.Log(HP);
        if (random==1)
        {
            transform.position = Vector3.Lerp(transform.position, screenCenter, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Slerp(transform.position, screenCenter, speed * Time.deltaTime);
        }
        //ランダムな位置を取得
        angle = Random.Range(0, 360);
        rad = angle * Mathf.Deg2Rad;
        rx = Mathf.Cos(rad) * r;
        ry = Mathf.Sin(rad) * r;
        
        check1=imageinstantiate.chebuken - chebuhit;
        check2=chebuhit + imageinstantiate.chebucounter;
        if(check1==check2/*&&imageinstantiate.chebucheck>=1*/)
        {
            bosschange=true;
            Debug.Log("fgrr");
        }
        else
        {
            Debug.Log("kawaran");
        }
        if (bosschange)
        {
            Debug.Log("kawaru");
        }
    }
}
