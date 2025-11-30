using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Weapon
{
    public string name;
    public int damage;

    // 기본 생성자
    public Weapon()
    {
        name = "Unknown";
        damage = 10;
    }

    // 매개변수가 있는 생성자
    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
}

public class script1123_04 : MonoBehaviour

{

    public Weapon weapon;

    public script1123_04()
    {
        weapon = new Weapon();

    }

    public script1123_04(string weaponName, int weaponDamage)
    {
        weapon = new Weapon(weaponName, weaponDamage);
    }

    void Start()
    {
        Debug.Log("Player's weapon: " + weapon.name + ", with damage: " + weapon.damage);
    }

}