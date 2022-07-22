using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class SpawnerConfig : MonoBehaviour
{
    [SerializeField] private int highLevel;
    [SerializeField] private int middleLevel;
    [SerializeField] private int lowLevel;
    [SerializeField] private int defaultXPosition = 25;

    public int DefaultXPosition
    {
        get => defaultXPosition;
    }

    public int GetRandomYPosition()
    {
        int number = Random.Range(0, 3);

        switch (number)
        {
            case 0:
                return highLevel;
            
            case 1:
                return middleLevel;
            
            case 2:
                return lowLevel;
        }

        return 0;
    }
    
}
