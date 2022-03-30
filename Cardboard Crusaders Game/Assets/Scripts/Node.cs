
using UnityEngine;
using UnityEngine.EventSystems;

//CONTROLS THE BUILDABLE SPOT FUNCTIONALITY
//WORKS WITH BUILDMANAGER
//REQUIRES A VISABLE GAME OBJECT FOR EACH BUILDABLE SEGMENT

public class Node : MonoBehaviour
{
    public WaveSpawner waveSpawner;

    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    public static bool buildmode = false;
    private bool render = true;

    [HideInInspector]
    public GameObject turret;

    [HideInInspector]
    public TurretBlueprint turretBlueprint;
    [HideInInspector]
    public bool isUpgraded = false;

    BuildManager buildManager;

    private Renderer rend;
    private Color startColor;
 void Start()
    {
        rend = GetComponent<Renderer>();

        startColor = rend.material.color;

        buildManager = BuildManager.instance;
        Cursor.visible = false;
        waveSpawner = GameObject.FindGameObjectWithTag("GameController").GetComponent<WaveSpawner>();
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
         if (turret != null)
        {
            buildManager.SelectNode(this);

            return;
        }
        if (!buildmode)
            return;
        if (!buildManager.CanBuild)
        {
            this.rend.enabled = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            return;
        }
           
        

        BuildTurret(buildManager.GetTurretToBuild());
    }

    void BuildTurret(TurretBlueprint blueprint)
    {
       

        if (PlayerStats.Money < blueprint.cost)
        {
            Debug.Log("Not enough money");
            return;
        }
        render = false;
        GetComponent<MeshRenderer>().enabled = false;

        PlayerStats.Money -= blueprint.cost;
        GameObject _turret = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        turretBlueprint = blueprint;

        Debug.Log("Turret built! Money left: " + PlayerStats.Money);

        BuildManager.LastBuilt = gameObject;
    }

    public void UpgradeTurret()
    {
        if (PlayerStats.Money < turretBlueprint.upgradeCost)
        {
            Debug.Log("Not enough money to upgrade");
            return;
        }

        PlayerStats.Money -= turretBlueprint.upgradeCost;

        Destroy(turret);

        GameObject _turret = (GameObject)Instantiate(turretBlueprint.upgradedPrefab, GetBuildPosition(), Quaternion.identity);
        turret = _turret;

        isUpgraded = true;

        Debug.Log("Turret upgraded! Money left: " + PlayerStats.Money);
    }

    public void SellTurret()
    {
        PlayerStats.Money += turretBlueprint.GetSellAmount();

        

        Destroy(turret);
        render = true;
        turretBlueprint = null;
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if(buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }
        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            buildmode = true;
            GetComponent<MeshRenderer>().enabled = render;
            Cursor.visible = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            GetComponent<MeshRenderer>().enabled = false;
            buildmode = false;
            Cursor.visible = false;
        }
    }

    public void ObstructedTurret()
    {
        PlayerStats.Money += turretBlueprint.cost;



        Destroy(turret);
        render = true;
        turretBlueprint = null;
    }
}
