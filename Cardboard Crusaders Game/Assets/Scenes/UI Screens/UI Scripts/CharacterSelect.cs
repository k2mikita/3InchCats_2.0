using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterSelect : MonoBehaviour
{
    
    private void Start()
    {
        Cursor.visible = true;
    }

    public void SelectKnight()
    {
        gameObject.SendMessage("setClass", "Knight");
        SceneManager.LoadScene("BedroomLevel V2");
       // FindObjectOfType<AudioManager>().Stop("BedroomMusic");
    }

    public void SelectMage()
    {
        gameObject.SendMessage("setClass", "Mage");
        SceneManager.LoadScene("BedroomLevel V2");
     //   FindObjectOfType<AudioManager>().Stop("BedroomMusic");
    }

}
