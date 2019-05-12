using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int hitpoints = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        Processhit();
        if (hitpoints <= 0)
        {
            KillEnemy();
        }
    }
    private void KillEnemy()
    {
        Destroy(gameObject);
    }
    private void Processhit()
    {
        hitpoints--;
        print("current HP is - " + hitpoints.ToString()); 
    }

}
