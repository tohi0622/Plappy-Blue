using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_move : MonoBehaviour
{
    public float Level1_speed = 0;
    public float Level2_speed = 0;
    public float Level3_speed = 0;
    public float Level1Time = 0;
    public float Level2Time = 0;
    float makeTime;
    float OverTime = 0;


    void Start()
    {
        makeTime = Time.time;
         
    }


    void Update()
    {
        OverTime += Time.deltaTime;
        transform.Translate(Level1_speed * Time.deltaTime, 0, 0);
        if (Time.time - makeTime > 100f)
            Destroy(gameObject);
        if (OverTime > Level1Time)
            Level1_speed = Level2_speed;
        if (OverTime > Level2Time)
            Level1_speed = Level3_speed;
    }
}