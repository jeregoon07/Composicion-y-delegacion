namespace Composicion_Delegacion;

public interface IMotor
{
    string TipoEnergia {get;}
    string Arrancar();
    string Detener();
}
