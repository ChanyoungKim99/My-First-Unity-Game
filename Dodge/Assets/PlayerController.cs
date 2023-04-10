using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start()
    {
        
    }

    void Update()           // Update �޼���� �� �����Ӹ��� ����ȴ�
    {
        if(Input.GetKey(KeyCode.UpArrow) == true)
        {
            // ���� ����Ű �Է��� ������ ��� z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, speed);
        }

        if(Input.GetKey(KeyCode.DownArrow) == true) 
        {
            // �Ʒ��� ����Ű �Է��� ������ ���, -z ���� �� �ֱ�
            playerRigidbody.AddForce(0f, 0f, -speed);
        }

        if(Input.GetKey(KeyCode.LeftArrow) == true) 
        {
            // ���� ����Ű �Է��� ������ ���, -x ���� �� �ֱ�
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }

        if(Input.GetKey(KeyCode.RightArrow) == true) 
        {
            // ������ ����Ű �Է��� ������ ���, x ���� �� �ֱ�
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
    }

    public void Die()   // ź�� ������Ʈ�� Player�� PlayerController�� �����ϰԲ� public���� ����
    {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}