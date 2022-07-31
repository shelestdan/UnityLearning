
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] objects; // создание массива 
    private float time = 0f;

    void Update()
    {
        time += Time.deltaTime;
        if(time > 2.8f)
        {
            Instantiate(objects[Random.Range(0, objects.Length)]); // создание объекта на сцене и вызов его в рандомном порядке от самого первого и до последнего
            time = 0f;
        }

    }
}
