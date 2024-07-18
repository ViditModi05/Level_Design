using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private Rigidbody rigid;

    [Header("Settings")]
    [SerializeField] private float pSpeed;
    [SerializeField] private float pRotateSpeed;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); //Making sure the rigidbody component is attached and getting in the start
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(verticalInput , 0f , -horizontalInput ) * pSpeed;
        rigid.MovePosition(rigid.position + movement * Time.deltaTime);

        if(Input.GetKey(KeyCode.LeftArrow ))
        {
           transform.Rotate(-Vector3.up * pRotateSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow));
        {
           transform.Rotate(Vector3.up * pRotateSpeed * Time.deltaTime); 
        }
    }
}
