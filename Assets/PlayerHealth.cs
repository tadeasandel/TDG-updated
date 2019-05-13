using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int playerHealth = 100;
    [SerializeField] int healthDecrease = 5;

    private void OnTriggerEnter(Collider other)
    {
        playerHealth -= healthDecrease;
    }
}
