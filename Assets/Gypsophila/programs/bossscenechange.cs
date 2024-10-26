using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossscenechange : MonoBehaviour
{
    GameObject pointM;
    pointmanager pointmanager;
    //どのボスを出現させるかと、ミサイルの個数を決めるための判定をここでしておりまする。
    // Start is called before the first frame update
    void Start()
    {
        pointM = GameObject.Find("pointmanager");
        pointmanager = pointM.GetComponent<pointmanager>();
        int total = 0;
        for (int i = 0; i < 10; i++)
        {
            total = total + pointmanager.chebucount[i];
        }
        //現時点でのスコア数によって与えるミサイルの数を変える
        //配列の何番目と肺炎バーがどの位置にあるかによって条件を変える。
        //肺炎コントローラーも参照するようにしないといけない！！
        //この情報をruiruiのボス画面へもっていくためにplayerprefsでデータの受け渡しをする？それとも、壊されないオブジェクトに値をくっつけとくか。ここは要相談。
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
