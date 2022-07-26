using UnityEngine;

public class Balloon : MonoBehaviour
{
    [SerializeField] private float starterSize;
    [SerializeField] private float scaleForSec;
    [SerializeField] private float scaleForSizeMax;
    private const float minSize = 1.25f;
    private const float maxSize = 7.5f;
    private float time = 0f;
    private bool gameOver;
    
    private void Start()
    {
        transform.localScale = Vector3.one * starterSize;
    }
    void Update()
    {
        if(gameOver)
        {
            return;
        }
        if (time > 0f)
        {
            time -= Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space) && time <= 0)
        {
            transform.localScale += Vector3.one * scaleForSizeMax;
            time = 0.75f;
        }
        transform.localScale -= Vector3.one * (scaleForSec * Time.deltaTime);
        if (transform.localScale.x < minSize || transform.localScale.y > maxSize)
        {
            gameOver = true;
            GameObject.Destroy(gameObject);
            Debug.Log("Balloon life time: " + Mathf.RoundToInt(Time.timeSinceLevelLoad));
        }
        
    }

}
