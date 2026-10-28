using System.Runtime.Serialization;

namespace Composicion_Delegacion;
public class MotorCombustion : IMotor
{
    public string TipoEnergia
    {
        get
        {
            return "Motor a combustion";
        }
    }
    public string Arrancar()
    {
        return "Auto arrancando";
    }
    public string Detener()
    {
        return "Auto deteniendose";
    }
}