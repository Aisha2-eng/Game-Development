using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Assignment10 : MonoBehaviour
{

    int Multi(int num1, int num2){return num1 * num2;}
    // Start is called before the first frame update
    void Start()
    {
        int x = 0;

        for (int i = 0; i < 11; i++){

            x= Multi(i, 5);

            Debug.Log("5 x " + i + " = " + x);
        }

    }
    
}
