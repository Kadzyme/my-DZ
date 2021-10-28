using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float health = 100f;
    [SerializeField] private Text combatLog;
    [SerializeField] private Text bossCombatLog;
    [SerializeField] private string nameOfUnit;
    [SerializeField] private Transform transform;

    public void TakeDamage(float damage, string nameOfKiller)
    {
        health -= damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
            Text thisCombatLog;
            if (gameObject.tag != "Boss")
            {
                thisCombatLog = Instantiate(combatLog, transform);
            }
            else
            {
                thisCombatLog = Instantiate(bossCombatLog, transform);
            }
            thisCombatLog.text = nameOfUnit + " was killed by " + nameOfKiller;
            thisCombatLog.tag = "Untagged";
        }
    }
}
