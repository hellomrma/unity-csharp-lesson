using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1123_01 : MonoBehaviour

{
    public List<int> myList = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        myList.Add(5);
        myList.Add(10);

        myList.Insert(1, 7); // 1번 인덱스에 7 추가
        myList.Add(15);
        myList.Remove(5);
        myList.RemoveAt(1); // 1번 인덱스 요소 제거

        Debug.Log(myList[0]);
    }
}
