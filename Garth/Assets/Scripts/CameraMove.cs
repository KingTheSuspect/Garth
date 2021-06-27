using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{


	public Camera cam;
	public GameObject Player;
	public enum HangiYon {Sag,Sol}
	public HangiYon yon;


	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (yon == HangiYon.Sol)
		{
			cam.transform.Translate(new Vector2(-190, 0) * 5f * Time.deltaTime);
			Player.transform.Translate(new Vector2(-25, 0) * 5f * Time.deltaTime);
		}
		if (yon == HangiYon.Sag)
		{
			cam.transform.Translate(new Vector2(190, 0) * 5f * Time.deltaTime);
			Player.transform.Translate(new Vector2(25, 0) * 5f * Time.deltaTime);
		}
	}
}
