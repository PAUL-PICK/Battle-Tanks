
using UnityEngine;
// Controller takes care of logig in the M.V.C pattern Controller comunicates with all
public class TankController // dos not need MonoBehavier
{
    private TankModel _tankModel;// ref to the scripts
    private TankView _tankView;

    public TankController(TankModel tankModel,TankView tankView)// public function inside of class is called Constructer
    {
        _tankModel = tankModel;
        _tankView = tankView;

        _tankView.SetTankController(this);// this refers to this scrip 
        _tankModel.SetTankController(this);


        GameObject.Instantiate(tankView.gameObject);

    }
}
