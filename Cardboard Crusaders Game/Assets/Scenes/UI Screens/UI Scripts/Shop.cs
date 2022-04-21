using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WORKS WITH NODE AND BUILDMANAGER


public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint Crossbow;
    public TurretBlueprint spinner;
    public TurretBlueprint canon;
    public TurretBlueprint wall;

    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        Debug.Log("Standard turret Purchased");
        buildManager.SelectTurretToBuild(standardTurret);
    }

    public void SelectCrossbowTurret()
    {
        Debug.Log("Crossbow turret Purchased");
        buildManager.SelectTurretToBuild(Crossbow);
    }
    public void SelectSpinnerTurret()
    {
        Debug.Log("Crossbow turret Purchased");
        buildManager.SelectTurretToBuild(spinner);
    }
    public void SelectCanonTurret()
    {
        Debug.Log("Crossbow turret Purchased");
        buildManager.SelectTurretToBuild(canon);
    }

    public void SelectWall()
    {
        Debug.Log("Wall Purchased");
        buildManager.SelectTurretToBuild(wall);
    }
}
