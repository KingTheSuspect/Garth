using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{


	public Camera cam;
	public float tp, cameratp;
	public enum HangiYon {Sag,Sol}
	public HangiYon yon;
	public GameObject Player;




    private void OnTriggerEnter2D(Collider2D col)
	{
		if (yon == HangiYon.Sol && col.gameObject.CompareTag("Player"))
		{
			cam.transform.Translate(new Vector2(cameratp, 0) * 5f * Time.deltaTime);
			Player.transform.Translate(new Vector2(tp, 0) * 5f * Time.deltaTime);
		}
		if (yon == HangiYon.Sag && col.gameObject.CompareTag("Player"))
		{
			cam.transform.Translate(new Vector2(cameratp, 0) * 5f * Time.deltaTime);
			Player.transform.Translate(new Vector2(tp, 0) * 5f * Time.deltaTime);
		}
	}
}
