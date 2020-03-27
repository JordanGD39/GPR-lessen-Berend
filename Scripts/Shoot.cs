using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private WeaponHolderDictionary weaponHolder;
    private CanvasUi ui;

    [SerializeField] private weapons currWeapon = weapons.SMG;
    [SerializeField] private int currAmmo = 70;
    [SerializeField] private int maxAmmo = 70;

    // Start is called before the first frame update
    void Start()
    {
        weaponHolder = GetComponent<WeaponHolderDictionary>();
        ui = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasUi>();
        int tryMaxAmmo = 0;

        if (weaponHolder.WeaponsMaxAmmo.TryGetValue(currWeapon, out tryMaxAmmo))
        {
            maxAmmo = tryMaxAmmo;
        }
        ui.StartGettingText();
        ui.UpdateWeaponAndMaxAmmo(currWeapon.ToString(), currAmmo, maxAmmo);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currAmmo > 0)
        {
            currAmmo--;
            ui.UpdateAmmo(currAmmo);
        }
    }
}
