using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GwangSeub : Human
{
    // Start is called before the first frame update
    void Start()
    {
        myName = "마광습";
        Debug.Log(myName);
        Eat();
    }
}
