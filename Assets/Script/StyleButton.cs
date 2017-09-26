﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StyleButton : MonoBehaviour 
{
	public int StyleIndex = 0;

	void Start () 
	{
		string styleText = FormData.Instance.gNoteGraphicStyleText [StyleIndex];

		Text[] buttonText = GetComponentsInChildren <Text> ();

		buttonText[0].text = styleText;
	}

	void Update () 
	{

	}

	public void ButtonSelected()
	{
		AudioController.Instance.PlayButtonClick(0);

		//Debug.LogError ("Send Message form index = " + KeyIndex);
		NeckDraw.Instance.SetCurrentStyleIndex (StyleIndex);
	}
}

