using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function5Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlusNumber(3, 97));
        Debug.Log(MinusNumber(97, 3));
        Debug.Log(MultiplyNumber(97, 3));
        Debug.Log(DivideNumber(97, 3));
    }

    int PlusNumber(int a, int b)
    {
        int sum = a + b;
        return a + b;
    }

    int MinusNumber(int a, int b)
    {
        int sum = a - b;
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
}
