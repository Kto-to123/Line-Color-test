using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Start()
    {
        panel.SetActive(false);
        Finish.GameWin += GameWin;
    }

    void GameWin()
    {
        panel.SetActive(true);
    }
}
