using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1130_02_cat : script1130_01_animal
{
    // 가상 함수 재정의
    public override void Speak()
    {
        Debug.Log("고양이는 야옹~ 야옹~");
    }
}
