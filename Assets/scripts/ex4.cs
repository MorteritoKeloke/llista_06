using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex4 : MonoBehaviour
{
    public int start;
    public int end;

    void Start()
    {
        while (start <= end) 
        {
            if (start % 5 == 0) 
            {
                Debug.Log(start);
            }
            
            start++;  //add one to check if it is a multiple of 5 or not
        }
    }
}