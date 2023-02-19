using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex5 : MonoBehaviour
{
    public int[] elements;
    private int sum;
   
    void Start()
    {
    foreach (int numbers in elements)
        {

            sum += numbers;//sum everything in the array

        }
        Debug.Log(sum); 
    }
}
