using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleMethod : MonoBehaviour
{

    void Start()
    {
        int sum = AddNumbers (2,4);
        Debug.Log(sum);
    }

    
    int AddNumbers(int x, int y)
    {
        int total = x + y;
        return total;
    }
}
