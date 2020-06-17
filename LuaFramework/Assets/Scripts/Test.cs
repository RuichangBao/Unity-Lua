using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Test : MonoBehaviour
{
	public GameObject scrollView;
	public GameObject item;
	public Transform content;

	// Use this for initialization
	void Start()
	{
		GameObject srcoll = Resources.Load("UIPanel") as GameObject;
		scrollView = Instantiate(srcoll,Vector3.zero, Quaternion.identity);
		scrollView.transform.SetParent(GameObject.Find("Canvas").transform);
		scrollView.GetComponent<RectTransform>().offsetMax = Vector2.zero;
		item = Resources.Load("Item") as GameObject;
		content = scrollView.transform.Find("UIScrollView/Viewport/Content");
		for (int i = 0; i < 10; i++)
		{
			GameObject obj = Instantiate(item);
			GameObject objText= obj.transform.Find("Text").gameObject;
			int t = i + 1;
			objText.GetComponent<Text>().text = "第" + t + "个";
			obj.transform.Find("Button").gameObject.GetComponent<Button>().onClick.AddListener(()=> { Debug.LogError("你点击了第"+t+"个按钮"); });
			obj.transform.SetParent(content);
		}

		int count = content.childCount;
		int horizontal = count / 3;
		if (count % 3 != 0)
			horizontal++;
		int h = horizontal * (200 + 10) + 30;
		RectTransform rectTransform = content.GetComponent<RectTransform>();
		rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, h);

	}

	// Update is called once per frame
	void Update()
	{

	}
}
