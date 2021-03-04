using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller = null;

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    const float walkSpeed = 2f;
    [SerializeField]
    const float runSpeed = 4f;
    [SerializeField]
    const float crawlSpeed = 1f;

    // bool walking = true;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = runSpeed;
        }
        else if(Input.GetKey(KeyCode.LeftControl))
        {
            speed = crawlSpeed;
        }
        else
        {
            speed = walkSpeed;
        }


        if (Input.GetKeyUp(KeyCode.Alpha1)) 
        {
            // do something
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // jump

        }

        // -1 and 1
        float hori = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        controller.Move(new Vector3(hori,0,vert) * Time.deltaTime * speed);
    }
}
