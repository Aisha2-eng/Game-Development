using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        ///Number Generator:
        Random random = new Random();


        while(true){
            int num = random.Next(1, 21);  

            if (num == 5){Debug.Log("its 5 skip this loop"); continue;}

            if (num == 15){break;}

            Debug.Log("Number: "+num);


        }
        Debug.Log("its 15 you are out of the loop");

        ///Funny Sentence Generator:
        
        string[] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int x=0;
        string result = "";

        while(x<7){

            string word1 = words[random.Next(0, words.Length)];
            result += word1 + " ";

            x++;
        }

        Debug.Log("Your sentence is: "+result);

        



    }
    
}
