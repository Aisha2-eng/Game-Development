using System;

using UnityEngine;



public class GameManager : MonoBehaviour
 {
    void Start(){
        Player player1 = new Player();
        player1.InitializePlayer("Player1", 80);
        player1.Heal(10);
        player1.Heal(true);
        Player.ShowPlayerCount();

        Player player2 =new Player();
        player2.InitializePlayer("Player2", 60);
        player2.Heal(5);
        player2.Heal(true);
        Player.ShowPlayerCount();
    }

 }