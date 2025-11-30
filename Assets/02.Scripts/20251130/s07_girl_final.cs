using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s07_girl_final : MonoBehaviour
{

    void Start()
    {
        script1130_06_weapon weaponLaser = new script1130_06_weapon_child01();
        script1130_06_weapon weaponUZI = new script1130_06_weapon_child02();

        s07_girl girlCute = new s07_girl_child01();
        s07_girl girlCool = new s07_girl_child02();


        girlCute.type(); // "귀여운 여성"    
        girlCool.type(); // "차가운 여성"
    }
}