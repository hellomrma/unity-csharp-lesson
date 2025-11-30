using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    // Start is called before the first frame update


    // 인간
    // 이름 string, 성별 string, 직업 - string, 키 - float, 솔로여부 - bool, MBTI - string, 국적 - string
    // 함수 (먹기, 자기, 싸기, 숨쉬기, 잠에서 깨기, 걷기, 달리기, 깜빡이기 등)


    // 클래스의 상속

    public string myName;
    int myAge; // private
    private float myHeight;
    public bool isSolo;

    public void Eat() {
        Debug.Log("먹는다");
    }

    private void Sleep() {
        Debug.Log("잔다");
    }

    void PowerPush() {
        Debug.Log("싼다");
    }
}
