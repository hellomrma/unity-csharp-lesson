using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1130_06_weapon_final : MonoBehaviour
{

    void Start()
    {
        script1130_06_weapon weaponLaser = new script1130_06_weapon_child01();
        script1130_06_weapon weaponUZI = new script1130_06_weapon_child02();

        weaponLaser.Attack(); // "Laser attacks"    
        weaponUZI.Attack();   // "UZI attacks"
    }
}
