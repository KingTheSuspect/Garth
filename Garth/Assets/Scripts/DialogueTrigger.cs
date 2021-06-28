using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

	public Dialogue dialogue;
	public GameObject Canvasa;
	private bool keydowns;

	private void Update()
	{
		keydowns = Input.GetKey(KeyCode.E);
	}



	void OnTriggerEnter2D (Collider2D collision)
	{
		if (keydowns && collision.CompareTag("Player"))
		{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
			Canvasa.SetActive(true);
			Time.timeScale = 0;
		}

	}
	void OnTriggerStay2D(Collider2D collision)
	{
		if (keydowns && collision.CompareTag("Player"))
		{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
			Canvasa.SetActive(true);
			Time.timeScale = 0;
		}

	}
}