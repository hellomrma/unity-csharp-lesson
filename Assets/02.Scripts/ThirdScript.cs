using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    const int DEAD_HP = 0;
    const int DANGER_HP = 40;
    const int WARNING_HP = 60;

    int hp = 100;

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))
        {
            //hp = hp - 20;
            //if (hp <= 0)
            //{
            //    Debug.Log("게임 오버!");
            //}
            //else if (hp <= 40)
            //{
            //    Debug.Log("현재 체력은 :" + hp + "입니다.");
            //    Debug.Log("비상!!");
            //}
            //else if (hp <= 60)
            //{
            //    Debug.Log("현재 체력은 :" + hp + "입니다.");
            //    Debug.Log("조심하세요!!");
            //}
            //else
            //{
            //    Debug.Log("현재 체력은 :" + hp + "입니다.");
            //}

            hp = hp - 20;

            switch (hp)
            {
                case DEAD_HP:
                    Debug.Log("게임 오버!");
                    break;
                case DANGER_HP:
                    Debug.Log("현재 체력은 :" + hp + "입니다.");
                    Debug.Log("비상!!");
                    break;
                case WARNING_HP:
                    Debug.Log("현재 체력은 :" + hp + "입니다.");
                    Debug.Log("조심하세요!!");
                    break;
                default:
                    Debug.Log("기본 메시지 입니다.");
                    break;
            }

        }
    }
}
