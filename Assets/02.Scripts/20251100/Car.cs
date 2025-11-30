using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // Start is called before the first frame update

    public string carColor;
    private int carPrice;
    public string carIsStatus;
    public int carMaxSpeed;
    public int carMaxFuel;

    // BMW.cs 파일과 연결되어 있음.

    void Start()
    {
        
    }

    public void Driving() {
        Debug.Log("운전중");
    }

    public void pushBrake() {
        Debug.Log("브레이크");
    }

    public void turnLeft() {
        Debug.Log("좌회전");
    }

    public void turnRight() {
        Debug.Log("우회전");
    }

    public void openTrunk() {
        Debug.Log("트렁크 열기");
    }

}
