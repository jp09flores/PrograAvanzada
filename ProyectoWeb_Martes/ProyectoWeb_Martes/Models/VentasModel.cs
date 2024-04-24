﻿using ProyectoWeb_Martes.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Web;

namespace ProyectoWeb_Martes.Models
{
    public class VentasModel
    {
        public ConfirmacionVentas ConsultarVentas()
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlWebApi"] + "Ventas/ConsultarVentas";
                var respuesta = client.GetAsync(url).Result;

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<ConfirmacionVentas>().Result;
                else
                    return null;
            }
        }

        public ConfirmacionVentas ConsultarVentasUsuario()
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlWebApi"] + "Ventas/ConsultarVentasUsuario";
                var respuesta = client.GetAsync(url).Result;

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<ConfirmacionVentas>().Result;
                else
                    return null;
            }
        }

        public ConfirmacionVentas ConsultarVentasMensuales()
        {
            using (var client = new HttpClient())
            {
                string url = ConfigurationManager.AppSettings["urlWebApi"] + "Ventas/ConsultarVentasMensuales";
                var respuesta = client.GetAsync(url).Result;

                if (respuesta.IsSuccessStatusCode)
                    return respuesta.Content.ReadFromJsonAsync<ConfirmacionVentas>().Result;
                else
                    return null;
            }
        }
    }
}