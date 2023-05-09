using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notu2 : MonoBehaviour
{
  
    void Update()
    {
        transform.Translate(0, -10*Time.deltaTime, 0);
    }
}
