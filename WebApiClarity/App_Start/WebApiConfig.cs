﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Routing;

namespace ClarityWebApi.App_Start {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {

            config.Routes.MapHttpRoute(
               name: "CUSTOM",
               routeTemplate: "api/{controller}/{action}/{id}",
               defaults: new {
                   id = RouteParameter.Optional
               }
           );

            config.Routes.MapHttpRoute(
             name: "GET",
             routeTemplate: "api/{controller}/{id}",
             defaults: new {
                 id = RouteParameter.Optional,
                 httpMethod = new HttpMethodConstraint(HttpMethod.Get)
             }
         );

            config.Routes.MapHttpRoute(
             name: "DELETE",
             routeTemplate: "api/{controller}/{id}",
             defaults: new {
                 id = RouteParameter.Optional,
                 httpMethod = new HttpMethodConstraint(HttpMethod.Delete)
             }
         );

            config.Routes.MapHttpRoute(
              name: "UPDATE",
              routeTemplate: "api/{controller}/{id}",
              defaults: new {
                  id = RouteParameter.Optional,
                  httpMethod = new HttpMethodConstraint(HttpMethod.Put)
              }
          );

            config.Routes.MapHttpRoute(
              name: "CREATE",
              routeTemplate: "api/{controller}/{id}",
              defaults: new {
                  id = RouteParameter.Optional,
                  httpMethod = new HttpMethodConstraint(HttpMethod.Post)
              }
          );

            // Uncomment the following line of code to enable query support for actions with an IQueryable or IQueryable<T> return type.
            // To avoid processing unexpected or malicious queries, use the validation settings on QueryableAttribute to validate incoming queries.
            // For more information, visit http://go.microsoft.com/fwlink/?LinkId=279712.
            //config.EnableQuerySupport();

            // To disable tracing in your application, please comment out or remove the following line of code
            // For more information, refer to: http://www.asp.net/web-api
            //config.EnableSystemDiagnosticsTracing();
        }
    }
}