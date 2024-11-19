using System;

using UnityEngine;



public class GameManager : MonoBehaviour
 {
    void Start(){
        Player player = new Player("Aisha", 90);
        
        player.Heal(10);

        Enemy enemy = new Enemy("Goblin", 50);
        
        enemy.Attack(10);
    }

 }