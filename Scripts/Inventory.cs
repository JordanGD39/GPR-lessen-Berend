using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<weapons> inventory = new List<weapons>();

    private CanvasUi ui;

    // Start is called before the first frame update
    void Start()
    {
        inventory.Add(weapons.SMG);
        inventory.Add(weapons.ASSAULTRIFLE);
        inventory.Add(weapons.REVOLVER);
        ui = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasUi>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ui.ToggleInventory(inventory);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            int rand = Random.Range(0, System.Enum.GetValues(typeof(weapons)).Length);
            inventory.Add((weapons)rand);
            ui.UpdateInventory(inventory);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            int rand = Random.Range(0, inventory.Count);
            inventory.Remove((weapons)rand);
            ui.UpdateInventory(inventory);
        }
    }
}
