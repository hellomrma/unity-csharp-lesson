using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public enum Fruit { 
     APPLE, BANANA, PEACH, ORANGE
    }

    public Fruit myFruit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (myFruit)
            {
                case Fruit.APPLE:
                    Debug.Log("I love apple!");
                    break;
                case Fruit.BANANA:
                    Debug.Log("I love banana!");
                    break;
                case Fruit.PEACH:
                    Debug.Log("I love peach!");
                    break;
                case Fruit.ORANGE:
                    Debug.Log("I love orange!");
                    break;
            }
        }
    }
}
