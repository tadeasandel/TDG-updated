using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int playerHealth = 100;
    [SerializeField] int healthDecrease = 5;
    [SerializeField] Text healthText;
    [SerializeField] AudioClip EnemyReachedBaseSFX;

    private void OnTriggerEnter(Collider other)
    {
        playerHealth -= healthDecrease;
        GetComponent<AudioSource>().PlayOneShot(EnemyReachedBaseSFX);
        healthText.text = playerHealth.ToString();
    }
    private void Start()
    {
        healthText.text = playerHealth.ToString();
    }
}
