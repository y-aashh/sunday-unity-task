using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishTarget : MonoBehaviour
{
    public int currentLevel = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "PlayerBall")
        {
            MyEventSystem.I.CompleteLevel(1);
            LevelManager.Instance.LoadNextLevel();
        }
    }
}
