using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField,TextArea(1,2)] string[] texts;//Unity上で入力するstringの配列
    int textNumber;//何番目のtexts[]を表示させるか
    string displayText;//表示させるstring
    int textCharNumber;//何文字目をdisplayTextに追加するか
    int displayTextSpeed; //全体のフレームレートを落とす変数
    bool click;//クリック判定
    bool textStop; //テキスト表示を始めるか
    bool isSelifuEnd = true;//セリフが終わった後に処理をしたかどうか
    float count1second = 0; //1秒間数える
    public GameObject serifu;
    public Text serifutext;
    void Start()
    {
        serifutext= GetComponent<Text>();
    }
    void Update()
    {
            if (textStop == false) //テキストを表示させるif文
            {
                displayTextSpeed++;
                if (displayTextSpeed % 9 == 0)//7s回に一回プログラムを実行するif文
                {

                    if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                    {
                        displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                        textCharNumber = textCharNumber + 1;//次の文字にする
                    }
                    else//もしtext[textNumber]の文字列の文字が最後の文字だったら
                    {
                        if (click == true)//クリックされた判定
                        {
                            displayText = "";//表示させる文字列を消す
                            textCharNumber = 0;//文字の番号を最初にする
                            textNumber = textNumber + 1;//次のセリフにする
                        }
                        else //もしtexts[]が最後のセリフになったら
                        {
                            if (isSelifuEnd) {
                                
                                GameObject startcount = GameObject.Find("Startcount");
                                timer timer = startcount.GetComponent<timer>();
                                timer.StartCoroutine("CountDown");
                                
                                isSelifuEnd = false;
                            }
                            count1second += Time.deltaTime;

                            Debug.Log(count1second);
                            if (count1second >= 0.15)
                            {
                                serifutext.enabled = false;
                                //displayText = ""; //表示させる文字列も消す
                                textCharNumber = 0; //文字の番号を最初にする
                                textStop = true; //セリフ表示を止める
                            }
                    }
                    }

                    this.GetComponent<Text>().text = displayText;//画面上にdisplayTextを表示
                    click = false;//クリックされた判定を解除
                }
                if (Input.GetMouseButton(0))//マウスをクリックしたら
                {
                    click = true; //クリックされた判定にする
                }
            }
    }
}
