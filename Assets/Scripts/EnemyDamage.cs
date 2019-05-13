using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField] int hitpoints = 10;
    [SerializeField] ParticleSystem hitParticles;
    [SerializeField] ParticleSystem deathparticles;
    [SerializeField] AudioClip hitEnemySFX;
    [SerializeField] AudioClip enemyDeathSFX;

    AudioSource myAudiosource;

    // Start is called before the first frame update
    void Start()
    {
        myAudiosource = GetComponent<AudioSource>();
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
        Destroy(vfx.gameObject, vfx.main.duration);
        AudioSource.PlayClipAtPoint(enemyDeathSFX,Camera.main.transform.position,0.1f);
        Destroy(gameObject);
    }
    private void Processhit()
    {
        GetComponent<AudioSource>().PlayOneShot(hitEnemySFX);
        hitpoints--;
        hitParticles.Play();
    }

}
