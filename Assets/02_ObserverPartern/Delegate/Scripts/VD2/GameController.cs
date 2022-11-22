using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//https://gamedevbeginner.com/events-and-delegates-in-unity/#delegates
public class GameController : MonoBehaviour
{
    public  int a = 0;
    void RestartGame()
    {
        // Restart the game!
        //Debug.Log("RestartGame");
        a++;
        Debug.Log(a);
    }

    //02 subscribe
    private void OnEnable()
    {
        PlayerHealth.onGameOver += RestartGame;
    }
    // khong  OnDisable no se khi set active no se co nhieu se kien restart can phai huy no di
    private void OnDisable()
    {
        PlayerHealth.onGameOver -= RestartGame;
    }

    /// publiser
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (PlayerHealth.onGameOver != null)
            {
                PlayerHealth.onGameOver();
            }
            //attack?.Invoke();
        }
    }
}
