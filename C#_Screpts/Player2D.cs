using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
{
    public float jumpPower = 0;
    public AudioClip jumpSE; //20210107 �߰�
    public AudioClip deadSE; //20210107 �߰�
    AudioSource playeSE; //20210107 �߰�
    GameObject jumpNumberUi; //20211008�߰�(���� Ƚ��Ui)
   

    // Start is called before the first frame update
    void Start()
    {
        this.playeSE = GetComponent<AudioSource>(); //20210107 �߰�
        this.jumpNumberUi = GameObject.Find("JumpDirector"); //20211008 �߰�
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) // GetButtonDown(������ ����),GetButtonUp(������ ���� ����),GetButton(������ �ִ� ����)
        {//Input.GetMouseButtonDown(1) // GetMouseButtonDown(0): ���� ���콺, GetMouseButtonDown(1):������ ���콺 GetMouseButtonDown(2):�� ���콺
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