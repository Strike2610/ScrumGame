using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Product : MonoBehaviour {
	public ProductSprint[] Sprints;
	public Color productColor;
	public GameObject sprintPrefab;
	public Vector2 productLocation;

	void Start() {
		for (int i = 0; i < Sprints.Length; i++) {
			var sprint = Sprints[i];
			var sprintObject = Instantiate(sprintPrefab, new Vector3(productLocation.x, productLocation.y, 0), Quaternion.identity);
			sprintObject.GetComponent<Sprint>().SprintColor = productColor;
			sprintObject.GetComponent<Sprint>().SprintNumber = i + 1;
			sprintObject.GetComponent<Sprint>().Value = sprint.Value;
			sprintObject.GetComponent<Sprint>().Features = sprint.Features;
			sprintObject.transform.localPosition += new Vector3(
				0,
				-i * (sprintObject.transform.Find("Background").localScale.y + 10),
				0);
		}
	}
}

[System.Serializable]
public class ProductSprint {

	public int Value;
	public int Features;

	public ProductSprint(int value, int features) {
		Value = value;
		Features = features;
	}

	public ProductSprint() {
	}
}