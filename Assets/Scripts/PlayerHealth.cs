using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] public float health = 100F;
    Text healthtext;
    [SerializeField] bool bleeding = false;
    List<Tuple<float, string>> damageHistory;

    [SerializeField] float bleedChance = 0.1f;
    [SerializeField] float bleedRate = 0.5f;

    private void Start()
    {
        damageHistory = new List<Tuple<float, string>>();

        healthtext = GameObject.Find("/MainCamera/Canvas/Text").GetComponent<Text>();
        Color color = healthtext.color;
        color.a = 0;
        healthtext.color = color;
    }

    public void Hit(float damage, string type)
    {
        damageHistory.Add(Tuple.Create(damage, type));
        health -= damage;
        health = Mathf.Clamp(health, 0, 100);
        if (health == 0)
        {
            print("dead");
            //Destroy(gameObject);
            return;
        }          //TODO: add different types for bleed
        if (type == "fall" && UnityEngine.Random.value <= bleedChance)
        {
            print("Bleeding");

            Color color = healthtext.color;
            color.a = 1;
            healthtext.color = color;

            bleeding = true;
            StartCoroutine("Bleed");
            //intended behaviour, bleed can stack
        }
    }

    public void QuickHeal()
    {
        if (bleeding)
        {
            //play animation to stop bleeding
            bleeding = false;
            Color color = healthtext.color;
            color.a = 0;
            healthtext.color = color;
        }
        else
        {
            //play animation to heal
            health += 5;
            health = Mathf.Clamp(health, 0, 100);
        }

    }

    IEnumerator Bleed()
    {
        while (bleeding)
        {
            health -= 1;
            health = Mathf.Clamp(health, 0, 100);
            yield return new WaitForSeconds(bleedRate);
        }
    }
}