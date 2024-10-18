using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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




    float speed = 1f;
    public GameObject[] chebus;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの中央の座標取得
        screenCenter = new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane);
        /*カメラ中央のワールド座標
        worldposition=Camera.main.ScreenToWorldPoint(screenCenter);
        middleposx = worldposition.x;
        middleposy = worldposition.y;
        */
        //自分自身の座標取得
        mepos = this.transform.position;
        //中央に引き寄せる
        //transform.position = Vector3.Lerp(transform.position,worldposition,speed*Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position,screenCenter,speed*Time.deltaTime);
        //ランダムな位置を取得
        angle = Random.Range(0,360);
        rad = angle * Mathf.Deg2Rad;
        rx = Mathf.Cos(rad)*r;
        ry = Mathf.Sin(rad)*r;

    }
}
