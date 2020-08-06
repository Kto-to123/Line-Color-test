using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHelth : MonoBehaviour
{
    public static UnityAction die;

    private void OnTriggerEnter(Collider other)
    {
        die?.Invoke();
    }
}
