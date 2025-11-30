using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1123_02_loop2 : MonoBehaviour
{

    int sampleA = 10;
    float sampleB = 3.14f;

    // Start is called before the first frame update
    void Start()
    {

        // 복합 대입 연산자(+=, -=, *=, /=, %=)

        sampleA /= 2;
        sampleB /= 1.23f;

        Debug.Log(sampleA);
        Debug.Log(sampleB);
    }
}
