using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1130_04 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        script1130_01_animal myDog = new script1130_03_dog();
        script1130_01_animal myCat = new script1130_02_cat();

        myDog.Speak(); // "碍酒瘤绰 港港~ 港港~"    
        myCat.Speak(); // "绊剧捞绰 具克~ 具克~"    

    }
}
