using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSLimiter : MonoBehaviour
{

    void Start()
    {
        // limita o fps (frames per second)
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        
    }
}
