using UnityEngine;

public class Coin01Control : MonoBehaviour
{
    public GameObject Coin02;
    public GameObject Coin03;    

    //private void FixedUpdate()
    //{
    //    RaycastHit hit;

    //    if (Physics.Raycast(transform.position, Coin02.transform.position, out hit))
    //    {
    //      Debug.DrawLine(transform.position, Coin02.transform.position * hit.distance, Color.yellow);
    //      Debug.Log("Coin01 hit to Coin02"+hit.distance);
    //    }
    //    else
    //    {
    //        Debug.Log("Coin01 Not hit to Coin02");
    //        Debug.DrawLine(transform.position, Coin02.transform.position * 100, Color.green);
    //    }
    //}

    private void FixedUpdate()
    {
        RaycastHit hitInfo;
        

        if (Physics.Raycast(transform.position,Coin02.transform.position, out hitInfo))
        {
            Debug.DrawLine(transform.position, Coin02.transform.position, Color.green);
            Debug.Log("hitting : "+ hitInfo.transform.name);
        }
        else
        {
            Debug.DrawLine(transform.position, Coin02.transform.position, Color.black);
            Debug.Log("It Not hitting the coin!");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Coin_02") || collision.gameObject.tag.Equals("Coin_03"))
            Debug.Log("Game Over!");
    }
}
