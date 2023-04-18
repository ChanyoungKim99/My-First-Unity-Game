using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody;      // private으로 설정함으로서 Inspector 창에서 표시 안됨
    public float speed = 8f;
    void Start()
    {
        // 직접 할당하는 것이 아닌, 코드를 통해 할당
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()           // Update 메서드는 매 프레임마다 실행된다
    {
        // 수평축과 수직축의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");         // GetAxis는 조이스틱 변환을 위해 bool이 아닌 float
        float zInput = Input.GetAxis("Vertical");

        // 실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 속도를 (xSpeed, 0, zSpeed)로 생성      [Vector3는 세가지 원소를 가지는 타입]
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        // 리지드바디의 속도에 newVelocity 할당
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()   // 탄알 오브젝트가 Player의 PlayerController에 접근하게끔 public으로 설정
    {
        // 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        // 씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기
        GameManager gameManager = FindObjectOfType<GameManager>();
        // 가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        gameManager.EndGame();
    }
}
