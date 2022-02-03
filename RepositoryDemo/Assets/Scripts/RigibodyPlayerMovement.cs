using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigibodyPlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed;
    private Rigidbody rigibody;
    // Start is called before the first frame update
    private void Awake()
    {
        rigibody = GetComponent<Rigidbody>();//The moment the script is active, retrieve the rigibody component of the Gameobject. 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //Prefered update method when using anything revolving around physics. Ensures consistent functionality regardless of frame rate drops. 
    {
        Debug.Log("Currently detecting" + rigibody);
        rigibody.velocity = new Vector3(Input.GetAxis("Horizontal") *moveSpeed, rigibody.velocity.y, Input.GetAxis("Vertical") *moveSpeed);
    }
}
