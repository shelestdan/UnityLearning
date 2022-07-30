using UnityEngine;

public class Note : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    [SerializeField] private Vector3 startetPosition;
    [SerializeField] private KeyCode keyCode;
    private float _speed;

    void Start()
    {
        _speed=Random.Range(minSpeed, maxSpeed);
        transform.position = startetPosition;
    }

    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            Debug.Log("Precision: " + (transform.position.y - -4.46f));
            Destroy(gameObject);
        }
        transform.position += Vector3.down * _speed * Time.deltaTime;
    }

    private void OnBecameInvisible() //вылет объекта за камеру
    {
        Destroy(gameObject);
    }
}
