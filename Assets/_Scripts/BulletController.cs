using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("Bullet collided with " + collision.gameObject.name);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Bullet collided with " + collision.gameObject.name);
        ApplyDamage();

        bulletManager.ReturnBullet(gameObject);

    }

    public void ApplyDamage()
    {
        switch(this.gameObject.name)
        {
            case "Bullet":
                Debug.Log("10 damage");
                break;

            case "Fat Bullet":
                Debug.Log("20 damage");
                break;

            case "Pulsing Bullet":
                Debug.Log("30 damage");
                break;
        }
    }
}