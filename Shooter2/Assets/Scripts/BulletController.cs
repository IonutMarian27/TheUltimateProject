using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed;

    public float lifeTime;

    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;

        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //

            other.gameObject.GetComponent<EnemyHealthManager>().DamageEnemy(damage);
            
        }
        else
        {
             if(other.gameObject.tag == "Player")
             {
                  other.gameObject.GetComponent<PlayerHealthManager>().DamagePlayer(damage);
             }
             else
             {
                 /* Do nothing */
             }
        
        }
        
        Destroy(gameObject);
    }

}
