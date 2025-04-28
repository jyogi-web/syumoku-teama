using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPcontroller : MonoBehaviour
{
    public GameObject clearScreen;
    float count = 0f;
    Image[] image;
    MainManager mainManager;
    // Start is called before the first frame update
    void Start()
    {
        image=GetComponentsInChildren<Image>();
        mainManager= GameObject.Find("MainManager").GetComponent<MainManager>();
        foreach (Image img in image)
        {
            img.fillAmount = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(image[1].fillAmount == 0 && image[2].fillAmount == 0)
        {
            clearScreen.SetActive(true);
            Time.timeScale = 0f;
            Destroy(this.gameObject);
        }
    }
    public void DereateHP()
    {
        if (mainManager.remaining>0)
        {
            image[2].fillAmount -= 0.1f;
            Invoke("DereateGauge",0.5f);
        }
    }
    public void DereateGauge()
    {
        image[1].fillAmount -= 0.1f;
    }
    void WaitTime()
    {
        count = -0.5f;
    }
}
