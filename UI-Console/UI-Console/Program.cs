﻿using Dao.Contracts;
using Dao.Factory;
using Domain;
using Logic;
using Services.Domain;
using Services.Domain.Composite;
using Services.Facade;
using Services.Facade.Extentions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UI_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Log log = new Log(DateTime.Now, "Probando bitacora....");


            LoggerService.WriteLog(log);


            try
            {

             throw new Exception("Excepcion inesperada....");
            }
            catch (Exception ex)
            {
                Log log2 = new Log(DateTime.Now, "Error....",TraceLevel.Error);
                LoggerService.WriteLog(log2, ex);
                throw;
            }

            //Permiso permiso = new Permiso();
            //permiso.Id = Guid.NewGuid();
            //permiso.Name = "Gestion de Ventas";
            //permiso.DataKey = "mnuGestionVentas";

            //Permiso permiso2 = new Permiso();
            //permiso2.Id = Guid.NewGuid();
            //permiso2.Name = "Visualizacion de Gestion de Ventas";
            //permiso2.DataKey = "mnuVisualizacionGestionVentas";

            //Perfil perfil = new Perfil(permiso);
            //perfil.Id = Guid.NewGuid();
            //perfil.Name = "Rol/Perfil de Ventas";

            //Perfil perfil2 = new Perfil(permiso2);
            //perfil2.Id = Guid.NewGuid();
            //perfil2.Name = "Rol/Perfil Visualizacion de Ventas";

            //Perfil perfilAdmin = new Perfil(perfil);
            //perfilAdmin.Id = Guid.NewGuid();
            //perfilAdmin.Name = "Rol Administrador";
            //perfilAdmin.Add(perfil2);

            //Usuario user = new Usuario();
            //user.Id = Guid.NewGuid();
            //user.UserName = "ian";
            //user.Password = "PaisesBajos2024";
            //user.Mail = "ian.paisesbajos@mail.com";
            //user.Accesos.Add(perfilAdmin);

            //Permiso permiso3 = new Permiso();
            //permiso3.Id = Guid.NewGuid();
            //permiso3.Name = "Gestion de Compras";
            //permiso3.DataKey = "mnuGestionCompras";

            //user.Accesos.Add(permiso3);

            //foreach (var item in user.Accesos)
            //{
            //    if(item.GetCount() > 0)
            //    {
            //        //Perfil -> Familia -> Composite
            //        Perfil perf = item as Perfil;
            //        //Funcion recursiva....
            //        foreach (var perm in perf.Accesos)
            //        {
            //            if (perm.GetCount() == 0)
            //            {
            //                Permiso p = perm as Permiso;
            //                Console.WriteLine($"Soy un permiso {p.DataKey}");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Permiso p = item as Permiso;
            //        Console.WriteLine($"Soy un permiso {p.DataKey}");
            //    }
            //}

            Console.ReadKey();

            //Clase 26/04

            //string culturaActual = Thread.CurrentThread.CurrentUICulture.Name;
            //string word = "Hola".Translate();

            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-EN");

            //culturaActual = Thread.CurrentThread.CurrentUICulture.Name;

            //word = "Hola".Translate();

            //Hoy tengo una implementación in memory de mi Dao
            //ICustomerDao customerDao = FactoryDao.CustomerDao;

            //Customer demo = new Customer();
            //demo.Code = 23;
            //demo.Name = "2604";

            //customerDao.Add(demo);

            //foreach (var item in customerDao.GetAll())
            //{
            //    Console.WriteLine($"id: {item.IdCustomer}, code: {item.Code}");
            //}

            //Customer customerGonzalez = customerDao.GetById(Guid.Parse("F5705F68-1FBB-44C7-9DFF-ED98021BDE1E"));


            //customerDao.Add(new Customer(0, "Nuevo Producto"));

            //Customer customerById = customerDao.GetById(Guid.Parse("71154AF7-E604-446E-8BE3-2A41F5694AE3"));
            //customerById.Category = CategoryEnum.Standard;

            //customerDao.Remove(Guid.Parse("71154AF7-E604-446E-8BE3-2A41F5694AE3"));

            //customerById = customerDao.GetById(Guid.Parse("71154AF7-E604-446E-8BE3-2A41F5694AE3"));
            //customerById.Name = "Aprendiendo repository pattern";
            //customerDao.Update(customerById);

            //Acceso a objetos y servicios DEL NEGOCIO!!!
            //Customer customer = new Customer(1, "Deian");

            //CustomerLogic customerLogic1 = CustomerLogic.GetInstance();
            //customerLogic1.Contador++;
            //CustomerLogic customerLogic2 = CustomerLogic.GetInstance();
            //customerLogic2.Contador++;

            //CustomerLogic.GetInstance().Contador++;

            //Console.WriteLine(customerLogic1.Contador);

            //Console.WriteLine($"Son iguales cL1 y cL2? {customerLogic1 == customerLogic2} ");

            //customerLogic1.SaveOrUpdate(customer);

            //Acceso a objetos y servicios de Arq.Base
            //User user = new User();
            //UserService.Register(user);

            //Console.WriteLine("Test de github");

            //Probemos leer el archivo de configuración:

            //Console.WriteLine($"Leyendo el path del log {ConfigurationManager.AppSettings["FileLogPath"]}");
            //Console.WriteLine($"Leyendo conn app {ConfigurationManager.ConnectionStrings["AppSqlConnection"].ConnectionString}");


        }
    }
}
