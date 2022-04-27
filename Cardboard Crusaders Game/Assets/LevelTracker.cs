using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{
    public static bool Bedroom;
    public static bool Attic;
    public static bool Backyard;
    public static bool Kitchen;
    public static string currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setLevel(string x)
    {
        currentLevel = x;
    }
    public void winBedroom()
    {
        Bedroom = true;
        Debug.Log("aaaa");
    }
    public void winAttic()
    {
        Attic = true;
    }
    public void winBackyard()
    {
        Backyard = true;
    }
    public void winKitchen()
    {
        Kitchen = true;
    }

    public static bool StatusBedroom()
    {
        return Bedroom;
    }
    public static bool StatusAttic()
    {
        return Attic;
    }
    public static bool StatusBackyard()
    {
        return Backyard;
    }
    public static bool StatusKitchen()
    {
        return Kitchen;
    }
    public static string checkLevel()
    {
        return currentLevel;
    }


}
