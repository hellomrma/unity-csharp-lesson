using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s01_animal : MonoBehaviour
{
    public string animalName;

    // ���� �Լ�
    public virtual void Speak()
    {
        Debug.Log("�������� ���ϴ� �Ҹ��� ����.");
    }
}
