using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private bool isWinzone;
    [SerializeField] private bool isSpawnZone;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && isSpawnZone)
        {
            Instantiate(enemy, spawnPoint.position, Quaternion.identity);
            isSpawnZone = false;
            Settings.isSpawned = true;
            SoundManager.Instance.audioSource.loop = false;
            SoundManager.Instance.audioSource.PlayOneShot(SoundManager.Instance.enemySound);
            
        }
        if(other.CompareTag("Player") && isWinzone)
        {
            Settings.isWon = true;            
            isWinzone = false;
            SoundManager.Instance.audioSource.loop = false;
            SoundManager.Instance.audioSource.PlayOneShot(SoundManager.Instance.winSound);
        }
    }
}
