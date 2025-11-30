using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1130_01_animal : MonoBehaviour
{
    public string animalName;

    // 가상 함수
    public virtual void Speak()
    {
        Debug.Log("동물들은 말하는 소리를 낸다.");
    }
}
