using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private float moveSpeed;//Controls how fast the object moves. 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input based controls for the player character. 

        if (Input.GetKey(KeyCode.RightArrow))//If the player pushes down on the right arrow key.
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.right;//The position of the object goes to the right. 
        }
        if (Input.GetKey(KeyCode.LeftArrow))//If the player pushes down on the left arrow key. 
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.left;//The player moves to the left. 
        }
        if (Input.GetKey(KeyCode.UpArrow))//If the player pushes down on the up arrow key
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.forward; //The player moves forward. 
        }
        if (Input.GetKey(KeyCode.DownArrow)) //If the player pushes down on the down arrow key. 
        {
            transform.position += Time.deltaTime * moveSpeed * Vector3.back;//They player moves backwards. 
        }
    }
}
