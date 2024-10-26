using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bosschebu : MonoBehaviour
{
    private Rigidbody2D myRigidBody;
    public float speedx = 10;
    public float speedy = 10;

    // Start is called before the first frame update
    public void ugoke()
    {
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        Vector2 force = new Vector2(speedx, speedy);
        myRigidBody.velocity = force;
        myRigidBody.AddForce(force,ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
