using UnityEngine;

public class Sun : MonoBehaviour
{
  // Start is called before the first frame update
  public float sunSpeed;
  void Start()
  {
    sunSpeed = 0.1f;
  }

  // Update is called once per frame
  void Update()
  {
    transform.Rotate(sunSpeed, 0, 0);
  }
}
