using System;

using UnityEngine;


public class Player : Character
{

    public Player(string name, int health) : base(name, health) { }

    public void Heal(int amount){
        health += amount;
        Debug.Log("Healed by: " + amount +"Total" + health);
    }



    
}
