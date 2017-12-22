using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatPillar : MonoBehaviour {

    public float Start_Time; 
    public float Height_Offset;    

    float time;
    float base_ground_y;

    private void Start()
    {
        time = Start_Time;
        GameObject base_ground = GameObject.FindGameObjectWithTag("base_ground");
        base_ground_y = base_ground.transform.position.y;        
    }

    private void FixedUpdate()
    {   
        if (time > 1000f)
        {
            time = 0;
        }

        float height_value = Mathf.Sin(time);
        //print("TSS: " + time + " Height value: " + height_value);
        time += Time.deltaTime;

        var ts = transform.position;
        transform.position = new Vector3(ts.x, base_ground_y + height_value + Height_Offset, ts.z);
    }
}
