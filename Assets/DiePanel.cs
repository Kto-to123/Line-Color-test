using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiePanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
        PlayerHelth.die += GameOver;
    }

    void GameOver()
    {
        panel.SetActive(true);
    }
}
