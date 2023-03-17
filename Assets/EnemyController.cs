using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    GameObject explosionprefab;

    [SerializeField]
    GameObject explosiontransform;

    int health = 3;

    void Start()
    {
        float x = Random.Range(-12f, 12f);

        Vector2 position = new Vector2(x, 7);

        transform.position = position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ymove = new Vector2(0, -0.007f);

        transform.Translate(ymove);

        if (transform.position.y < -7){

            Destroy(this.gameObject);

        }

    }
        private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "shot")
        {
            health--;
            if(health == 0){
            
            Instantiate(explosionprefab, transform.position, Quaternion.identity);        

            Destroy(this.gameObject);
            }
        }

        if(other.gameObject.tag == "player")
        {
            Destroy(this.gameObject);
            
        }
    }

}
