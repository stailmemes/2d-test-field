using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player
{
    int health = 100;
    int power = 50;
    string Named= "warrior";


    public player( int health, int power, string Named)
    {
        this.health= health;
        Debug.Log("health is:" + health);
        Debug.Log("Power is:" + power);
        Debug.Log("name is:" + Named);

    }
    public void attack()
    {
        Debug.Log(Named + "is attacking");
    }
    



} //class end
