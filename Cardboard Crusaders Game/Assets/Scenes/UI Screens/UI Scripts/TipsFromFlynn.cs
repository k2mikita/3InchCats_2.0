using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TipsFromFlynn : MonoBehaviour
{
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Space");
    }
    public void LevelSelectButton()
    {
        SceneManager.LoadScene("How To Play");
    }

    public void TipsBackButton()
    {
        SceneManager.LoadScene("Room Select");
    }
}
