/*using System.Collections;
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
    //HealthGauge hpgauge;
    public GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        hpgauge = hp.GetComponent<HealthGauge>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void clickd()
    {
        
        hpgauge.TakeDamage(debugDamageRate);
    }
}
*/