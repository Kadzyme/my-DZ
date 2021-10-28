using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCombatLog : MonoBehaviour
{
    [SerializeField] private float timeToDestroy;

    void Start()
    {
        if (gameObject.tag != "Boss")
        {
            Destroy(gameObject, timeToDestroy);
        }
    }
}
