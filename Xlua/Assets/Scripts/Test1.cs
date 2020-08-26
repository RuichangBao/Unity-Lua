using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Test1 : MonoBehaviour
{

	public InputField inputField1;
	public InputField inputField2;
	public Text textOperator;
	public Text textResult;
	public Button btn;
	// Use this for initialization
	void Start()
	{
		Init();
		btn.onClick.AddListener(BtnOnClick);
	}
	
	[Hotfix]
	public void Init()
	{
		
	}

	private void BtnOnClick()
	{
		int num1 = int.Parse(inputField1.text);
		int num2 = int.Parse(inputField2.text);
		textResult.text = (num1 + num2).ToString();
	}

}