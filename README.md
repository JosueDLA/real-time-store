# Real Time Product Section
Product section of store that updates in real time.

## Software Used
* MVC5
* SignalR
* Bootbox
* DataTables

## Setup
**SignalR**
```sh
> Install-Package Microsoft.AspNetCore.SignalR
```

**Bootbox**
```sh
> Install-Package Bootbox -version:4.3.0
```

**DataTables**
```sh
> Install-Package jquery.DataTables -version:1.10.11
```

## Overview
This project uses SignalR to create a real-time web application with ASP.NET MVC5. The product section updates every time a product is deleted.
To display products it uses DataTables for pagintation, and bootbox for displaying on screen messages.

## Enable SignalR
Startup.cs

<div class="labelHolder">C#</div>

  using Microsoft.Owin;
  using Owin;

  [assembly: OwinStartupAttribute(typeof(RealTimeProducts.Startup))]
  namespace RealTimeProducts
  {
      public partial class Startup
      {
          public void Configuration(IAppBuilder app)
          {
              app.MapSignalR();
              ConfigureAuth(app);
          }
      }
  }
