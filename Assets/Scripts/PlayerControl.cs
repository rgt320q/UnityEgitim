using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public GameObject Camera;
    public float moveSpeed;

    float x, z;

    Vector3 move;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        rb.angularVelocity = Vector3.zero;
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        //if (x != 0 || z != 0)
        //{

        //    transform.rotation = Quaternion.Lerp(transform.rotation, Camera.transform.rotation, 0.1f);

        //}

        //move = new Vector3(x, 0, z) * Time.deltaTime * moveSpeed;
        //rb.MovePosition(transform.position + transform.TransformDirection(move));

        //moveJump = Input.GetAxis("Jump");
        Vector3 vectorNow = transform.position;
        vectorNow.z += 2;

        move = new Vector3(x, 0, z);



        rb.AddForce(move * moveSpeed);

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("H key down !!!!");

        //    transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * hit);
        //}
        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    Debug.Log("H key up!!!!");

        //    transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * hit);
        //}
    }



}
