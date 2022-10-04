using UnityEngine;

public class Test : MonoBehaviour
{
  // Start is called before the first frame update

  // Las variables necesitan ; al final
  // Int numero entero
  // Float numero flotante 0.25f (necesita la f al final)
  // char = caracter
  // string = string
  // bool = variable booleana
  // Debug.Log imprime en consola

  public float vida;
  public bool dead = false;
  public float baseSpeed = 0.01f;
  public int playerSpeed;
  public Vector3 pos;
  public char direction = 'D';
  public int rotate = 1;
  void Start()
  {
    vida = 100f;
    playerSpeed = 10;

    transform.localScale += new Vector3(0.3f, 0.3f, 0.3f);
  }

  // Update is called once per frame mientras más FPS más veces se llama a Update
  void Update()
  {
    transform.Rotate(0, rotate, 0);
    if (transform.position.y < 4)
    {
      transform.Translate(0, baseSpeed, 0);
    }
    if (transform.position.y > 4)
    {
      transform.Translate(0, 0, 0);
    }
    if (transform.position.z >= 3.5)
    {
      direction = 'R';
    }
    if (transform.position.z <= -5.9)
    {
      direction = 'D';
    }
    if (direction == 'D')
    {
      transform.Translate(0, -(baseSpeed) * playerSpeed, 0);
    }
    if (direction == 'R')
    {
      transform.Translate(0, baseSpeed * playerSpeed, 0);
    }

    if (dead == false)
    {
      Debug.Log(dead);
      Damage();
    }

    if (dead == true)
    {
      Debug.Log(dead);
      Health();
    }

    Debug.Log(vida);

  }

  void Damage()
  {
    vida = vida - (1 * Time.deltaTime);
    if (vida <= 0)
    {
      dead = true;
    }
  }

  void Health()
  {
    vida = vida + (1 * Time.deltaTime);
    if (vida >= 100)
    {
      dead = false;
    }
  }
}
