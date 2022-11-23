using UnityEngine;
using System.Collections;
public class FlameManager : MonoBehaviour
{
}
public interface IFlame
{
    void ShowFlame();
}
public class BlueFlame : MonoBehaviour, IFlame
{
    public void ShowFlame()
    {
        GameObject blueFlame = Instantiate(Resources.Load("Flame-green", typeof(GameObject))) as GameObject;
        blueFlame.transform.parent = transform;
    }
}
public class RedFlame : MonoBehaviour, IFlame
{

    public void ShowFlame()
    {
        GameObject redFlame = Instantiate(Resources.Load("Flame-red", typeof(GameObject))) as GameObject;
        redFlame.transform.parent = transform;
    }
}