using UnityEngine;

public class Club : MonoBehaviour
{
    [SerializeField] float maxPower;
    [SerializeField] float timePower;
    [SerializeField] float offset;
    [SerializeField] Ball ballScript;
    [SerializeField] Transform ballTransform;
    float currentPower;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            currentPower += maxPower * Time.deltaTime / maxPower;
            if (currentPower >= maxPower)
            {
                currentPower = maxPower;
            }
            transform.position = ballTransform.position + Vector3.up * Mathf.Clamp(offset - currentPower, -1f, offset);
        }
        else
        {
            if(currentPower == 0)
            {
                return;
            }
            ballScript.Punch(currentPower);
            transform.position = ballTransform.position + Vector3.up * offset;
            currentPower = 0;
        }
    }
}
