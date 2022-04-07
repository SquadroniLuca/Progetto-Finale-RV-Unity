using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ReceivePoints(GameObject gameObject, int pts);//definisce la funzione che voglio (interfaccia funzione evento)
    public static event ReceivePoints Points;

    public delegate void ReceiveSound(string objTag);
    public static event ReceiveSound Sound;

    public delegate void ReceiveCorrectRecycling();
    public static event ReceiveCorrectRecycling CorrectRecycling;

    public delegate void ReceiveWrongRecycling();
    public static event ReceiveWrongRecycling WrongRecycling;


    internal static void FirePointsEvent(GameObject gameObject, int pts)
    {
        Points?.Invoke(gameObject, pts);
    }

    internal static void FireSoundEvent(string objTag)
    {
        Sound?.Invoke(objTag);
    }

    internal static void FireCorrectRecycling()
    {
        CorrectRecycling?.Invoke();
    }

    internal static void FireWrongRecycling()
    {
        WrongRecycling?.Invoke();
    }
}
