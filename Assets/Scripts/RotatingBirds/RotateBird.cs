using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBird : MonoBehaviour {
    
    public GameObject Center_Object;    
    public bool Rotate_Clockwise;
    public float Rotate_Speed;

    Vector3 center_object_center;
    Transform center_object_transform;
    GameObject bird;

    Quaternion start_rotation; 

    private void Start()
    {
        center_object_center = Center_Object.transform.position;

        center_object_transform = Center_Object.GetComponent<Transform>();

        start_rotation = transform.rotation;
    }

    private void FixedUpdate()
    {
        if (Rotate_Clockwise)
        {
            transform.RotateAround(center_object_center, Vector3.up, Rotate_Speed * Time.deltaTime);
            //transform.rotation = start_rotation;
            transform.LookAt(center_object_transform);
        }
        else
        {
            transform.RotateAround(center_object_center, Vector3.up, -Rotate_Speed * Time.deltaTime);
            transform.LookAt(center_object_transform);
            
        }
        
    }
}
