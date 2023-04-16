using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationspeed = 60f;
    
    void Update()
    {
        // Update �޼���� 1�����Ӵ� �ѹ� �۵��ϴ� �޼����
        // ������������ �������� �ϸ� 120FPS�� 60FPS ���� ���� �ٸ��� �۵��Ѵ�
        // ���� 1�ʿ� 60�� ȸ���� �����Ϸ���
        // 60�� ȸ�� X (�ʴ� �������� ����) X (�ʴ� �����Ӹ�ŭ �۵�) �� ���� �̿�
        // �ʴ� �������� ���� = Time.deltaTime
        transform.Rotate(0f, rotationspeed * Time.deltaTime, 0f);
    }
}
