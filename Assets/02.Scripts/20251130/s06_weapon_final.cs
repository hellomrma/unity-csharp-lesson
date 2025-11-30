using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s06_weapon_final : MonoBehaviour
{

    void Start()
    {
        s06_weapon weaponLaser = new s06_weapon_child01();
        s06_weapon weaponUZI = new s06_weapon_child02();

        weaponLaser.Attack(); // "Laser attacks"    
        weaponUZI.Attack();   // "UZI attacks"
    }
}
