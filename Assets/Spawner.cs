using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn; // Prefab que deseas instanciar
    public int numberOfObjects = 10; // Cantidad de objetos a generar en el círculo
    public float radius = 5f; // Radio del círculo
    public float rotationSpeed = 10f; // Velocidad de rotación de los objetos
    //COLOR
    public Gradient colorGradient;

    private void Start()
    {
        SpawnObjectsInCircle();
    }

    private void SpawnObjectsInCircle()
    {
        float angleIncrement = 360f / numberOfObjects;

        for (int i = 0; i < numberOfObjects; i++)
        {
            // Calcular el ángulo actual en radianes
            float angle = i * angleIncrement * Mathf.Deg2Rad;

            // Calcular la posición en el círculo
            float x = Mathf.Sin(angle) * radius;
            float z = Mathf.Cos(angle) * radius;

            // Instanciar el objeto y establecer su posición
            GameObject spawnedObject = Instantiate(prefabToSpawn, transform.position + new Vector3(x, 0f, z), Quaternion.identity);
            spawnedObject.transform.parent = transform; // Hacer que el objeto sea hijo de este objeto

            // Rotar el objeto
            spawnedObject.transform.Rotate(Vector3.up, angle * Mathf.Rad2Deg);

            // Agregar un componente de rotación para que los objetos giren continuamente
            spawnedObject.AddComponent<RotateObject>().rotationSpeed = rotationSpeed;



            //COLOR
            Renderer renderer = spawnedObject.GetComponent<Renderer>();

            Material material = new Material(Shader.Find("Standard"));

            material.SetColor("_Color",colorGradient.Evaluate((float)i / numberOfObjects));

            renderer.sharedMaterial = material;
        }
    }
}

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
