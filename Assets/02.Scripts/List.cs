using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ListScript : MonoBehaviour
{

    public List<int> myList = new List<int>();
    public List<int> myList2 = new List<int>() { 4, 6, 9 };

    int[] numbers = new int[5];

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(myList2[1]);

        myList.Add(5);
        myList.Add(10);
        myList.Add(15);

        myList.Insert(1, 7); // index 1 위치에 7 추가

        myList.Remove(5); // 값이 5인 항목 제거
        myList.Remove(10); // 값이 5인 항목 제거

        myList.Add(15);
        myList.Add(32);

        myList.Insert(1, 22);
        myList.Insert(2, 52);

        myList.Remove(5);
        myList.RemoveAt(2);
        myList.Add(77);

    }
}
