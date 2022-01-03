using UnityEngine;

public class Goal_B : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin_03" || collision.gameObject.tag == "Coin_02" || collision.gameObject.tag == "Coin_01")
        {
            Debug.Log("Goal !!!");
        }
    }
}
