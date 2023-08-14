# Objeto persigue otro objeto
 Varias maneras de hacer que un objeto persiga a otro.

1. Usando Vector3.MoveTowards()
https://docs.unity3d.com/ScriptReference/Vector3.MoveTowards.html

Script:

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    public Transform targetTR;

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetTR.position, step);
    }
}

Observaciones: a menos que le pongamos un rigidbody con la gravedad activada el objeto que tenga este script va a separarse del piso para seguir a su objetivo si éste está más arriba.

2. Para que mire en la dirección de su objetivo: transform.LookAt()
https://docs.unity3d.com/ScriptReference/Transform.LookAt.html

Script:

public class TurnToLookAt : MonoBehaviour
{
    public Transform targetTR;

    // Update is called once per frame
    void Update()
    {
        Vector3 currentEulerAngles = transform.eulerAngles;
        transform.LookAt(targetTR);
        transform.eulerAngles = new Vector3(currentEulerAngles.x,transform.eulerAngles.y,currentEulerAngles.z);
    }
}

Observaciones: en cada frame hacemos que el objeto esté con su eje local z orientado hacia la posición del objetivo, pero eso hace que si la altura del objetivo es diferente a la del objeto que mira este se incline arriba o abajo. Para evitar eso es que almacenamos la rotación del objeto antes del LookAt, luego hacemos el lookAt y luego volvemos a asignar la rotación restaurando los valores de x y de z que tenía previamente y dejando el valor de y.

