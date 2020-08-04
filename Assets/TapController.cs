using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{
    [SerializeField] PathCreation.Examples.PathFollower player;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            player.speed = 5f;
        }
        else
        {
            player.speed = 0f;
        }
    }
}
