using UnityEngine;

public class Coin03Control : MonoBehaviour
{
    public GameObject Coin01;
    public GameObject Coin02;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Coin_01") || collision.gameObject.tag.Equals("Coin_02"))
            Debug.Log("Game Over!");
    }
}
