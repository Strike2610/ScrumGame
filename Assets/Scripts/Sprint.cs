using UnityEngine;

public class Sprint : MonoBehaviour {
	public Color SprintColor;
	public int SprintNumber;
	public int Value;
	public int Features;

	void Start() {
		transform.Find("Foreground").Find("SprintNr").GetComponent<TextMesh>().text = $"Sprint {SprintNumber}";
		transform.Find("Foreground").Find("ValueContainer").Find("ValueNum").GetComponent<TextMesh>().text = Value.ToString();
		transform.Find("Foreground").Find("FeaturesContainer").Find("FeaturesNum").GetComponent<TextMesh>().text = Features.ToString();
		transform.Find("Foreground").Find("ValueContainer").Find("ValueBackground").GetComponent<SpriteRenderer>().color = SprintColor;
		transform.Find("Foreground").Find("FeaturesContainer").Find("FeaturesBackground").GetComponent<SpriteRenderer>().color = SprintColor;
	}
}
