using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPick;
    [SerializeField] int pointForCoin = 10;
    bool wasCollected = false;
    private void OnTriggerEnter2D(Collider2D other)
    {   
        if(other.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            FindObjectOfType<GameSessionScript>().AddToScore(pointForCoin);
            AudioSource.PlayClipAtPoint(coinPick, Camera.main.transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }   
    }
}
