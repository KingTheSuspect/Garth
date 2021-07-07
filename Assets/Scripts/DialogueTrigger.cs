using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{

	public Dialogue dialogue;
	public GameObject Canvasa;
	private bool keydowns;
	private bool triggerd = false;
	[HideInInspector]public int sayar = 0;
    private int maxdok;
	public int buyuktur;




    void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			triggerd = true;
		}
	}
	void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			triggerd = true;
		}
	}
	void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			triggerd = false;
		}
	}
	void Update()
	{
		keydowns = Input.GetKeyDown(KeyCode.E);

		if (keydowns && triggerd == true && sayar == 0 && maxdok < buyuktur)
		{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
			Canvasa.SetActive(true);
			++sayar;
			maxdok++;
			Time.timeScale = 0;
		}
		if (keydowns && triggerd == true && sayar == 1)
		{
			FindObjectOfType<DialogueManager>().DisplayNextSentence();


		}


	}

}