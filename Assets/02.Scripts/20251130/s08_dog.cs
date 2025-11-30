using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s08_dog : s08_animal, IWalkable
{

    public void Walk()
    {
        Debug.Log("°³°¡ ÆúÂ¦ÆúÂ¦ °É¾î °©´Ï´Ù");
    }

    // °¡»ó ÇÔ¼ö ÀçÁ¤ÀÇ
    public override void Speak()
    {
        Debug.Log("°­¾ÆÁö´Â ¸Û¸Û~ ¸Û¸Û~");
    }
}
