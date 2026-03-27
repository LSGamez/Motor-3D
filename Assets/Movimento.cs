using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Transform plano;
    [SerializeField, Range(3,7)] float speed = 3;
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");
        Vector3 mover = new Vector3(movHorizontal, 0,movVertical);

        Vector3 tamanhoPlano = plano.localScale;
        Vector3 limitesPlano = tamanhoPlano/2;

        float limiteE = -limitesPlano.x;
        float limiteD = limitesPlano.x;
        float limiteC = limitesPlano.z;
        float limiteB = -limitesPlano.z;
        
        if (transform.position.x >= limiteE && transform.position.x <= limiteD)
        {     
            transform.Translate(mover * Time.deltaTime * speed);            
        }
        if (transform.position.x > limiteD)
        {
            transform.position = new Vector3(limiteD - 0.05f, 1, 0);
        } else if (transform.position.x < limiteE)
        {
            transform.position = new Vector3(limiteE + 0.05f, 1, 0);
        }

    }
}
