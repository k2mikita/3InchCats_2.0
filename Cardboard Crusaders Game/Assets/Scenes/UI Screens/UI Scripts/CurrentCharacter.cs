using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentCharacter : MonoBehaviour
{
    public static string role = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setClass(string x)
    {
        role = x;
        Debug.Log("Character Selected: " + x);
    }
    public static string getRole()
    {
        return role;
    }
}
