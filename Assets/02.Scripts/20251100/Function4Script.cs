using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function4Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(PlusNumber(3, 97));
    }

    int PlusNumber(int a, int b)
    {
        int c = a + b;
        return c;
    }
}
