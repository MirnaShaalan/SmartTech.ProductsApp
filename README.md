# SmartTech.ProductsApp

## Deployment steps
1- make "SmartTech.ProductsCatalogTask.Web.Api" as startup project.

2- Run `update-database` update-dataBase under project "SmartTech.ProductsCatalogTask.Repository" using package manager console.

3- after running the solution you should get your "PortNumber".

4- change the port number in the clinetApp>services>productService.ts with your Port Number.

5- run the clientApp.
Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Api Documentation

-You can find the Api Documentation (Swagger) on 
"localhost:"Add your Port Number Here"/index.html"
