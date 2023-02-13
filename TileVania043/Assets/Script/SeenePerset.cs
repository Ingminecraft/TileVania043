using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeenePerset : MonoBehaviour
{
    void Awake()
    {
        int numScenePersists = FindObjectsOfType<GameSessionScript>().Length;
        if (numScenePersists > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void RestScenePersist()
    {
        Destroy(gameObject);
    }
}
