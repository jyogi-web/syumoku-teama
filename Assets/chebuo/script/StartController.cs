using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //ÉVÅ[ÉìêÿÇËë÷Ç¶


public class StartScene : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(osu);
    }

    // Update is called once per frame
    void osu()
    {
        chebucontroller.HP =0;
        SceneManager.LoadScene("chebuo");

    }
}