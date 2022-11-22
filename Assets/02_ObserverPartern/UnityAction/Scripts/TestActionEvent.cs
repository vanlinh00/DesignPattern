using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestActionEvent : MonoBehaviour
{
    int Count = 0;
    private void OnEnable()
    {
        EventManager.ButttonClick += a;
    }
   private void OnDisable()
    {
        EventManager.ButttonClick -= a;
    }
    public void a()
    {
        Count++;
        Debug.Log(Count);
    }    
}
