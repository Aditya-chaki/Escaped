using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject timer;
    

   
    void Update()
    {
        Timer t = timer.GetComponent<Timer>();
        t.finish();
    }
}
