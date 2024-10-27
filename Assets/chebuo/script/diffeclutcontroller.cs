using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diffeclutcontroller : MonoBehaviour
{
    public static bool Normal = false;
    public static bool Hard = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClickHard()
    {
        Hard = true;
        Normal = false;
    }

    public void OnClickNormal()
    {
        Normal = true;
        Hard = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
