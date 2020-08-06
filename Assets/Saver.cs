using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
    [SerializeField] LevelsInfoSave save;
    public int levelIndex;

    private void Start()
    {
        Finish.GameWin += Win;
    }

    void Win()
    {
        save.data.levelstates[levelIndex] = SerializableData.LevelStates.Complited;
        if (levelIndex < save.data.levelstates.Length - 1)
        {
            save.data.levelstates[levelIndex + 1] = SerializableData.LevelStates.Open;
        }
        save.SaveData();
    }
}
