using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update

    int[] myArray = new int[3];
    int[] myArray2 = {3,6,9};

    void Start()
    {
        myArray[0] = 8;
        myArray[1] = 16;
        myArray[2] = 32;

        Debug.Log(myArray[1]);
        Debug.Log(myArray2[2]);

    }
}
