using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameTime : MonoBehaviour
{
    float GTime = 0; //������ �����ϰ� ������ ��� �ð��� ��� ���� 
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
