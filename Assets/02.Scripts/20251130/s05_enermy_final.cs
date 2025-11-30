using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s05_enermy_final : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        s05_enermy enermyGoblin = new s05_enermy_child01();
        s05_enermy enermySlime = new s05_enermy_child02();
        s05_enermy enermyOrc = new s05_enermy_child03();

        enermyGoblin.Die(); // "�������� �׾����ϴ�."
        enermySlime.Die();  // "�������� ��������ϴ�."
        enermyOrc.Die();    // "��ũ�� ����Ͽ����ϴ�."
    }
}
