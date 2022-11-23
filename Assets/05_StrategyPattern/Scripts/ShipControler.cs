using UnityEngine;
using System.Collections;
public enum WeaponType
{
    Missile,
    Bullet
}
public enum Flame
{
    Blue,
    Red
}
public class ShipControler : MonoBehaviour
{

    #region variables
    public WeaponType weaponType;
    public Flame flameColor;

    private IWeapon iWeapon;
    private IFlame iFlame;
    #endregion

    private void HandleWeaponType()
    {

        //To prevent Unity from creating multiple copies of the same component in inspector at runtime
        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }

        #region Strategy
        switch (weaponType)
        {

            case WeaponType.Missile:
                iWeapon = gameObject.AddComponent<Missile>();
                break;

            case WeaponType.Bullet:
                iWeapon = gameObject.AddComponent<Bullet>();
                break;

            default:
                iWeapon = gameObject.AddComponent<Bullet>();
                break;
        }
        #endregion
    }

    public void HandleFlameColor()
    {

        Component c = gameObject.GetComponent<IFlame>() as Component;

        if (c != null)
        {
            Destroy(c);
        //    iFlame.DestroyFlame(); // so that number of flame objects remains one
        }

        #region Strategy
        switch (flameColor)
        {

            case Flame.Blue:
                iFlame = gameObject.AddComponent<BlueFlame>();
                break;

            case Flame.Red:
                iFlame = gameObject.AddComponent<RedFlame>();
                break;

            default:
                iFlame = gameObject.AddComponent<BlueFlame>();
                break;
        }
        #endregion

    }

    public void Fire()
    {
        iWeapon.Shoot();
    }

    void Start()
    {

        HandleWeaponType(); //to check the value of weaponType in the inspector initially
        HandleFlameColor();
        iFlame.ShowFlame();
    }

    float countTimeShot = 0f;
    void Update()
    {
        countTimeShot += Time.deltaTime;
        if (countTimeShot>=0.5f)
        {
            countTimeShot = 0;
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }

        //to check the value of weaponType in the inspector while in play mode
        if (Input.GetKeyDown(KeyCode.C))
        {
            HandleWeaponType();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            HandleFlameColor();
            iFlame.ShowFlame();
        }
    }
}