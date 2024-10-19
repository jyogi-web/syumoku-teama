using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class pointmanager : MonoBehaviour
{
    int[] chebucount = new int[9];

    public void counter(string tagname)
    {
        switch (tagname)
        {
            case "tyachebu":
                chebucount[0] += 1;
                break;
            case "shirochebu":
                chebucount[1] += 10;
                break;
            case "toukyouchebu":
                chebucount[2] += 3;
                break;
            case "nagoyachebu":
                chebucount[3] += 3;
                break;
            case "hiroshimachebu":
                chebucount[4] += 3;
                break;
            case "yamagutichebu":
                chebucount[5] += 3;
                break;
            case "kumamotochebu":
                chebucount[6] += 3;
                break;
            case "mentaichebu":
                chebucount[7] += 5;
                break;
            case "goruchebu":
                chebucount[8] += 20;
                break;
        }
    }
}