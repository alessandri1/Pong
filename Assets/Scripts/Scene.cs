﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scene : MonoBehaviour
{
    public void sceneChange(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
}
