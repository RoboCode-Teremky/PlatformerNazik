using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Coin : MonoBehaviour
{
    public static UnityEvent pickCoin = new UnityEvent();
    
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.CompareTag("Player")){
            pickCoin.Invoke();
        }
        pickCoin.Invoke();
        Destroy(gameObject);         
    }
}
