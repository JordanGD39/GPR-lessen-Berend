using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum weapons { SMG, ASSAULTRIFLE, REVOLVER, RPG }

public class WeaponHolderEnum : MonoBehaviour
{   

    // Start is called before the first frame update
    public int GetAmmo(weapons currWeapon)
    {
        int ammo = 0;

        switch (currWeapon)
        {
            case weapons.SMG:
                ammo = 70;
                break;
            case weapons.ASSAULTRIFLE:
                ammo = 50;
                break;
            case weapons.REVOLVER:
                ammo = 20;
                break;
            case weapons.RPG:
                ammo = 10;
                break;
        }

        return ammo;
    }
}
