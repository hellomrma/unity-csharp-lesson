using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1130_05_enermy_final : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        script1130_05_enermy enermyGoblin = new script1130_05_enermy_child01();
        script1130_05_enermy enermySlime = new script1130_05_enermy_child02();
        script1130_05_enermy enermyOrc = new script1130_05_enermy_child03();

        enermyGoblin.Die(); // "고블린이 죽었습니다."
        enermySlime.Die();  // "슬라임이 사라졌습니다."
        enermyOrc.Die();    // "오크가 사망하였습니다."
    }
}
