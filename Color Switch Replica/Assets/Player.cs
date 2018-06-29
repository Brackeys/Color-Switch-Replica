using UnityEngine;
using UnityEngine.SceneManagement;

namespace ColorSwitchReplica {

    public class Player : MonoBehaviour {

	    public float jumpForce = 10f;
	    public Rigidbody2D rigidBody2D;
	    public SpriteRenderer spriteRenderer;
	    public string currentColorInTheCircle;
        public Color colorPink, colorAzul;

        void Start ()
	    {
		    SetRandomColor();
	    }
	
	    // Update is called once per frame
	    void Update () {
		    if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		    {
			    rigidBody2D.velocity = Vector2.up * jumpForce;
		    }
	    }

	    void OnTriggerEnter2D (Collider2D collider2D)
	    {
		    if (collider2D.tag == "ColorChanger")
		    {
			    SetRandomColor();
			    Destroy(collider2D.gameObject);
			    return;
		    }

		    if (collider2D.tag != currentColorInTheCircle)
		    {
			    Debug.Log("GAME OVER!");
			    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		    }
	    }

	    void SetRandomColor ()
	    {
		    int colorsType = Random.Range(0, 4);

		    switch (colorsType)
		    {
			    case 0:
				    currentColorInTheCircle = "Cyan";
				    spriteRenderer.color = Color.cyan;
				    break;
			    case 1:
				    currentColorInTheCircle = "Yellow";
				    spriteRenderer.color = Color.yellow;
				    break;
			    case 2:
				    currentColorInTheCircle = "Magenta";
				    spriteRenderer.color = Color.magenta;
				    break;
			    case 3:
				    currentColorInTheCircle = "Pink";
				    spriteRenderer.color = colorPink;
				    break;
                default:
                    throw new System.NotImplementedException();
            }
	    }
    }
}