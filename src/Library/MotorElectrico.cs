namespace Composicion_Delegacion;
public class MotorElectrico : IMotor
{
    public string TipoEnergia
    {
        get
        {
            return "Auto electrico";
        }
    }

    public string Arrancar()
    {
        return "El auto arranco";
    }
    public string Detener()
    {
        return "El auto se detuvo";
    }
}