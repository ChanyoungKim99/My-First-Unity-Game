using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;             // ������ ź���� ���� ������
    public float spawnRateMin = 0.5f;           // �ּ� ���� �ֱ�
    public float spawnRateMax = 3f;             // �ִ� ���� �ֱ�

    private Transform target;                   // �߻��� ���
    private float spawnRate;                    // ���� �ֱ� (spawnRateMin ~ spawnRateMax)
    private float timeAfterSpawn;               // �ֱ� ���� �������� ���� �ð�

    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        // ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        // PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����
        target = FindObjectOfType<PlayerController>().transform;  

        // FindObjectOfType�� ���� �����ϴ� ��� ������Ʈ�� �˻��ϱ� ������
        // Start �޼��� ���� �ʱ⿡ �ѵι� �����ϴ� �޼��忡���� ����ؾ���

        // FindObjectOfType = �ش� Ÿ���� ������Ʈ�� �ϳ��� ã��
        // FindObjectsOfType = �ش� Ÿ���� ������Ʈ�� ��� ã�� �迭�� ��ȯ
    }

    void Update()
    {
        // 60FPS�� ���� ��, 1�ʿ� 60�� ����ǹǷ�
        // ź�� ��ȯ�� �����ӿ� ���缭 ������� 

        // Time.deltaTime = ���� �����Ӱ� ���� ������ ������ �ð� ����
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            // ������ �ð��� ����
            timeAfterSpawn = 0f;

            // bulletPrefab�� ��������
            // transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

            // Instantiate �޼���� �������� ��ȯ�ϹǷ� ���� ���� ǥ�Ⱑ ����

            // ������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);
            // ������ ���� ������ spawnRateMin ~ spawnRateMax ���� ����
            spawnRate = Random.Range(spawnRateMin,spawnRateMax);
        }
    }
}
