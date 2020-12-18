using System;
using System.Collections.Generic;

namespace Aforo
{
    class Program
    {
        static void Main(string[] args)
        {
            int aforo = CalculoAforo(120, TipoActividad.comercialZonasComunes, new List<int> { 40,38,37,10,150}, 0, 0);
            Console.WriteLine("Aforo recomendado: {0}", aforo);
        }

        /// <summary>
        /// Calculo AFORO segun el area en [METROS CUADRADOS]
        /// </summary>
        /// <param name="area">Area disponible para uso publico en [METROS CUADRADOS].</param>
        /// <param name="tipoActividad">Zona o tipo de actividad</param>
        /// <param name="numeroEsperadoPersonas">Array de numero estimado de personas o registros anteriores.</param>
        /// <param name="areUtil">Are util a ser utilizada por las personas</param>
        /// <param name="areaUtilPorcentaje">Area util a ser utilizada por las personas en [PORCENTAJE % de 1 a 100]</param>
        /// <returns></returns>
        /// <remarks>Para efectos del cálculo del aforo, no se tendrá en consideración a los trabajadores del lugar.</remarks>
        public static int CalculoAforo(double area, TipoActividad tipoActividad, List<int> numeroEsperadoPersonas, double areUtil = 0, double areaUtilPorcentaje = 0) 
        {
            #region AreaUtil: El calculo de area util es solo para la comodidad del usuario
            if (areUtil > 0)
            {
                area = area - areUtil;
            }
            else if (areaUtilPorcentaje > 0 && areaUtilPorcentaje < 100)
            {
                area = area - area * areaUtilPorcentaje / 100;
            }
            //En los casos cuya área útil sea inferior a diez metros cuadrados, el aforo máximo será
            // de una persona.
            if (area < 10)
            {
                return 1;
            }
            #endregion

            // Asignaciones
            int actividad = (int)tipoActividad;
            double aforo = area / 3.46;
            double aforoSegunActividad = area / actividad;
            int countAforo = 1;
            int countAforoActividad = 0;
            // Delta assigment
            var delta = 0.01;

            foreach (var numero in numeroEsperadoPersonas)
            {
                if (Math.Abs(area/numero - 3.46) < delta)
                {
                    countAforo ++;
                }
                else if (Math.Abs(area / numero - actividad) < delta)
                {

                    countAforoActividad++;
                }
            }

            if (countAforoActividad < countAforo)
            {
                return (int)Math.Ceiling(aforo);
            }
            else
            {
                return (int)Math.Ceiling(aforoSegunActividad);
            }
        }

        public enum TipoActividad 
        {
            // Residencial publico
            residencialPublico = 2,
            vestibulos = 3,

            // Administrativo
            zonaUsopublico = 2,

            // Docente
            aulas = 2,
            aulasEscuelasInfantiles = 3,
            zonaDeLectura = 2,

            // Hospitalario
            salaDeEspera = 2,

            // Comercial
            establecimientoComercial = 3,
            entreplantaComercial = 2,
            zonaComunComercial = 3,
            plazaComidas = 2,
            comercialZonasComunes = 3,

            // Concurrencia publica
            publica = 2,
            especatdoresSentados = 2,
            especatdoresDepie = 2,
            discoteca = 1,
            cafeteria = 1,
            bar = 1,
            gimnasio = 2,
            museos = 3,
            exposiciones = 3,
        }
    }
}
