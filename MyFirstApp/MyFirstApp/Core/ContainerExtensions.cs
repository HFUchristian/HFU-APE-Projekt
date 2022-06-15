// <copyright file="ContainerExtensions.cs" company="Marco von Ballmoos">
//   Copyright (c) 2021 Marco von Ballmoos. All rights reserved.
// </copyright>

using System;
using JetBrains.Annotations;
using MyFirstApp.Models;
using MyFirstApp.Services;
using SimpleInjector;

namespace MyFirstApp.Core
{
  public static class ContainerExtensions
  {
    public static Container CreateContainer()
    {
      return new Container()
      {
        Options =
        {
          ResolveUnregisteredConcreteTypes = true,
          AllowOverridingRegistrations = true
        }
      }.RegisterAlbumServices();
    }

    public static Container RegisterAlbumServices([NotNull] this Container container)
    {
      if (container is null) { throw new ArgumentNullException(nameof(container)); }

      container.RegisterSingleton<IDataStore<Item>, SQLiteDataStore<Item>>();

      return container;
    }
  }
}