using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public static float forwardforce;
    public float sidewaysForce = 500f;
        // Update is called once per frame. 
    // Add "Fixed" to Update when changing physics.

    private void Start()
    {
        if (DataHolder.speedInput < 2000) // To set a default speed if menu is skipped
        {
            forwardforce = 6000;
        }

        else
        {
            forwardforce = DataHolder.speedInput; //To match the speed to slider input from menu
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime); //Time.deltaTime helps regulate speed, AddForce produces speed.

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Move player right
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // Move player left
        }

        if(rb.position.y < -1f) //to restart when falling off edge
        {
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
