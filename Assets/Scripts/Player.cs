using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public float Force; // Add force amount
    public float jumpForce;
    public float horizontalInput;
    public float verticalInput;
    public Rigidbody2D PlayerObject; // Player Object
    public Health playerHealth;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerHealth.DecreaseHealth();
            AddForceToPlayer(new Vector2(0, jumpForce));
        }
    }
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0 || verticalInput != 0)
        {
            playerHealth.DecreaseHealth();
            AddForceToPlayer(new Vector2(horizontalInput * Force, verticalInput * Force));
        }
        // move space sff
        // move add


    }

    private void AddForceToPlayer(Vector2 force)
    {
        if(force.y < 0) 
        { 
            force.y = 0;
        }
        if(playerHealth.healthCount <= 0)
        {
            return;
        }
        PlayerObject.AddForce(force); // Add force to player


    }
}
