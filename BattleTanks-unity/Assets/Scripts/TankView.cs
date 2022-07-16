using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//View is responcerble for visualthings like ui,and ony comunicates with controller
public class TankView : MonoBehaviour
{
    private TankController _tankController;

    private float _movement;

    private float _rotation;

    public Rigidbody playerRb;

    public MeshRenderer[] childs;


    // Start is called before the first frame update
    void  Start()
    {
        GameObject cam = GameObject.Find("Main Camera");//sets cam transfom to transform of this scripts object
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3, -7);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        
        if (_movement != 0)
        {
            _tankController.Move(_movement,_tankController.GetTankModel().movementSpeed);
        }
        if (_rotation != 0)
        {
            _tankController.Rotate(_rotation,_tankController.GetTankModel().rotationSpeed);
        }
            
     
    }

    private void Movement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");

    }

    public void SetTankController(TankController TankController)
    {
        _tankController = TankController;

    }

    public Rigidbody GetRidgidBody()
    {

        return playerRb;
    }

    public void  ChangeColor(Material color)
    {
        for (int i = 0; i<childs.Length; i++)
        {
            childs[i].material=color;
        }
    }
}
