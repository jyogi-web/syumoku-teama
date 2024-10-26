using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosschebu : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float speedx = 10;
    public float speedy = 10;
    private float power = 10.0f;
    Rigidbody2D rb;
    Vector2 force;


    public void ugoke()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        force = new Vector2(speedx, speedy);
        myRigidBody.velocity = force;
        myRigidBody.AddForce(force,ForceMode2D.Impulse);
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        float randomDir = Random.Range(-power-5, power+5);
        rb.velocity = new Vector3(0,0);
        switch (other.gameObject.name)
        {
            case "Topwall":   //èÍçáÇP
                force = new Vector3(randomDir, -power,randomDir);
                break;
            case "BottomWall":   //èÍçáÇQ
                 force = new Vector3(randomDir, power, randomDir);
                break;
            case "RightWall":   //èÍçáÇQ
                force = new Vector3(-power,randomDir, randomDir);
                break;
            case "LeftWall":   //èÍçáÇQ
                force = new Vector3(power, randomDir, randomDir);
                break;
        }
        rb.AddForce(force, ForceMode2D.Impulse);
    }
}
