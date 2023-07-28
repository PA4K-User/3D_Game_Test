using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public  enum PlayerState
{
    None,
    Idle,
    Walk,
    Couch,
    Run,
    Dead,
    win
}
public class Settings : MonoBehaviour
{
    public static PlayerState state;
    public static Transform Player;
    
    public static int KeyItem = 0;

    public static bool pickupCopperCoin = false;
    public static bool pickupSilverCoin = false;
    public static bool pickupGoldCoin = false;

    public static bool isDead = false;
    public static bool isWon = false;
    public static bool isSpawned = false;

    private void Awake()
    {
        Player = GameObject.Find("Player").transform;

        pickupCopperCoin = false;
        pickupSilverCoin = false;
        pickupGoldCoin = false;
        KeyItem = 0;

        isDead = false;
        isWon = false;
        isSpawned = false;
    }

}
