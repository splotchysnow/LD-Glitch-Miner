using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [Header ("Player Movement Input Control")]
    public float horizontalInput;
    public float VerticalInput;
    public float speed = 10;
    [Header ("Player projctile and tools control:")]
    public GameObject picAxe;
    private Vector3 pickAxeSpawnVector;


    // Update is called once per frame
    void Update()
    {
        //Player movement;
        horizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        transform.Translate(horizontalInput * Vector3.right * Time.deltaTime * speed);
        transform.Translate(VerticalInput * Vector3.up * Time.deltaTime * speed);


        pickAxeSpawnVector = transform.position + new Vector3(1,0,0);
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(picAxe, pickAxeSpawnVector, picAxe.transform.rotation);
        }
    }
}
