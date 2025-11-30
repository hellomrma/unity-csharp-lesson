using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // 2025.11.2 - 변수와 자료형
    //private int lastYear = 2024;
    //public int thisYear = 2025;

    //float pi;

    //public string myName;

    //bool isGameOver = false;

    //void Start()
    //{
    //    Debug.Log("이번 연도는 :" + thisYear + "입니다.");

    //    int nextYear = 2026;
    //    Debug.Log("내년 연도는 :" + nextYear + "입니다.");

    //    pi = 3.14f;
    //    Debug.Log("파이 값은 :" + pi + "입니다.");

    //    Debug.Log("내 이름은 :" + myName + "입니다.");

    //    Debug.Log("현재 게임 오버가 되었는지 확인할려면 " + isGameOver + "상태를 보면 됩니다.");

    //    isGameOver = true;
    //    Debug.Log("게임 오버 상태는 :" + isGameOver + "입니다.");
    //}

    //void Update()
    //{
    //    Debug.Log("작년 연도는 :" + lastYear + "입니다.");
    //}

    int hp = 90;

    void Start()
    {
        hp = hp - 100;

        if (hp <= 0)
        {
            Debug.Log("게임 오버!");
        }
    }

}
