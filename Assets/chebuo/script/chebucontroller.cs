using System.Collections;
using System.Collections.Generic;
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

    public GameObject chebus;
    float speed = 1f;
    //int constant = 6;
    //public GameObject chebus;
    // Start is called before the first frame update


    void Start()
    {
        //Destroy(chebus);
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("iti");
        if (col.gameObject.CompareTag("tower"))
        {
            Debug.Log("ni");
            Destroy(chebus);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //�J�����̒����̍��W�擾
        screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane);
        /*�J���������̃��[���h���W
        worldposition=Camera.main.ScreenToWorldPoint(screenCenter);
        middleposx = worldposition.x;
        middleposy = worldposition.y;
        */
        //�������g�̍��W�擾
        mepos = this.transform.position;
        //�����Ɉ����񂹂�
        //transform.position = Vector3.Lerp(transform.position,worldposition,speed*Time.deltaTime);
        transform.position = Vector3.Lerp(transform.position, screenCenter, speed * Time.deltaTime);
        //�����_���Ȉʒu���擾
        angle = Random.Range(0, 360);
        rad = angle * Mathf.Deg2Rad;
        rx = Mathf.Cos(rad) * r;
        ry = Mathf.Sin(rad) * r;
    }
}
