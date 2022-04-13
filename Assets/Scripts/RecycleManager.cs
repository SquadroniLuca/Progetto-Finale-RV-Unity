using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleManager : MonoBehaviour
{

    void Start()
    {
        EventManager.CorrectRecycling += HandleCorrectRecycle;
        EventManager.WrongRecycling += HandleWrongRecycle;
    }

    private void HandleCorrectRecycle()
    {
        EventManager.FirePointsEvent(10);
    }

    private void HandleWrongRecycle()
    {
        EventManager.FirePointsEvent(-10);
    }
}
