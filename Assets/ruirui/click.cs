using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click : MonoBehaviour
{
    float debugDamageRate = 1f;
    //クリックされたときに呼び出されるメソッド
    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     Debug.Log($"オブジェクト{name}がクリックされたよ！");
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
