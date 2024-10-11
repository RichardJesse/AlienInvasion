using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float forwardSpeed = 25f, strafSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed , activeStrafSpeed , activeHoverSpeed;
    private float forwardAcceleration = 2.5f, strafAcceleration = 2f, hoverAcceleration = 2f;

    public float lookRateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;

    // Start is called before the first frame update
    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;
        
    }

    // Update is called once per frame
    void Update()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.x;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        transform.Rotate(-mouseDistance.y * lookRateSpeed * Time.deltaTime, mouseDistance.x * lookRateSpeed * Time.deltaTime, 0f, Space.Self);


        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed,  Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafSpeed = Mathf.Lerp(activeStrafSpeed , Input.GetAxisRaw("Horizontal") * strafSpeed, strafAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Hover") * hoverSpeed, hoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * activeStrafSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);
        
    }
}
