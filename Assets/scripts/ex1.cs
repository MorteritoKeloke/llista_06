using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
    void Start()
    {
        for (int i = 100; i >= 0; i -= 2) //because it goes from 100 to 0 even numbers
        {
            Debug.Log(i); //to show our response to the console
        }
    }
}
