using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public Transform[] Points;
    private Transform targetObject;
    public float movementSpeed = 1.5f;
    private int indexPoint = 0;
    private float maxDistance;
    private float speed;
    private void Start()
    {
        targetObject = Points[indexPoint];
        maxDistance = Vector3.Distance(this.transform.position, targetObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        ChangeSpeed();
        Vector3 direction = targetObject.position - transform.position;
        direction.Normalize();

        // Calcula la cantidad de movimiento en cada frame
        float movementAmount = speed * Time.deltaTime;

        // Calcula la nueva posici�n
        Vector3 newPosition = transform.position + direction * movementAmount;

        // Mueve el objeto hacia la nueva posici�n
        transform.position = newPosition;

        float distance = Vector3.Distance(this.transform.position, targetObject.transform.position);
        Debug.Log(maxDistance);
        if (distance < 0.2f)
            ChangeTarger();
    }
    public void ChangeTarger()
    {
        Debug.Log("changePoint");
        indexPoint++;
        if (indexPoint == Points.Length)
            indexPoint = 0;
        targetObject = Points[indexPoint];
        maxDistance = Vector3.Distance(this.transform.position, targetObject.transform.position);
    }
    public void ChangeSpeed()
    {
        float distance = Vector3.Distance(this.transform.position, targetObject.transform.position);
        if(distance > (maxDistance / 2))
        {
           speed = (movementSpeed / distance) + 0.5f;
        }
        else
        {
            speed = ((movementSpeed/maxDistance) * distance) + 0.5f;
        }
    }
}
