using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function3Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(NextYear(2025));
    }

    int NextYear(int thisYear)
    {
        int nextYear = thisYear + 1;
        return nextYear;
    }
}
