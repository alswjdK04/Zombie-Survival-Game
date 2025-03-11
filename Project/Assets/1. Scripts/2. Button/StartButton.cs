using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

public class StartButton: MonoBehaviour
{
    public void GameSceneChange()
    {
        SceneManager.LoadScene(1);
        Debug.Log("PlayScene Go");
    }
}
