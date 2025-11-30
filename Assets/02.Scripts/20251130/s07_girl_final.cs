using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s07_girl_final : MonoBehaviour
{

    void Start()
    {
        s06_weapon weaponLaser = new s06_weapon_child01();
        s06_weapon weaponUZI = new s06_weapon_child02();

        s07_girl girlCute = new s07_girl_child01();
        s07_girl girlCool = new s07_girl_child02();


        girlCute.type(); // "�Ϳ��� ����"    
        girlCool.type(); // "������ ����"
    }
}