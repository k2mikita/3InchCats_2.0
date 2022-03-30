using UnityEngine.UI;
using UnityEngine;

public class NodeUI : MonoBehaviour
{

    private void Start()
    {

        Hide();
    }
    public GameObject ui;

    public Text upgradeCost;
    public Button UpgradeButton;

    public Text sellAmount;

    private Node target;

    public void SetTarget(Node _target)
    {
        target = _target;

        transform.position = target.GetBuildPosition();

        

        if(!target.isUpgraded)
        {
            upgradeCost.text = "$" + target.turretBlueprint.upgradeCost;
            UpgradeButton.interactable = true;
        }
        else
        {
            upgradeCost.text = "Upgraded";
            UpgradeButton.interactable = false;
        }

        sellAmount.text = "$" + target.turretBlueprint.GetSellAmount();

        ui.SetActive(true);
    }

    public void Hide()
    {
        ui.SetActive(false);
    }

    public void Upgrade()
    {
        target.UpgradeTurret();
        BuildManager.instance.DeselectNode();
    }

    public void Sell()
    {
        target.SellTurret();
        BuildManager.instance.DeselectNode();
    }
    
}
