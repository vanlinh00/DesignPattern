using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1 manager event
public class PlayerHealth : MonoBehaviour
{
  float health = 100;
  public delegate void OnGameOver();
  public static  OnGameOver onGameOver;
    //public void TakeDamage(float damage)
    //{
    //    health -= damage;
    //    if (health < 0)
    //    {
    //        onGameOver?.Invoke();
    //    }
    //}
}