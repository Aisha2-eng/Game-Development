using UnityEngine;

public class Character
{
    public string name ;
    public int health ;

    public void set(string name, int health){
        this.name = name;
        this.health = health;
    }
    
    public void get(){
        Debug.Log("Name: " + name + " Health: " + health);
    }

    public Character(string name, int health){
        set(name, health);
    }

}