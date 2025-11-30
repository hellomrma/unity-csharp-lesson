using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s08_cat : s08_animal, IWalkable
{

    public void Walk()
    {
        Debug.Log("고양이가 살금살금 걸어간다");
    }

    // 가상 함수 재정의
    public override void Speak()
    {
        Debug.Log("고양이는 야옹~ 야옹~");
    }
}
