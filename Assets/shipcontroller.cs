using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class shipcontroller : MonoBehaviour
{

    [SerializeField]
    int health = 5;

    [SerializeField]
    Slider healthMeter;

    [SerializeField]
    float speed = 0.02f;

    [SerializeField]
    GameObject bulletprefab;

    [SerializeField]
    Transform guntransform;

    float shootTimer = 0;
    float timeBetweenShots = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        healthMeter.maxValue = health;
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float ymove = Input.GetAxisRaw("Vertical");


        Vector2 movement = new Vector2(xMove, ymove) * speed * Time.deltaTime;

        transform.Translate(movement);

        shootTimer += Time.deltaTime;

        if(Input.GetAxisRaw("Fire1") > 0 && shootTimer > timeBetweenShots)
        {
            
            Instantiate(bulletprefab, guntransform.position, Quaternion.identity);        
            shootTimer = 0;
        }
    
    
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "enemy")
        {
            health--;
            healthMeter.value = health;
            print(health);

            if(health == 0)
            {
                SceneManager.LoadScene(2);
            }

        }

       

    }
}
