using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;

    public Transform target;                //Player

    private float rotSensitive = 3f;
    
    private float RotationMin = -10f;
    private float RotationMax = 60f;
    private float smoothTime = 0.12f;
    private Vector3 targetRotation;
    private Vector3 currentVel;

 

    void LateUpdate()
    {
        Yaxis = Yaxis + Input.GetAxis("Mouse X") * rotSensitive;
        Xaxis = Xaxis - Input.GetAxis("Mouse Y") * rotSensitive;

        Xaxis = Mathf.Clamp(Xaxis, RotationMin, RotationMax);

        targetRotation = Vector3.SmoothDamp(targetRotation, new Vector3(Xaxis, Yaxis), ref currentVel, smoothTime);
        this.transform.eulerAngles = targetRotation;

        transform.position = target.transform.position + new Vector3(0, 3.26f, -2.54f);
    }
}
