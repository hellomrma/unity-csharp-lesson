using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function6Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlusNumber(3, 97));
        Debug.Log(MinusNumber(97, 3));
        Debug.Log(MinusNumber(97));
        Debug.Log(MinusNumber(97.0f, 3.0f));
        Debug.Log(MultiplyNumber(97, 3));
        Debug.Log(DivideNumber(97, 3));
    }

    int PlusNumber(int a, int b)
    {
        int sum = a + b;
        return a + b;
    }

    // 오버로딩(Overloading) : 동일한 이름의 함수를 매개변수의 타입과 개수로 구분하는 것

    int MinusNumber(int a, int b)
    {
        int sum = a - b;
        return sum;
    }

    int MinusNumber(int a)
    {
        int c = a;
        return c;
    }

    float MinusNumber(float a, float b)
    {
        float sum = a - b;
        return sum;
    }

    int MultiplyNumber(int a, int b)
    {
        int sum = a * b;
        return sum;
    }

    int DivideNumber(int a, int b)
    {
        int sum = a / b;
        return sum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
