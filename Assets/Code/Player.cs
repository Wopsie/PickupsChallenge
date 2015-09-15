using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float m_score = 0;
    public float m_slowdown = 0f;
    public bool canIRotate = false;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += (Vector3.right * Time.deltaTime);
        this.transform.position -= (Vector3.right * m_slowdown);
        //Debug.Log(m_score);
        if (canIRotate == true)
        {
            transform.Rotate(Vector3.forward * -10);
        }

    }

}
