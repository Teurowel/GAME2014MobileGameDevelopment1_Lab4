using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed = 0f;
    public float horizontalBoundary = 2.6f;

    private float direction = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        direction = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _Checkbounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    private void _Checkbounds()
    {
        //Check if on the right boundary
        if(transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }
        else if(transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }

}
