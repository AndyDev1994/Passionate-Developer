using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 10f;

	public Transform camTransform;
	public Transform lookAt;

	private Vector3 offset;
	private float currentX;
	private float currentY;


	// Use this for initialization
	void Start () {

		offset = transform.position - lookAt.transform.position;
		camTransform = transform;
	
	}
	
	// Update is called once per frame
	void Update () {


		currentX += Input.GetAxis ("Mouse X");
		currentY += Input.GetAxis ("Mouse Y");
		currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	
	}

	void LateUpdate(){
	
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * offset;
		camTransform.LookAt (lookAt.position);
	
	
	
	}




}
