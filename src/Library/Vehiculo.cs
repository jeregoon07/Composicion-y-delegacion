using System.Linq.Expressions;
using System.Runtime.InteropServices.Java;

namespace Composicion_Delegacion;
public class Vehiculo
{
    public string Modelo{get; private set;}
    public string Marca{get; private set;}
    private IMotor motor;
    private SistemaFrenos frenos;
    private Tablero tablero;
    private Vehiculo(string modelo, string marca, IMotor motor)
    {
        Marca=marca;
        Modelo= modelo;
        this.motor=motor;
        frenos= new SistemaFrenos();
        tablero = new Tablero();
    }
    public static Vehiculo CrearElectrico(
        string marca,
        string modelo)
        {
            return new Vehiculo(
                marca,
                modelo,
                new MotorElectrico());
        }
    public static Vehiculo CrearCombustion
    (
        string marca,
        string modelo)
        {
            return new Vehiculo
            (
                marca, 
                modelo,
                new MotorCombustion());
        }
    public string Encender()
    {
        return motor.Arrancar();
    }
    public string Apagar()
    {
        return motor.Detener();
    }
    public string Frenar()
    {
        return frenos.Frenar();
    }
    public string MostrarEstado()
    {
        return tablero.MostrarEstado(
            Marca,
            Modelo,
            motor.TipoEnergia);
    }
}