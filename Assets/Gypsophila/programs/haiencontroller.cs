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
    //�����钼�O�ɔx���R���g���[���[���^�O�̖��O�������ɌĂяo���B
    //�^�O���t���[�c����Ȃ�������x���|�C���g�����܂邩�A���N�|�C���g�����炷�̂ł������B0.05�����炢�ł�������
}
