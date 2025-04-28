using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //ƒV[ƒ“Ø‚è‘Ö‚¦


public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public void osu()
    {
        chebucontroller.HP =0;
        SceneManager.LoadScene("chebuo");

    }
}