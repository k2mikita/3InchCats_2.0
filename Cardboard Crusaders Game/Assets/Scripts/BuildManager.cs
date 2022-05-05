using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WORKS WITH NODE
//ONLY 1 BUILDMANAGER PER SCENE

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    public static GameObject LastBuilt;
    static bool fuckoff = true;
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        
        }
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject MissileTurretPrefab;
    public GameObject SpinnerPrefab;
    public GameObject CanonPrefab;

    private TurretBlueprint turretToBuild;
    private Node selectedNode;

    public NodeUI nodeUI;
    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    
    public void SelectNode(Node node)
    {
        if(selectedNode == node)
        {
            DeselectNode();
            return;
        }
        selectedNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }
    public void DeselectNode()
    {
        selectedNode = null;
        nodeUI.Hide();
    }
    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;

        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }

    public static void Obstructed()
    {
        Debug.Log("someone pinged me");
        if (LastBuilt != null)
        {
            LastBuilt.GetComponent<Node>().ObstructedTurret();
            LastBuilt = null;
        }
            

        
    }
}
