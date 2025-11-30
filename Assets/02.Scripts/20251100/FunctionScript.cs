using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EnermyAttack();
        EnermyAttack();
        EnermyAttack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnermyAttack()
    {
        Debug.Log("Enermy Attack!");
        Debug.Log("Enermy Damaged");
        Debug.Log("Enermy HP UI Update");
    }
}
