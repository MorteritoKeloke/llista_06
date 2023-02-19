using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex3 : MonoBehaviour
{
public int countdown; //public variable where we will put the value where the counter will start

    void Start()
    {
        for (int i = countdown; i >= 0; i--) //it will be subtracted from 1 by 1 to the counter
        {
            Debug.Log(i);
        }
    }
}