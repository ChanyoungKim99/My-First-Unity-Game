using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationspeed = 60f;
    
    void Update()
    {
        // Update 메서드는 1프레임당 한번 작동하는 메서드다
        // 고정프레임을 기준으로 하면 120FPS와 60FPS 에서 각각 다르게 작동한다
        // 따라서 1초에 60도 회전을 구현하려면
        // 60도 회전 X (초당 프레임의 역수) X (초당 프레임만큼 작동) 의 공식 이용
        // 초당 프레임의 역수 = Time.deltaTime
        transform.Rotate(0f, rotationspeed * Time.deltaTime, 0f);
    }
}
