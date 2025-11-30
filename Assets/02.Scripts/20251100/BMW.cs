using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMW : Car
{
    // Start is called before the first frame update

    // Car.cs 파일과 연결되어 있음.

    void Start()
    {
        carColor = "Black";
        //carPrice = 150000000;
        carIsStatus = "운행중";
        carMaxSpeed = 250;
    }
}
