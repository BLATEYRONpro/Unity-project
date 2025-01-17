﻿using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{
    public bool isPlayerPresentByDefault = false;
    public int currentSceneCoinsPickedUp;

    public static CurrentSceneManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Plus d'une instance de CurrentSceneManager dans la scene");
            return;
        }

        instance = this;
    }


}
