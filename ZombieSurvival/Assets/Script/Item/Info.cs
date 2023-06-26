using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    [SerializeField] float Ry = 0;
    
    void Update()
    {
        transform.Rotate(0, Ry, 0);
    }
}
