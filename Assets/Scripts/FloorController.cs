using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin_01") || collision.gameObject.CompareTag("Coin_02")|| collision.gameObject.CompareTag("Coin_03"))
            Debug.Log("Game Over! (The coin down the floor.)");
    }
}
