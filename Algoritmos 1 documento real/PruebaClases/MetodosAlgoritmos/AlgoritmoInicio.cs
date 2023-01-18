using PruebaClases.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClases.MetodosAlgoritmos
{
    public class AlgoritmoInicio
    {
        public List<Demanda> listaDemandas = new List<Demanda>();
        public AlgoritmoInicio() 
        {
        }
        // Objetivo: Método realizará el promedio de una lista de demandas
        public double CalcularMedia(List<Demanda> listaDem) 
        {
            // Paso 1: Declarar variables y setearlas
            double media = 0, suma =0;
            // Paso 2: Calcular la variable suma (ACUMULADO)
            foreach(Demanda demanda2 in listaDem) 
            {
                suma = suma +demanda2.sumadelistas;
                
            }

            // Paso 3: Dividir entre total de datos (PROMEDIO)
            // Paso 3.1: Condicionar a tener datos en la listaDem
            if (listaDem.Count()>0) { 
                media=suma/listaDem.Count();
            }
            return media;
        }
        public double CalcularVarianza(List<Demanda> listaDem, double media)
        {
            // Paso 1: Declarar variables y setearlas
            double var = 0, suma = 0;
            // Paso 2: Calcular la variable suma (ACUMULADO)
            foreach (Demanda demanda2 in listaDem)
            {
                suma = suma + (demanda2.suma - media) * (demanda2.suma - media);

            }

            // Paso 3: Dividir entre total de datos (PROMEDIO)
            // Paso 3.1: Condicionar a tener datos en la listaDem
            if (listaDem.Count() > 0)
            {
                var =suma / listaDem.Count();
            }
            return media;
        }
        // Llena datos de manera aleatorio Uniforme
        public void LlenarDatosAleatorios(int numeroDatos,
             int limiteInferior, int limiteSuperior) 
        {
            // Paso 1: Declarar la variable aleatorio (Entrada un tiempo)
            Random aleatorio = new Random(Environment.TickCount);
            Random aleatorio2 = new Random(Environment.TickCount);
            // Paso 2: Realizar un ciclo, para generar una cantidad "numeroDatos" de valores aleatorios
            for (int i = 0; i<numeroDatos; i++) 
            {
                // (Generar valores aleatorios entre cero y uno)
                double value =  aleatorio.NextDouble();
                
                // Paso 2.1:  Generar valor aleatorio (VARIABLE) entre limite inferior y limite superior (Entero)
                double value2 = aleatorio.Next(limiteInferior, limiteSuperior);
                double value3 = aleatorio2.Next(limiteInferior, limiteSuperior);

                // Paso 2.2:  Declarar e inicializar variable "demanda"
                Demanda demanda= new Demanda();
                // Paso 2.3: Settear el atributo "idDemanda" con la variable "i" (castear)
                demanda.IdDemanda = i.ToString();
                // Paso 2.4: Asignar el "value2" a cantidad requerida 
                demanda.CantidadRequerida= value2; 7
                    demanda.suma=value2 + value 3;
                // Paso 2.5: Agregar el objeto demanda a la listaDemanda 
                listaDemandas.Add(demanda);
            }
        }
        // Main
        public double AlgoritmoGenerarAleatoriosMedia(int numeroDatos,
            int limiteInferior, int limiteSuperior) 
        {
            // Paso 0: Declarar y "settear" la variable media
            double media = 0;
            // Paso 1: Declarar e inicializar la lista Demandas
            List<Demanda> listaDemandas = new List<Demanda>();
            // Paso 2: Generar números aleatorios y llenar lista de demandas
            LlenarDatosAleatorios(numeroDatos,limiteInferior, limiteSuperior);
            // Paso 3: Calcular la media
            media = CalcularMedia(listaDemandas);
            // Paso 4: Retorna la media
            return media;
        }
    }
}
