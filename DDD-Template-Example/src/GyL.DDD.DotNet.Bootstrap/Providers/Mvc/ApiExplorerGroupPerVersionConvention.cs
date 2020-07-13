﻿using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Linq;

namespace GyL.DDD.DotNet.Bootstrap.Providers.Mvc
{
	public class ApiExplorerGroupPerVersionConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var controllerNamespace = controller.ControllerType.Namespace; // e.g. "Controllers.V1"
            var apiVersion = controllerNamespace.Split('.').Last().ToLower();
            controller.ApiExplorer.GroupName = apiVersion;
        }
    }
}
