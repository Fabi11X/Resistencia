using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resistencia.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Resistencia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {
        /*Nombre de la escuela: Universidad Tecnologica Metropolitana

        Asignatura: Aplicaciones Web Orientadas a Servicios

        Nombre del Maestro: Chuc Uc Joel Ivan

        Nombre de la actividad: Actividad 1 "Calcular el valor de una resistencia"

        Nombre del alumno: Fabian Francisco Aguilar Rivero

        Cuatrimestre: 4

        Grupo: B

        Parcial: 2
        */

        [HttpGet]

        [Route("Ejercicio1_Calcular_Resistencia")]


        public IActionResult Calculo(string primercolor, string segundocolor, string tercercolor, string cuartocolor)
        {
            Colores clrs = new Colores();

            //ColoresExtra coloresExtra = new ColoresExtra();

            clrs.Nombre = primercolor;

            var Respuesta = "";

            switch (clrs.Nombre)
            {
                case "negro":
                    clrs.PrimerValor = 0;
                    break;
                case "cafe":
                    clrs.PrimerValor = 1;
                    break;
                case "rojo":
                    clrs.PrimerValor = 2;
                    break;
                case "naranja":
                    clrs.PrimerValor = 3;
                    break;
                case "amarillo":
                    clrs.PrimerValor = 4;
                    break;
                case "verde":
                    clrs.PrimerValor = 5;
                    break;
                case "azul":
                    clrs.PrimerValor = 6;
                    break;
                case "violeta":
                    clrs.PrimerValor = 7;
                    break;
                case "gris":
                    clrs.PrimerValor = 8;
                    break;
                case "blanco":
                    clrs.PrimerValor = 9;
                    break;
                default:
                    Respuesta = "El color que ingresaste es incorrecto";
                    return Ok(Respuesta);
            }
            var coloruno = clrs.PrimerValor;

            clrs.Nombre = segundocolor;
            switch (clrs.Nombre)
            {
                case "negro":
                    clrs.PrimerValor = 0;
                    break;
                case "cafe":
                    clrs.PrimerValor = 1;
                    break;
                case "rojo":
                    clrs.PrimerValor = 2;
                    break;
                case "naranja":
                    clrs.PrimerValor = 3;
                    break;
                case "amarillo":
                    clrs.PrimerValor = 4;
                    break;
                case "verde":
                    clrs.PrimerValor = 5;
                    break;
                case "azul":
                    clrs.PrimerValor = 6;
                    break;
                case "violeta":
                    clrs.PrimerValor = 7;
                    break;
                case "gris":
                    clrs.PrimerValor = 8;
                    break;
                case "blanco":
                    clrs.PrimerValor = 9;
                    break;
                default:
                    Respuesta = "El color que ingresaste es incorrecto";
                    return Ok(Respuesta);
            }
            var colordos = clrs.PrimerValor;


            clrs.Nombre = tercercolor;
            switch (clrs.Nombre)
            {
                case "negro":
                    clrs.SegundoValor = 1;
                    break;
                case "cafe":
                    clrs.SegundoValor = 10;
                    break;
                case "rojo":
                    clrs.SegundoValor = 100;
                    break;
                case "naranja":
                    clrs.SegundoValor = 1000;
                    break;
                case "amarillo":
                    clrs.SegundoValor = 10000;
                    break;
                case "verde":
                    clrs.SegundoValor = 100000;
                    break;
                case "azul":
                    clrs.SegundoValor = 1000000;
                    break;
                case "dorado":
                    clrs.SegundoValor = 10;
                    break;
                case "plateado":
                    clrs.SegundoValor = 100;
                    break;
               
                default:
                    Respuesta = "El color que ingresaste es incorrecto";
                    return Ok(Respuesta);
            }
            var colortres = clrs.SegundoValor;


            clrs.Nombre = cuartocolor;
            switch (clrs.Nombre)
            {
                case "dorado":
                    clrs.PrimerValor = 5;
                    break;
                case "plateado":
                    clrs.PrimerValor = 10;
                    break;

                default:
                    Respuesta = "El color que ingresaste es incorrecto";
                    return Ok(Respuesta);
            }
            var colorcuatro = clrs.PrimerValor;
            float final;
            var primernum = Int32.Parse($"{coloruno}{colordos}");


            if (tercercolor == "dorado" || tercercolor == "plateado")
            {
                final = (primernum / colortres);
            }
            else
            {
                final = (primernum * colortres);
            }

            Respuesta = "El resultado final de la resistencia es de: " + final + " ohms y Resiste una tolerancia de: " + colorcuatro + "%";

            return Ok(Respuesta);
        }



    }
}
