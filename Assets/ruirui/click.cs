using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click : MonoBehaviour
{
    float debugDamageRate = 1f;
    //�N���b�N���ꂽ�Ƃ��ɌĂяo����郁�\�b�h
    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     Debug.Log($"�I�u�W�F�N�g{name}���N���b�N���ꂽ��I");
    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void clickd()
    {
        GameObject hp = GameObject.Find("HealthGauge");
        HealthGauge hpgauge = hp.GetComponent<HealthGauge>();
        hpgauge.TakeDamage(debugDamageRate);
    }
}
