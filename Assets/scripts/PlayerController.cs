using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask groundMask;
[SerializeField] float speed = 12f;
Vector3 velocity;
CharacterController characterController;
void Start()
{
characterController = GetComponent<CharacterController>();
}
void Update()
{
PlayerMove();
}
void PlayerMove()
{
    RaycastHit hit;
    if (Physics.Raycast(groundCheck.position, transform.TransformDirection(Vector3.down), out hit, 0.4f, groundMask))
    {
        string terrainType;
        terrainType = hit.collider.gameObject.tag;

        switch (terrainType)
        {
            case "High":
            speed = 20;
            break;
            case "Low":
            speed = 3;
            break;
            default:
            speed = 12;
            break;
        }
    }


float x = Input.GetAxis("Horizontal");
float z = Input.GetAxis("Vertical");
Vector3 move = transform.right * x + transform.forward * z;
characterController.Move(move * speed * Time.deltaTime);
}
}
