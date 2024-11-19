using System;

using UnityEngine;


public class Enemy : Character
{

    public Enemy(string name , int health): base(name, health){}

    public void Attack(int amount){
        health -= amount;
        Debug.Log("Attacked by: " + amount +"Total" + health);
    }



    
}
