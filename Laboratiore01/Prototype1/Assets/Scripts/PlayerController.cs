using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Valeurs modifiables dans l'inspecteur
    public float speed = 20;
    public float turnSpeed;

    // Valeurs privées
    private float horizontalInput;
    private float forwardInput;

    // Bonus
    private bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bonus - Arrêt de la voiture
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            canMove = false;
        } 
        // Bonus - Démarrage de la voiture
        else if (Input.GetKeyDown(KeyCode.UpArrow)){
            canMove = true;
        }

        if (canMove){
            // Prise des valeurs pour le mouvement du véhicule
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");

            // Faire avancer le véhicule
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

            // Faire tourner le véhicule
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
}
