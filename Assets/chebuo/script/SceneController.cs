using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        SceneManager.LoadScene("bosschebu");
    }
    public void TitileScene()
    {
        SceneManager.LoadScene("titlescene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
