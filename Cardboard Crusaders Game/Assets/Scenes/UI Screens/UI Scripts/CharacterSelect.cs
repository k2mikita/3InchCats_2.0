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
        SceneManager.LoadScene(1);

    }

    public void SelectMage()
    {
        gameObject.SendMessage("setClass", "Mage");
        SceneManager.LoadScene(1);

    }

}
