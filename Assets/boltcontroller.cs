using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ymove = new Vector2(0, 0.02f);

        transform.Translate(ymove);

        if(transform.position.y > 7)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
    
}
