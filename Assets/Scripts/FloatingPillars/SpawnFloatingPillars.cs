using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloatingPillars : MonoBehaviour {

    public int NumPillars;

    Vector3 center;
    float angular_separation; 

    private void Start()
    {
        center = GameObject.FindGameObjectWithTag("base_ground").transform.position; ;
        angular_separation = 360 / NumPillars; 

        SpawnPillars(); 
    }

    void SpawnPillars()
    {

    }

    void SpawnPillar(Vector3 location)
    {


    }

    float CalculateAngle 
}
