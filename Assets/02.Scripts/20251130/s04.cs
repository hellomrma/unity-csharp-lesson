using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        s01_animal myDog = new s03_dog();
        s01_animal myCat = new s02_cat();

        myDog.Speak(); // "�������� �۸�~ �۸�~"    
        myCat.Speak(); // "�����̴� �߿�~ �߿�~"    

    }
}
