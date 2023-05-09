using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notu2 : MonoBehaviour
{
    float speed;

    private void Start()
    {
        speed = 10;
    }
  
    void Update()
    {
        transform.Translate(0, -speed*Time.deltaTime, 0);
    }
}
