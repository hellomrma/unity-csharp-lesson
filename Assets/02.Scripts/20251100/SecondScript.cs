using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(8 > 10);
        Debug.Log(2 < 5);
        Debug.Log(5 == 5);
        Debug.Log(6 == 5);
        Debug.Log(7 != 5);
        Debug.Log(7 != 7);
        Debug.Log(3 <= 5);
        Debug.Log(3 <= 3);
        Debug.Log(4 >= 4);
        Debug.Log(2 >= 4);

        Debug.Log(2 != 4 || 6 != 6);
        Debug.Log(2 != 4 && 6 != 6);
        Debug.Log(false == false);
        Debug.Log(false != true);
        Debug.Log(2 != 4);
        Debug.Log(6 != 6);
        Debug.Log(7 != 14);
        Debug.Log(!false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
