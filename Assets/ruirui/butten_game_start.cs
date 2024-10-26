using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //ƒV[ƒ“Ø‚è‘Ö‚¦


public class butten_game_start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(osu);   
    }

    // Update is called once per frame
    void osu()
    {
        SceneManager.LoadScene("SampleScenes");

    }
}
