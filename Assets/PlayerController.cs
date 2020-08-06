using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] PathCreation.Examples.PathFollower player;
    [SerializeField] TapController tapController;
    [SerializeField] float speed = 5f;

    bool live = true;

    private void Start()
    {
        PlayerHelth.die += Die;
    }

    private void OnDestroy()
    {
        PlayerHelth.die -= Die;
    }

    void Die()
    {
        live = false;
        player.speed = 0f;
    }

    private void Update()
    {
        if (!live)
            return;

        if (tapController.click)
        {
            player.speed = speed;
        }
        else
        {
            player.speed = 0f;
        }
    }
}
