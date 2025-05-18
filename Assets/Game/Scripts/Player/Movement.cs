using UnityEngine;
using UnityEngine.Serialization;

public class Movement : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;

    [SerializeField] private float speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraDir = new Vector3(playerCamera.transform.forward.x, 0, playerCamera.transform.forward.z);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * Time.deltaTime * cameraDir; 
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += speed * Time.deltaTime * -cameraDir; 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += speed * Time.deltaTime * (Quaternion.AngleAxis(-90,Vector3.up)*cameraDir); 
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * Time.deltaTime * (Quaternion.AngleAxis(90,Vector3.up)*cameraDir); 
        }
    }
}
