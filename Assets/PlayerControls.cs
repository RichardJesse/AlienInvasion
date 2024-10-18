using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    
    public float forwardSpeed = 25f, strafSpeed = 7.5f, hoverSpeed = 5f;
    private float activeForwardSpeed , activeStrafSpeed , activeHoverSpeed;
    private float forwardAcceleration = 2.5f, strafAcceleration = 2f, hoverAcceleration = 2f;
    public int maxHealth = 100;
    public int currentHealth;


    public float lookRateSpeed = 90f;
    private Vector2 lookInput, screenCenter, mouseDistance;

    private float rollInput;
    public float rollSpeed = 90f, rollAcceleration = 3.5f;
    public HealthBar healthBar;






    // Start is called before the first frame update
    void Start()
    {
        screenCenter.x = Screen.width * .5f;
        screenCenter.y = Screen.height * .5f;
       currentHealth = maxHealth;
       healthBar.setMaxHealth(maxHealth);
        
    }

    // Update is called once per frame
    void Update()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.y;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //Damage(10);
        }

        if(currentHealth <= 0)
        {
            Time.timeScale = 0;
        }
        mouseDistance= Vector2.ClampMagnitude(mouseDistance, 1f);

        rollInput = Mathf.Lerp(rollInput, Input.GetAxisRaw("Roll"), rollAcceleration * Time.deltaTime);

        transform.Rotate(-mouseDistance.y * lookRateSpeed * Time.deltaTime, mouseDistance.x * lookRateSpeed * Time.deltaTime, rollInput * rollSpeed * Time.deltaTime, Space.Self);


        activeForwardSpeed = Mathf.Lerp(activeForwardSpeed,  Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcceleration * Time.deltaTime);
        activeStrafSpeed = Mathf.Lerp(activeStrafSpeed , Input.GetAxisRaw("Horizontal") * strafSpeed, strafAcceleration * Time.deltaTime);
        activeHoverSpeed = Mathf.Lerp(activeHoverSpeed, Input.GetAxisRaw("Hover") * hoverSpeed, hoverAcceleration * Time.deltaTime);

        transform.position += transform.forward * activeForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * activeStrafSpeed * Time.deltaTime) + (transform.up * activeHoverSpeed * Time.deltaTime);
        
    }

   public void Damage(int damage)
    {
        currentHealth -= damage;
       healthBar.SetHealth(currentHealth);
    }
}
