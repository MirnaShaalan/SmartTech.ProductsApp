# SmartTech.ProductsApp

## Deployment steps
1- make "SmartTech.ProductsCatalogTask.Web.Api" as the startup project.

2- Run `update-database` update-dataBase under "SmartTech.ProductsCatalogTask.Repository" project using package manager console.

3- after running the solution you should get your "Port Number".

4- change the port number in the clinetApp>services>productService.ts with your Port Number.

5- Run `npm i`  on the ClientApp

6- run the clientApp.

## Api Documentation

-You can find the Api Documentation (Swagger) on 

"www.localhost:"add_your_port_number_here"/index.html"
