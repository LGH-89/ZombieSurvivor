using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clone : MonoBehaviour
{
    public GameObject obj;

    private void Start()
    {
        for(int i=0; i<5; i++)
        {
            GameObject ins = Instantiate(obj, obj.transform.position, obj.transform.rotation) as GameObject;
        }
    }
}
