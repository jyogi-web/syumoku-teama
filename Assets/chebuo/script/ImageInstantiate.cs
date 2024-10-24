using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ImageInstantiater");
    }
    // Update is called once per frame
    void Update()
    {
        r=Screen.width;
        //screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane);
        //ƒ‰ƒ“ƒ_ƒ€‚ÈˆÊ’u‚ðŽæ“¾
        angle = Random.Range(0, 360);
        rad = angle * Mathf.Deg2Rad;
        rx = Mathf.Cos(rad) * r;
        ry = Mathf.Sin(rad) * r;
        time+=Time.deltaTime;
    }
    void FixedUpdate()
    {
        constant = 3;
    }
    IEnumerator ImageInstantiater()
    {
        while (true)
        {
            //Debug.Log("ooo");
            int chebuIndex =Random.Range(0, chebu.Length);
            prefab = Instantiate(chebu[chebuIndex],new Vector3(rx,ry,0f),Quaternion.identity);
            prefab.transform.SetParent(Canvas.transform, false);
            yield return new WaitForSeconds(constant);
        }
    }
}
