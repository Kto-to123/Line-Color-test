using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHelth : MonoBehaviour
{
    public static UnityAction die;
    [SerializeField] MeshRenderer renderer;

    private void OnDestroy()
    {
        die = null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        renderer.enabled = false;
        GetComponent<BoxCollider>().enabled = false;
        die?.Invoke();
    }
}
