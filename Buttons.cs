using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons;

    public void OnClick()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            if (!buttons[i].active)
                buttons[i].SetActive(true);
            else
                buttons[i].SetActive(false);
        }
    }
}
