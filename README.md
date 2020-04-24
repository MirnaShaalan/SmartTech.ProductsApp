# SmartTech.ProductsApp

## Deployment steps
1- Make sure that "SmartTech.ProductsCatalogTask.Web.Api" is the startup project.

2- Run `update-database` under "SmartTech.ProductsCatalogTask.Repository" project using package manager console.

3- By running the solution you should get your "Port Number".

4- Change the port number in the clinetApp>services>productService.ts with your Port Number.

5- Run `npm i`  on the ClientApp.

6- Run the ClientApp.

## Api Documentation

-You can find the Api Documentation (Swagger) on :

"www.localhost:"add_your_port_number_here"/index.html"
