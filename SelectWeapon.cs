using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWeapon : MonoBehaviour
{
    [SerializeField] private GameObject newWeapon;
    [SerializeField] private GameObject[] otherWeapon;
    private void Start()
    {
        gameObject.SetActive(false);
        newWeapon.SetActive(false);
    }
    public void OnClick()
    {   
        for (int i = 0; i < otherWeapon.Length; i++)
        {
            otherWeapon[i].SetActive(false);
        }
        newWeapon.SetActive(true);
    }
}
