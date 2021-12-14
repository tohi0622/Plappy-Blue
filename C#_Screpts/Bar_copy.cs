using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_copy : MonoBehaviour
{
    public GameObject BarPrefab;
    public float span = 0;
    float nowTime;
    public float range=0;
    float timer = 0;

    void Start()
    {
        nowTime = Time.time;
    }
    void Update()
    {
        this.timer += Time.deltaTime;
        if (this.timer > 0.5)
        {
            if (Time.time - nowTime > span)
            {
                nowTime = Time.time;
                GameObject clone = Instantiate(BarPrefab) as GameObject;
                clone.transform.position = new Vector3(3, Random.Range(-range, range), 0);
                //go.transform.position = new Vector3(0, Random.Range(-1,1), 0);
                //Debug.Log(range);
            }

        }
    }
}