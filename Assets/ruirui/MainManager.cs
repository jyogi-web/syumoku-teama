using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField, Header("�Q�[���I�[�o�[UI")]
    private GameObject _gameOverUI;
    private GameObject _bosstimer;
    [SerializeField] int timeLimit;
    [SerializeField] Text timerText;
    float time;
    public int remaining = 999;
    timer timer;
    // Start is called before the first frame update
    private void Start()
    {
        GameObject Startcount = GameObject.Find("Startcount");
        timer = Startcount.GetComponent<timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(remaining > 0)
        {
            if (timer.kaisi == true)
            {
                time += Time.deltaTime;
                remaining = timeLimit - (int)time;
                timerText.text = $"�̂���F{remaining.ToString("D2")}�b";
            }
        }
        else if (remaining <= 0) 
        {
            _gameOverUI.SetActive(true);
        }
    }
}
