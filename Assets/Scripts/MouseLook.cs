using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public GameObject target;

    float turnSpeed = 4.0f;
    float targetDistance;
    float minTurnAngle = -90.0f;
    float maxTurnAngle = 0.0f;
    float rotX;

    PlayerController playerController;
    

    void Start()
    {
        playerController = GetComponent<PlayerController>();
        targetDistance = Vector3.Distance(transform.position, target.transform.position);

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
            MouseRotation();
    }

    private void MouseRotation()
    {

        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);

        // move the camera position
        transform.position = target.transform.position - (transform.forward * targetDistance);
    }

}
