﻿using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.IO;

public class DataRead : MonoBehaviour {

	public bool canChange;
	public Loading loading;
	public TypeOfData type;
	public InputField input;

	public int idKey;

	void Awake (){
		if (canChange)
			loading = Camera.main.GetComponent<Loading> ();
		loading.LoadWords (idKey);
	}

	void Update (){
		
		if (canChange && loading.output != this.type) {
			this.type = loading.output;
			loading.LoadWords (idKey);
		}	
	}


	public void LoadChanges (Words index){

		if (index.key != idKey)
			return;
		switch(type)
		{
		case TypeOfData.key:
			input.text = index.key.ToString();
			break;
		case TypeOfData.english:
			input.text = index.english;
			break;
		case TypeOfData.spanish:
			input.text = index.spanish;
			break;
		case TypeOfData.catalan:
			input.text = index.catalan;
			break;
		case TypeOfData.galician:
			input.text = index.galician;
			break;

		}

	}
}
