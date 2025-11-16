using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamMemory : MonoBehaviour
{

    // Memory (값 형식 Value type, 참조 형식, Reference Type)
    // 값 형식 = Stack에 저장되는 방식, 데이터(값)를 직접 저장하는 방식
    // 참조 형식 = ....
    // stack, Heap 개념
    // Last in First out

    // 값 형식 = Vector3 구조체
    // 참조 형식 = GameObject 클래스

    public int[] myArray = { 1,2 };
    public int[] myArray2;

    // Start is called before the first frame update
    void Start()
    {
        int a = 5;
        int b = a;

        b = 10;

        // Debug.Log(a);
        // Debug.Log(b);

        // print(a);
        // print(b);

        myArray2 = myArray;
        myArray2[1] = 7;

        Debug.Log(myArray);
        Debug.Log(myArray2);

        // 메모리 주소를 같은 곳을 바라보고 있기 때문에 동일하게 1,7이 나온다. (Heap 메모리)


    }
}
