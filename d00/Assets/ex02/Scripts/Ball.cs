using UnityEngine;

public class Ball : MonoBehaviour
{
    float powerBall;
    bool isPunchet;
    float time;
    const float topWall = 5f;
    Vector3 direction;
    void Start()
    {
        time = 0f;
        direction = Vector3.up;
    }

    void Update()
    {
        
        if(!isPunchet)
        {
            if(transform.position.y < 3f)
            {
                direction = Vector3.up;
            }
            else if(transform.position.y > 3f)
            {
                direction = Vector3.down;
            }
            if(transform.position.y > 2.7f && transform.position.y < 3.3f)
            {
                Destroy(gameObject);
            }
            return;
        }
        time += Time.deltaTime;
        if(transform.position.y >= topWall)
        {
            direction = Vector3.down;
        }
        if(time >= 3f)
        {
            isPunchet = false;
            powerBall = 0f;
            time = 0f;
        }
        transform.Translate(direction * powerBall * Time.deltaTime);
    }

    public void Punch(float power)
    {
        isPunchet = true;
        powerBall = power;
    }
}
