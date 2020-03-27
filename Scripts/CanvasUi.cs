using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUi : MonoBehaviour
{
    private Text ammoText;
    private Text weaponText;
    private GameObject inventory;

    [SerializeField] private int currMaxAmmo;

    // Start is called before the first frame update
    public void StartGettingText()
    {
        weaponText = transform.GetChild(0).GetComponent<Text>();
        ammoText = transform.GetChild(1).GetComponent<Text>();
        inventory = transform.GetChild(2).gameObject;
    }

    // Update is called once per frame
    public void UpdateWeaponAndMaxAmmo(string weapon, int i, int maxAmmo)
    {
        currMaxAmmo = maxAmmo;
        ammoText.text = "Ammo: " + i + "/" + currMaxAmmo;
        weaponText.text = weapon;
    }

    public void UpdateAmmo(int i)
    {
        ammoText.text = "Ammo: " + i + "/" + currMaxAmmo;
    }

    public void ToggleInventory(List<weapons> weapons)
    {
        if (inventory.activeSelf)
        {
            inventory.SetActive(false);
        }
        else
        {
            inventory.SetActive(true);
            UpdateInventory(weapons);
        }
    }

    public void UpdateInventory(List<weapons> weapons)
    {
        Text text = inventory.transform.GetChild(0).GetComponent<Text>();
        inventory.transform.GetChild(1).GetComponent<Text>().text = "Item count: " + weapons.Count;
        text.text = "";

        for (int i = 0; i < weapons.Count; i++)
        {
            text.text += weapons[i].ToString() + "\n";
        }
    }
}
