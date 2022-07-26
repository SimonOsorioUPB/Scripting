using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    public float speed = 10;
    
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
