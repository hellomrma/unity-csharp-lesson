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
                    Debug.Log("»ç°ú´Â ¸ÀÀÖ¾î!");
                    break;
                case Fruit.BANANA:
                    Debug.Log("¹Ù³ª³ª´Â ¸ÀÀÖ¾î!");
                    break;
                case Fruit.PEACH:
                    Debug.Log("º¹¼þ¾Æ´Â ¸ÀÀÖ¾î!");
                    break;
                case Fruit.ORANGE:
                    Debug.Log("¿À·»Áö´Â ¸ÀÀÖ¾î!");
                    break;
            }
        }
    }
}
