using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public Rigidbody2D m_monRigidBody;
    public Vector2 m_maVelocity;
    public Vector2 m_JumpForce;
   

    // Update is called once per frame
    void Update()
    {
        m_maVelocity = m_monRigidBody.velocity;
        if (Input.GetKey(KeyCode.A))
        {
            m_maVelocity.x = -5f;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            m_maVelocity.x = 5f;
        }
        else
            m_maVelocity.x = 0f;

        m_monRigidBody.velocity = m_maVelocity;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(m_JumpForce, ForceMode2D.Impulse);
        }

            
        
        
        


    }
}
