using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class ImageInstantiate : MonoBehaviour
{
    [SerializeField] GameObject[] chebu;
    [SerializeField] GameObject Canvas;
    [SerializeField] GameObject prefab;
    float constant = 2f;
    float time;
    Vector3 screenCenter;
    Vector3 worldposition;
    float middleposx;
    float middleposy;

    float angle;
    float rad;
    float rx;
    float ry;
    float r = 4;
    int chebucount = 0;
    
    time Timer;
    public GameObject countdown;
    [SerializeField] GameObject Finishscreen;
    [SerializeField] GameObject gauge;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        //countdown = GameObject.Find("countdown");
        Timer = countdown.GetComponent<time>();
        image = gauge.GetComponent<Image>();
        StartCoroutine("ImageInstantiater");
        Finishscreen.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
            
        r=Screen.width;
        //screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane);
        //ランダムな位置を取得
        angle = Random.Range(0, 360); //角度のための乱数
        rad = angle * Mathf.Deg2Rad;  //ラジアンにする
        rx = Mathf.Cos(rad) * r;      //ラジアンをCOSにする
        ry = Mathf.Sin(rad) * r;      //ラジアンをSINにする
        time+=Time.deltaTime;
    }
    void FixedUpdate()
    {

        constant = 4-(int)chebucount/10;
        if (image.fillAmount == 1)
        {
            constant = 0;
            Finishscreen.SetActive(true);
        }
    }
    IEnumerator ImageInstantiater()
    {
        yield return new WaitForSeconds(4);
        while (true)
        {   
            int chebuIndex =Random.Range(0, chebu.Length);
            prefab = Instantiate(chebu[chebuIndex],new Vector3(rx,ry,0f),Quaternion.identity);
            prefab.transform.SetParent(Canvas.transform, false);
            yield return new WaitForSeconds(constant);

            chebucount++;
        }
        
    }
}
