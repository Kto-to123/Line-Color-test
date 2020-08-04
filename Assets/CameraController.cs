using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 cameraPosition;
    [SerializeField] float t = 0.1f;

    private void Awake()
    {
        cameraPosition = transform.position - player.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + cameraPosition, t);
    }
}
