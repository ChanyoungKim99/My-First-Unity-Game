using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        // 게임 오브젝트에서 Rigidbody 컴포넌트를 찾아 bulletRigidbody에 할당
        bulletRigidbody = GetComponent<Rigidbody>();
        // 리지드바디의 속도 = 앞쪽방향 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;

        // transform.forward = 현재 게임 오브젝트의 앞쪽방향을 나타내는 Vector3 타입 변수
        // transform은 자신의 게임 오브젝트의 트랜스폼 컴포넌트로 바로 접근하는 변수
        // 굳이 Get.Component<Transform>(); 할 필요가 없다  (Transform은 타입, transform은 변수)

        Destroy(gameObject, 3f);
    }

    // 트리거 충돌 시 자동으로 실행되는 메서드
    void OnTriggerEnter(Collider other)
    {   // OnTrigger 계열은 Collider 타입, OnCollision 계열은 Collision 타입을 입력으로 받는다

        // 충돌한 상대방 게임 오브젝트가 Player 태그를 가진 경우
        if (other.tag == "Player")      
        {
            // 상대방 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();


            // 상대방으로부터 PlayerController 컴포넌트를 가져오는데 성공했다면
            if(playerController != null)
            {   // Die()는 null일시 에러가 난다

                // 상대방 PlayerController 컴포넌트의 Die() 메서드 실행
                playerController.Die();
            }
        }
    }
}
