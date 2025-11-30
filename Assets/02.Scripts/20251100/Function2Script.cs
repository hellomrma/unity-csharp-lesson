using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function2Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ThisYear());
        Debug.Log(NextYear());
    }

    int ThisYear()
    {
        return 2025;
    }
    int NextYear()
    {
        int lastYear = 2025;
        int nextYear = lastYear + 1;
        return nextYear;
    }
}
