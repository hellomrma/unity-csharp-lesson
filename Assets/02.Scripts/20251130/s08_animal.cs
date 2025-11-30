using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWalkable
{
    void Walk(); // 메서드 정의만 포함
}

public class s08_animal : MonoBehaviour
{
    public string animalName;

    // 가상 함수
    public virtual void Speak()
    {
        Debug.Log("동물들은 말하는 소리를 낸다.");
    }
}
