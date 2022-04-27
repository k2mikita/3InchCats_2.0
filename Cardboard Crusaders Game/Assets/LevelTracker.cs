using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTracker : MonoBehaviour
{
    public static bool Bedroom = false;
    public static bool Attic = false;
    public static bool Backyard = false;
    public static bool Kitchen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void winBedroom()
    {
        Bedroom = true;
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


}
