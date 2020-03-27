using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolderDictionary : MonoBehaviour
{
    private Dictionary<weapons, int> weaponsMaxAmmo = new Dictionary<weapons, int>();
    public Dictionary<weapons, int> WeaponsMaxAmmo { get { return weaponsMaxAmmo; } }

    // Start is called before the first frame update
    void Start()
    {
        weaponsMaxAmmo.Add(weapons.SMG, 70);
        weaponsMaxAmmo.Add(weapons.ASSAULTRIFLE, 50);
        weaponsMaxAmmo.Add(weapons.REVOLVER, 20);
    }
}
