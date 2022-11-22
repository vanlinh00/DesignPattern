using UnityEngine;

public class DelegateExample : MonoBehaviour
{
    delegate void MyDelegate();
    MyDelegate attack;
    void Start()
    {
        attack += PrimaryAttack;
        attack += SecondaryAttack;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (attack != null)
            {
                attack();
            }
            //attack?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attack = PrimaryAttack;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attack = SecondaryAttack;
        }
    }
    void PrimaryAttack()
    {

        Debug.Log("Primary attack");
    }
    void SecondaryAttack()
    {
        Debug.Log("Secondary attack");

    }
}