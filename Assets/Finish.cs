using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public static UnityAction GameWin;

    private void OnDisable()
    {
        GameWin = null;
    }

    private void OnTriggerEnter(Collider other)
    {
        GameWin?.Invoke();
    }
}
