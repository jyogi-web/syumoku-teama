using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class haiencontroller : MonoBehaviour
{
    GameObject gauge;
    // Start is called before the first frame update
    void Start()
    {
        gauge = GameObject.Find("ba-");
        
    }

    // Update is called once per frame
    public void IncreaseHP(string name)
    {
        if(name != "fruit")
        {
            gauge.GetComponent<Image>().fillAmount += 0.05f;
        }
        else
        {
            gauge.GetComponent<Image>().fillAmount -= 0.15f;
        }
    }
    //消える直前に肺炎コントローラーをタグの名前を引数に呼び出す。
    //タグがフルーツじゃなかったら肺炎ポイントがたまるか、健康ポイントを減らすのでもいい。0.05ずつくらいでいいかな
}
