using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToPlay : MonoBehaviour
{
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Space");
    }
    public void LevelSelectButton()
    {
        SceneManager.LoadScene("BedroomLevel V2");
    }

    public void TipsBackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -4);
    }
}
