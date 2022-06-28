using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintDisplay : MonoBehaviour {
	public Sprint sprint;
	void Start() {
		transform.Find("Foreground").Find("SprintNr").GetComponent<TextMesh>().text = $"Sprint {sprint.sprintNum}";
		transform.Find("Foreground").Find("ValueContainer").Find("ValueNum").GetComponent<TextMesh>().text = sprint.Value.ToString();
		transform.Find("Foreground").Find("FeaturesContainer").Find("FeaturesNum").GetComponent<TextMesh>().text = sprint.Features.ToString();
		transform.Find("Foreground").Find("ValueContainer").Find("ValueBackground").GetComponent<SpriteRenderer>().color = sprint.SprintColor;
		transform.Find("Foreground").Find("FeaturesContainer").Find("FeaturesBackground").GetComponent<SpriteRenderer>().color = sprint.SprintColor;
	}
}
