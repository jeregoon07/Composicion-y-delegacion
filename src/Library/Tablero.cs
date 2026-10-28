using System.Net.Http.Headers;

namespace Composicion_Delegacion;
public class Tablero
{
    public string MostrarEstado(
        string modelo,
        string marca, 
        string energia)
    {
        return $"{marca} {modelo} {energia}"; 
    }
}