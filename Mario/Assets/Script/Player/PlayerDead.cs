﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public void playerDead()
    {
        SceneManager.LoadScene("DeathMenu");
    }
}
