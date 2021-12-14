using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTime : MonoBehaviour
{
    float GTime = 0; //게임이 시작하고 나서의 경과 시간을 재기 위한 
    public float GamePlayTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GTime += Time.deltaTime;
        if(GTime > GamePlayTime)
        {
            SceneManager.LoadScene("ClearScene");
        }
    }
}
