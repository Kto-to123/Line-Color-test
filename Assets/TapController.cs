using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapController : MonoBehaviour
{
    public bool click = false;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            click = true;
        }
        else
        {
            click = false;
        }
    }
}
