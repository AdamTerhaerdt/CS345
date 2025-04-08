using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableRotator : MonoBehaviour
{
 public float rotationSpeed = 10;
 // Start is called before the first frame update
 void Start()
 {
 }
 // Update is called once per frame
 void Update()
 {
 // Rotate the table around x and z axis
 float newZAxisRotation = transform.rotation.eulerAngles.z;
 float newXAxisRotation = transform.rotation.eulerAngles.x;
 if(Input.GetKey(KeyCode.LeftArrow))
 newZAxisRotation += rotationSpeed * Time.deltaTime;
 if(Input.GetKey(KeyCode.RightArrow))
 newZAxisRotation -= rotationSpeed * Time.deltaTime;
 if(Input.GetKey(KeyCode.UpArrow))
 newXAxisRotation += rotationSpeed * Time.deltaTime;
 if(Input.GetKey(KeyCode.DownArrow))
 newXAxisRotation -= rotationSpeed * Time.deltaTime;

 Vector3 newRotationEulars = new Vector3(newXAxisRotation,
transform.rotation.eulerAngles.y, newZAxisRotation);
 transform.rotation = Quaternion.Euler(newRotationEulars);
 }
} 