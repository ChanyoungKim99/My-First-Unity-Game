using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;      // private���� ���������μ� Inspector â���� ǥ�� �ȵ�
    public float speed = 8f;
    void Start()
    {
        // ���� �Ҵ��ϴ� ���� �ƴ�, �ڵ带 ���� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()           // Update �޼���� �� �����Ӹ��� ����ȴ�
    {
        // ������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");         // GetAxis�� ���̽�ƽ ��ȯ�� ���� bool�� �ƴ� float
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)�� ����      [Vector3�� ������ ���Ҹ� ������ Ÿ��]
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // ������ٵ��� �ӵ��� newVelocity �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()   // ź�� ������Ʈ�� Player�� PlayerController�� �����ϰԲ� public���� ����
    {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);

        // ���� �����ϴ� GameManager Ÿ���� ������Ʈ�� ã�Ƽ� ��������
        GameManager gameManager = FindObjectOfType<GameManager>();
        // ������ GameManager ������Ʈ�� EndGame() �޼��� ����
        gameManager.EndGame();
    }
}
