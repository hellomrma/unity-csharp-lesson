using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{

    public List<int> myList = new List<int>();
    public List<int> myList2 = new List<int>() { 4, 6, 9 };



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myList2[1]);

        myList.Add(5);
        myList.Add(10);

        myList.Insert(1, 7); // index 1 위치에 7 추가

        myList.Add(15);
        myList.Remove(5); // 값이 5인 항목 제거
        myList.RemoveAt(1); // index 1 위치의 값 제거
    }
}
