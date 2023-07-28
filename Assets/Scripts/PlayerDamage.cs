using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && Settings.isDead == false)
        {
            Settings.isDead = true;
            SoundManager.Instance.audioSource.loop = false;
            SoundManager.Instance.audioSource.PlayOneShot(SoundManager.Instance.gameOverSound);
        }
    }
}
