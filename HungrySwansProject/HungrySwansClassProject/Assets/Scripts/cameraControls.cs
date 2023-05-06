using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor.SearchService;
using UnityEngine;

public class cameraControls : MonoBehaviour
{
    [SerializeField] int sensHor;
    [SerializeField] int sensVert;

    [SerializeField] int lockVerMin;
    [SerializeField] int lockVerMax;

    [SerializeField] bool invertY;

    float xrotation;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //get input on the mouse
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensVert;
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensHor;

        //convert input to rotation float and give the option for inverted controls
        if (invertY)
            xrotation += mouseY;
        else
            xrotation -= mouseY;

        //Clamp camera rotation
        xrotation = Mathf.Clamp(xrotation, lockVerMin, lockVerMax);

        //rotate the camera on the x-axis
        transform.localRotation = Quaternion.Euler(xrotation, 0, 0);

        //rotate the player on the y-axis
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
