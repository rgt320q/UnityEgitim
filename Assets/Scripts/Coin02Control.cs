using UnityEngine;

public class Coin02Control : MonoBehaviour
{
    public GameObject Coin01;
    public GameObject Coin03;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Coin_01") || collision.gameObject.tag.Equals("Coin_03"))
            Debug.Log("Game Over!");
    }    
}
