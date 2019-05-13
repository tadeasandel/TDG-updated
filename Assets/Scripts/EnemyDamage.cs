using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int hitpoints = 10;
    [SerializeField] ParticleSystem hitParticles;
    [SerializeField] ParticleSystem deathparticles;

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
        var vfx = Instantiate(deathparticles,transform.position,Quaternion.identity);
        vfx.Play();
        Destroy(gameObject);
    }
    private void Processhit()
    {
        hitpoints--;
        hitParticles.Play();
        print("current HP is - " + hitpoints.ToString()); 
    }

}
