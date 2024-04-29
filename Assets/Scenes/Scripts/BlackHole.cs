using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        // Destroy(Enemy);
    }

    //void KillEnemy()
    //{
       //if(Spawner != null)  Spawner.currentEnemy.Remove(this.gameObject);
    //}
}
