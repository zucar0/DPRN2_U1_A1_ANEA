//Definición de la clase Empleado
public class Empleado
{
    //Declaración de datos miembros
    private double salarioMensual = 0.0;
    private double bonoMensual = 0.0;
    private int numeroDeEmpleado;
    private string nombre;
    private int numeroTelefonico;
    private string correoElectronico;
    

    //Interfaz para el Salario de tipo double
    public double Salario
    {
        get 
        { 
            return salarioMensual; 
        }
        set 
        { 
            if(value < 0){
                salarioMensual = 0.0;
            }
            else{
                salarioMensual = value; 
            }
        } 
    }
    //Interfaz para el Bono mensual de tipo double
    public double BonoMensual
    {
        get
        {
            return bonoMensual;
        }
        set
        {
            if(value < 0){
                bonoMensual = 0.0;
            }
            else{
                bonoMensual = value;
            }
        }
    } 

    public double aumentarSalario (double salarioPorAumentar)
    {
        if(salarioPorAumentar >= 3000 && salarioPorAumentar <= 7000)
        {
            double salarioAumentado = salarioPorAumentar * 0.10;
            salarioPorAumentar = salarioPorAumentar + salarioAumentado;
        }
        return salarioPorAumentar;
    }

    public double salarioAnual (double salarioPorCalcular)
    {
        double salarioAnual=salarioPorCalcular*12;
        salarioPorCalcular=salarioAnual;
        return salarioPorCalcular;
    }

}