
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] objects; // �������� ������� 
    private float time = 0f;

    void Update()
    {
        time = time + Time.deltaTime;
        if(time > 2.8f)
        {
            Instantiate(objects[Random.Range(0, objects.Length)]); // �������� ������� �� �����
            time = 0f;
        }

    }
}
