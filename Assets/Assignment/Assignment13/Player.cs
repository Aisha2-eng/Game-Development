using System;

using UnityEngine;


public class Player 
{
    public string playerName;
    public int health;

    private static int playerCount = 0;
    
    public void InitializePlayer (string playerName , int health){
        this.playerName = playerName;
        this.health = health;
        playerCount++;
        
    }

    public void Heal(int amount){
        health += amount;

        Debug.Log("this player healed by " + amount + " health is now " + health);
    }

    public void Heal(bool fullRestore){
        if(fullRestore){
            health=100;
            Debug.Log("this player has been fully restored");
        }
            
    }

    public static void ShowPlayerCount(){
        Debug.Log("Total player count is " + playerCount);
    }
     
    
    
}
