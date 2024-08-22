using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private float horizontal;
    private Rigidbody2D playerbody;

    
    private void Start()
    {
        
        playerbody = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {

        playerbody.velocity =new Vector2( horizontal * speed,playerbody.velocity.y);
        

        
        /*// Get the touch position
        Vector2 touchPosition = Input.GetTouch(0).position;

        // Get the direction from the player to the touch position
        Vector2 direction = touchPosition - new Vector2(touchPosition.y, 0);
        direction.x = Mathf.Clamp(direction.x, -5, 5);

        // Move the player only in the x direction
        transform.position += new Vector3(direction.x, 0, 0) * speed * Time.deltaTime;
        *//*yield return WaitForSeconds(2f);*/
    }

    
    public void Playermovement(float Input)
    {
        horizontal = Input;
    }


}
