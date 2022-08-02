using UnityEngine;

public class Ball : MonoBehaviour
{
    float powerBall, time;
    bool isPunchet;
    const float topWall = 5f;
    int score = 0;
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
                score += 15;
                Destroy(gameObject);
                Debug.Log(score);
            }
            return;
        }
        time += Time.deltaTime;
        if(transform.position.y >= topWall)
        {
            direction = Vector3.down;
            score -= 5;
            Debug.Log(score);
        }
        if (transform.position.y > 2.7f && transform.position.y < 3.3f && powerBall < 0.5f)
        {
            score += 15;
            Destroy(gameObject);
            Debug.Log(score);
        }
        if (time >= 3f)
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
