using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1123_02_loop : MonoBehaviour
{

    int count = 0;
    int[] myArray2 = { 0, 3, 6, 9, 12, 15, 18, 21, 24, 27 };

    public List<int> myList2 = new List<int>() { 4, 6, 9 };

    List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };

    // Start is called before the first frame update
    void Start()
    {
        while (count < 10)
        {
            Debug.Log("미니언 소환");
            count++;

            // 증감 연산자. (++, --)
            // 복합 대입 연산자(+=, -=, *=, /=, %=)

        }

        for (int i = 0; i < 10; i++)
        {
            Debug.Log("미니언 소환" + i);
            Debug.Log(myArray2[i]);
        }

        for (int i = 0; i < myArray2.Length; i++)
        {
            Debug.Log("미니언 소환" + i);
            Debug.Log(myArray2[i]);
        }

        for (int i = 0; i < myList2.Count; i++)
        {
            Debug.Log("미니언 소환" + i);
            Debug.Log(myList2[i]);
        }

        foreach (string name in names)
        {
            Debug.Log(name);
        }



    }
}
