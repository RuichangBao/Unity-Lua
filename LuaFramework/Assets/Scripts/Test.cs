using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test : MonoBehaviour
{
	public GameObject scrollView;
	public GameObject item;
	
	
	// Use this for initialization
	void Start()
	{
		GameObject srcoll = Resources.Load("UIScrollView") as GameObject;
		scrollView = Instantiate(srcoll);
		scrollView.transform.SetParent(GameObject.Find("Canvas").transform);
		item = Resources.Load("Item") as GameObject;
		for (int i = 0; i < 10; i++)
		{
			GameObject obj = Instantiate(item);
			GameObject objText= obj.transform.Find("Text").gameObject;
			objText.GetComponent<Text>().text = "第" + i + "个";
			int t = i;
			obj.transform.Find("Button").gameObject.GetComponent<Button>().onClick.AddListener(()=> { Debug.LogError("你点击了第"+t+"个按钮"); });
			obj.transform.SetParent(scrollView.transform);
		}

		int count=scrollView.transform.childCount;
		int horizontal = count / 3;
		if (count % 3 != 0)
			horizontal++;
		int h = horizontal * (200 + 10) + 30;
		RectTransform rectTransform = scrollView.GetComponent<RectTransform>();
		rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x,h);

	}

	// Update is called once per frame
	void Update()
	{

	}
}
