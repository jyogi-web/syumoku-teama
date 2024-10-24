using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class chebucontroller : MonoBehaviour
{
    Vector3 screenCenter;
    Vector3 worldposition;
    float middleposx;
    float middleposy;

    Vector3 mepos;
    float pos;

    float angle;
    float rad;
    float rx;
    float ry;
    float r = 7;
    GameObject gauge;
    public GameObject chebus;
    float speed = 1.5f;
    Image image;
    float MaxHP=100;
    public static float HP=-5;
    float heal=5f;
    float attack=5f;
    int random;
    //int constant = 6;
    //public GameObject chebus;
    // Start is called before the first frame update

    public void OnClick()
    {        
        Destroy(chebus);
    }
    void Awake()
    {
        gauge = GameObject.Find("bar");
        image = gauge.GetComponent<Image>();
        speed = (float)Random.Range(1f,2.5f);
        random = Random.Range(0, 2);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("tower"))
        {       
            Destroy(chebus);
            Increasehp();
        }
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
        worldposition=Camera.main.ScreenToWorldPoint(screenCenter);
        middleposx = worldposition.x;
        middleposy = worldposition.y;
        */
        //自分自身の座標取得
        mepos = this.transform.position;
        //中央に引き寄せる
        image.fillAmount = HP/MaxHP;
        Debug.Log(HP);
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
    }
}
