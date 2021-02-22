using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
     public float timer = 0.0f;
     public int seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
     {
         timer += Time.deltaTime;
         seconds = (int)(timer % 60);
         Debug.Log(seconds);
     }
}
