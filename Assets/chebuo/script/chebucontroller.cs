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
        //�J�����̒����̍��W�擾
        screenCenter = new Vector3(Screen.width/2,Screen.height/2,Camera.main.nearClipPlane);
        /*�J���������̃��[���h���W
        worldposition=Camera.main.ScreenToWorldPoint(screenCenter);
        middleposx = worldposition.x;
        middleposy = worldposition.y;
        */
        //�������g�̍��W�擾
        mepos = this.transform.position;
        //�����Ɉ����񂹂�
        //transform.position = Vector3.Lerp(transform.position,worldposition,speed*Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position,screenCenter,speed*Time.deltaTime);
        //�����_���Ȉʒu���擾
        angle = Random.Range(0,360);
        rad = angle * Mathf.Deg2Rad;
        rx = Mathf.Cos(rad)*r;
        ry = Mathf.Sin(rad)*r;

    }
}
