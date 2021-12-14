using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
{
    public float jumpPower = 0;
    public AudioClip jumpSE; //20210107 추가
    public AudioClip deadSE; //20210107 추가
    AudioSource playeSE; //20210107 추가
    GameObject jumpNumberUi; //20211008추가(점프 횟수Ui)
   

    // Start is called before the first frame update
    void Start()
    {
        this.playeSE = GetComponent<AudioSource>(); //20210107 추가
        this.jumpNumberUi = GameObject.Find("JumpDirector"); //20211008 추가
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) // GetButtonDown(누르는 순간),GetButtonUp(눌렀다 떼는 순간),GetButton(누르고 있는 동안)
        {//Input.GetMouseButtonDown(1) // GetMouseButtonDown(0): 왼쪽 마우스, GetMouseButtonDown(1):오른쪽 마우스 GetMouseButtonDown(2):휠 마우스
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpPower, 0);
            this.jumpNumberUi.GetComponent<Play_Jump>().JumpAddition();
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        //SceneManager.LoadScene("GameScene");
        SceneManager.LoadScene("over_Scene");
    }
}