using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� bulletRigidbody�� �Ҵ�
        bulletRigidbody = GetComponent<Rigidbody>();
        // ������ٵ��� �ӵ� = ���ʹ��� * �̵� �ӷ�
        bulletRigidbody.velocity = transform.forward * speed;

        // transform.forward = ���� ���� ������Ʈ�� ���ʹ����� ��Ÿ���� Vector3 Ÿ�� ����
        // transform�� �ڽ��� ���� ������Ʈ�� Ʈ������ ������Ʈ�� �ٷ� �����ϴ� ����
        // ���� Get.Component<Transform>(); �� �ʿ䰡 ����  (Transform�� Ÿ��, transform�� ����)

        Destroy(gameObject, 3f);
    }

    // Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    void OnTriggerEnter(Collider other)
    {   // OnTrigger �迭�� Collider Ÿ��, OnCollision �迭�� Collision Ÿ���� �Է����� �޴´�

        // �浹�� ���� ���� ������Ʈ�� Player �±׸� ���� ���
        if (other.tag == "Player")      
        {
            // ���� ���� ������Ʈ���� PlayerController ������Ʈ ��������
            PlayerController playerController = other.GetComponent<PlayerController>();


            // �������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ�
            if(playerController != null)
            {   // Die()�� null�Ͻ� ������ ����

                // ���� PlayerController ������Ʈ�� Die() �޼��� ����
                playerController.Die();
            }
        }
    }
}
